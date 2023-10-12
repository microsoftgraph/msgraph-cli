using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Hosting;
using System.CommandLine.IO;
using System.CommandLine.Parsing;
using System.Diagnostics.Tracing;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ApiSdk;
using ApiSdk.Models.ODataErrors;
using Azure.Core.Diagnostics;
using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Authentication;
using Microsoft.Graph.Cli.Core.Authentication;
using Microsoft.Graph.Cli.Core.Commands.Authentication;
using Microsoft.Graph.Cli.Core.Configuration;
using Microsoft.Graph.Cli.Core.Http;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.Http;
using Microsoft.Kiota.Cli.Commons.Http.Headers;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;

namespace Microsoft.Graph.Cli
{
    class Program
    {
        private static bool debugEnabled = false;
        private static AzureEventSourceListener? listener = null;

        static async Task<int> Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            var builder = BuildCommandLine()
                .UseDefaults()
                .UseHost(CreateHostBuilder)
                .UseRequestAdapter(ic =>
                {
                    var host = ic.GetHost();
                    var adapter = host.Services.GetRequiredService<IRequestAdapter>();
                    var client = host.Services.GetRequiredService<HttpClient>();
                    if (string.IsNullOrEmpty(adapter.BaseUrl))
                    {
                        adapter.BaseUrl = client.BaseAddress?.ToString();
                    }
                    adapter.BaseUrl = adapter.BaseUrl?.TrimEnd('/');
                    return adapter;
                })
                .RegisterCommonServices()
                .RegisterHeadersOption(() => InMemoryHeadersStore.Instance);
            builder.AddMiddleware(async (ic, next) =>
            {
                var host = ic.GetHost();

                ic.BindingContext.AddService(_ => host.Services.GetRequiredService<IAuthenticationCacheManager>());
                ic.BindingContext.AddService(_ => host.Services.GetRequiredService<AuthenticationServiceFactory>());
                // Needed by LogoutCommand
                ic.BindingContext.AddService(_ => host.Services.GetRequiredService<LogoutService>());
                await next(ic);
            });
            builder.UseExceptionHandler((ex, context) =>
            {
                var message = ex switch
                {
                    _ when ex is AuthenticationRequiredException => "Token acquisition failed. Run mgc login command first to get an access token.",
                    _ when ex is TaskCanceledException => string.Empty,
                    ODataError _e when ex is ODataError => $"Error {_e.ResponseStatusCode}({_e.Error?.Code}) from API:\n  {_e.Error?.Message}",
                    ApiException _e when ex is ApiException => $"Error {_e.ResponseStatusCode} from API.",
                    AuthenticationFailedException e => $"Authentication failed: {e.Message}",
                    Identity.Client.MsalException e => $"Authentication failed: {e.Message}",
                    _ => ex.Message
                };

                var exitCode = ex switch
                {
                    _ when ex is AuthenticationRequiredException => 1,
                    _ when ex is TaskCanceledException => 0,
                    _ => -1
                };

                if (!string.IsNullOrEmpty(message))
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    context.Console.Error.WriteLine(message);
                    Console.ResetColor();
                }

                context.ExitCode = exitCode;
            });

