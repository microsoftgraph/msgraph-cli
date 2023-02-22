using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Hosting;
using System.CommandLine.IO;
using System.CommandLine.Parsing;
using System.Diagnostics.Tracing;
using System.IO;
using System.Net.Http;
using System.Reflection;
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
using Microsoft.Graph.Cli.Core.Configuration.Extensions;
using Microsoft.Graph.Cli.Core.Http;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;

namespace Microsoft.Graph.Cli
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var customCommands = new List<Command>();
            customCommands.Add(new LoginCommand().Build());
            customCommands.Add(new LogoutCommand().Build());


            var builder = BuildCommandLine(customCommands)
                .UseDefaults()
                .UseHost(a =>
                {
                    // Pass all the args to avoid system.commandline swallowing them up
                    return CreateHostBuilder(args);
                }).UseRequestAdapter(ic =>
                {
                    var host = ic.GetHost();
                    var adapter = host.Services.GetRequiredService<IRequestAdapter>();
                    var client = host.Services.GetRequiredService<HttpClient>();
                    if (string.IsNullOrEmpty(adapter.BaseUrl))
                    {
                        adapter.BaseUrl = client.BaseAddress?.ToString();
                    }
                    return adapter;
                }).RegisterCommonServices();

            builder.AddMiddleware(async (ic, next) =>
            {
                var op = ic.GetHost().Services.GetService<IOptions<ExtraOptions>>()?.Value;
                // Show Azure Identity logs if the --debug option is set
                using AzureEventSourceListener? listener = op?.DebugEnabled == true ? AzureEventSourceListener.CreateConsoleLogger(EventLevel.LogAlways) : null;
                await next(ic);
            });
            builder.AddMiddleware(async (ic, next) =>
            {
                var host = ic.GetHost();

                ic.BindingContext.AddService(_ => host.Services.GetRequiredService<IAuthenticationCacheUtility>());
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

            var parser = builder.Build();

            return await parser.InvokeAsync(args);
        }

        static CommandLineBuilder BuildCommandLine(IEnumerable<Command> commands)
        {
            var rootCommand = new GraphClient().BuildRootCommand();
            rootCommand.Description = "Microsoft Graph CLI";
            // Support specifying additional arguments as configuration arguments
            // System.CommandLine might swallow valid config tokens sometimes.
            // e.g. if a command has an option --debug and we also want to use
            // --debug for configs.
            rootCommand.TreatUnmatchedTokensAsErrors = false;

            foreach (var command in commands)
            {
                rootCommand.AddCommand(command);
            }

            return new CommandLineBuilder(rootCommand);
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
                services.Configure<ExtraOptions>(op =>
                {
                    op.DebugEnabled = ctx.Configuration.GetValue<bool>("Debug");
                });
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
                    var loggingHandler = p.GetRequiredService<LoggingHandler>();
                    return GraphCliClientFactory.GetDefaultClient(options, lowestPriorityMiddlewares: new[] { loggingHandler });
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
                services.AddSingleton<IAuthenticationCacheUtility, AuthenticationCacheUtility>();
                services.AddSingleton<LogoutService>();
                services.AddSingleton<AuthenticationServiceFactory>(p =>
                {
                    var authSettings = p.GetRequiredService<IOptions<AuthenticationOptions>>()?.Value;
                    var pathUtil = p.GetRequiredService<IPathUtility>();
                    var cacheUtil = p.GetRequiredService<IAuthenticationCacheUtility>();
                    return new AuthenticationServiceFactory(pathUtil, cacheUtil, authSettings);
                });
            }).ConfigureLogging((ctx, logBuilder) =>
            {
                logBuilder.SetMinimumLevel(LogLevel.Warning);
                // If a config is unavailable, troubleshoot using (ctx.Configuration as IConfigurationRoot)?.GetDebugView();
                // At this point, the host isn't ready. Get the config option directly.
                var debugEnabled = ctx.Configuration.GetValue<bool>("Debug");
                if (debugEnabled == true)
                {
                    logBuilder.AddFilter("Microsoft.Graph.Cli", LogLevel.Debug);
                }
            });

        static void ConfigureAppConfiguration(IConfigurationBuilder builder, string[] args)
        {
            builder.Sources.Clear();
            builder.AddJsonFile(Path.Combine(System.AppContext.BaseDirectory, "app-settings.json"), optional: true);
            var pathUtil = new PathUtility();
            var authCache = new AuthenticationCacheUtility(pathUtil);
            var dataDir = pathUtil.GetApplicationDataDirectory();
            var userConfigPath = Path.Combine(dataDir, "settings.json");
            builder.AddJsonFile(userConfigPath, optional: true);
            builder.AddJsonFile(authCache.GetAuthenticationCacheFilePath(), optional: true, reloadOnChange: true);
            builder.AddEnvironmentVariables(prefix: "MGC_");
            builder.AddCommandLine(args.ExpandFlagsForConfiguration());
        }
    }
}
