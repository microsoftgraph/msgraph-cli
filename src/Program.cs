using ApiSdk;
using Azure.Identity;
using Microsoft.Graph.Cli.Authentication;
using Microsoft.Graph.Cli.Commands.Authentication;
using Microsoft.Graph.Cli.Utils;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.CommandLine;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace Microsoft.Graph.Cli
{
    class Program {
        const string SdkVersionHeaderValueFormatString = "{0}-cli-{1}.{2}.{3}";

        static async Task<int> Main(string[] args) {
            var authServiceFactory = new AuthenticationServiceFactory();
            var authStrategy = AuthenticationStrategy.DeviceCode;

            var credential = await authServiceFactory.GetTokenCredentialAsync(authStrategy);
            var authProvider = new AzureIdentityAuthenticationProvider(credential);
            var httpClient = new HttpClient();
            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
            var sdkVersionHeaderValue = string.Format(
                SdkVersionHeaderValueFormatString,
                "graph",
                assemblyVersion.Major,
                assemblyVersion.Minor,
                assemblyVersion.Build);
            httpClient.DefaultRequestHeaders.Add("SdkVersion", sdkVersionHeaderValue);
            var core = new HttpClientRequestAdapter(authProvider, null, null, httpClient);
            var client = new GraphClient(core);

            var rootCommand = client.BuildCommand();
            rootCommand.Description = "Microsoft Graph CLI";

            var loginCommand = new LoginCommand(authServiceFactory);
            rootCommand.AddCommand(loginCommand.Build());

            var logoutCommand = new LogoutCommand(new LogoutService());
            rootCommand.AddCommand(logoutCommand.Build());
            return await rootCommand.InvokeAsync(args);
        }
    }
}