            try
            {
                var parser = builder.Build();
                return await parser.InvokeAsync(args);
            }
            finally
            {
                listener?.Dispose();
            }
        }

        static CommandLineBuilder BuildCommandLine()
        {
            var rootCommand = new GraphClient().BuildRootCommand();
            rootCommand.Description = "Microsoft Graph CLI";

            var builder = new CommandLineBuilder(rootCommand);
            var debugOption = new Option<bool>("--debug", "Enable debug output");

            builder.AddMiddleware(async (ic, next) =>
            {
                debugEnabled = ic.ParseResult.GetValueForOption<bool>(debugOption);
                if (debugEnabled)
                {
                    listener = CreateStdErrLogger(EventLevel.LogAlways);
                }
                else
                {
                    listener = CreateStdErrLogger(EventLevel.Error);
                }
                await next(ic);
            });

            rootCommand.AddCommand(new LoginCommand(builder));
            rootCommand.AddCommand(new LogoutCommand());
            rootCommand.AddGlobalOption(debugOption);

            return builder;
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder().ConfigureHostConfiguration((configHost) =>
            {
                configHost.SetBasePath(Directory.GetCurrentDirectory());
            }).ConfigureAppConfiguration((ctx, config) =>
            {
                ConfigureAppConfiguration(config, args);
            }).ConfigureServices((ctx, services) =>
            {
                var authSection = ctx.Configuration.GetSection(nameof(AuthenticationOptions));
                services.Configure<AuthenticationOptions>(authSection);
                services.AddTransient<LoggingHandler>();
                services.AddSingleton<HttpClient>(p =>
                {
                    var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
                    var options = new GraphClientOptions
                    {
                        GraphProductPrefix = "graph-cli",
                        GraphServiceLibraryClientVersion = $"{assemblyVersion?.Major ?? 0}.{assemblyVersion?.Minor ?? 0}.{assemblyVersion?.Build ?? 0}",
                        GraphServiceTargetVersion = "1.0"
                    };
                    var headersHandler = new NativeHttpHeadersHandler(() => InMemoryHeadersStore.Instance, p.GetService<ILogger<NativeHttpHeadersHandler>>());
                    return GraphCliClientFactory.GetDefaultClient(options, loggingHandler: p.GetRequiredService<LoggingHandler>(), middlewares: new[] { headersHandler });
                });
                services.AddSingleton<IAuthenticationProvider>(p =>
                {
                    var authSettings = p.GetRequiredService<IOptions<AuthenticationOptions>>()?.Value;
                    var serviceFactory = p.GetRequiredService<AuthenticationServiceFactory>();
                    AuthenticationStrategy authStrategy = authSettings?.Strategy ?? AuthenticationStrategy.DeviceCode;
                    var credential = serviceFactory.GetTokenCredentialAsync(authStrategy, authSettings?.TenantId, authSettings?.ClientId, authSettings?.ClientCertificateName, authSettings?.ClientCertificateThumbPrint);
                    credential.Wait();
                    var client = p.GetRequiredService<HttpClient>();
                    return new AzureIdentityAuthenticationProvider(credential.Result);
                });
                services.AddSingleton<IRequestAdapter>(p =>
                {
                    var authProvider = p.GetRequiredService<IAuthenticationProvider>();
                    var client = p.GetRequiredService<HttpClient>();

                    // Serializers needed for error parsing
                    ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
                    ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
                    ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
                    // Deserializers needed for error parsing & request body deserialization
                    ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
                    ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
                    ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();

                    return new HttpClientRequestAdapter(authProvider, httpClient: client);
                });
                services.AddSingleton<IPathUtility, PathUtility>();
                services.AddSingleton<IAuthenticationCacheManager, AuthenticationCacheManager>();
                services.AddSingleton<LogoutService>();
                services.AddSingleton<AuthenticationServiceFactory>(p =>
                {
                    var authSettings = p.GetRequiredService<IOptions<AuthenticationOptions>>()?.Value;
                    var pathUtil = p.GetRequiredService<IPathUtility>();
                    var cacheUtil = p.GetRequiredService<IAuthenticationCacheManager>();
                    return new AuthenticationServiceFactory(pathUtil, cacheUtil, authSettings);
                });
            }).ConfigureLogging((ctx, logBuilder) =>
            {
                logBuilder.SetMinimumLevel(LogLevel.Warning);
                logBuilder.ClearProviders();
                // Log everything to stderr. Investigate if this breaks scripts that check for stderr instead of the exit code.
                logBuilder.AddConsole(c => c.LogToStandardErrorThreshold = LogLevel.Trace);
                // Allow runtime selection of log level
                logBuilder.AddFilter("Microsoft.Graph.Cli", level => level >= (debugEnabled ? LogLevel.Debug : LogLevel.Warning));
            });

        static void ConfigureAppConfiguration(IConfigurationBuilder builder, string[] args)
        {
            builder.Sources.Clear();
            builder.AddJsonFile(Path.Combine(System.AppContext.BaseDirectory, "app-settings.json"), optional: true);
            var pathUtil = new PathUtility();
            var authCache = new AuthenticationCacheManager(pathUtil);
            var dataDir = pathUtil.GetApplicationDataDirectory();
            var userConfigPath = Path.Combine(dataDir, "settings.json");
            builder.AddJsonFile(userConfigPath, optional: true);
            builder.AddJsonFile(authCache.GetAuthenticationCacheFilePath(), optional: true, reloadOnChange: true);
            builder.AddEnvironmentVariables(prefix: "MGC_");
        }

        static AzureEventSourceListener CreateStdErrLogger(EventLevel level = EventLevel.Informational)
        {
            return new AzureEventSourceListener(delegate (EventWrittenEventArgs eventData, string text)
            {
                // By default, AzureEventSourceListener.CreateConsoleLogger logs to stdout. Use stderr instead.
                Console.Error.WriteLine("[{1}] {0}: {2}", eventData.EventSource.Name, eventData.Level, text);
            }, level);
        }
    }
}
