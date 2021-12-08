using ApiSdk;
using Azure.Identity;
using Microsoft.Graph.Cli.Authentication;
using Microsoft.Graph.Cli.Commands.Authentication;
using Microsoft.Graph.Cli.Utils;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.CommandLine;
using System.Threading.Tasks;

namespace Microsoft.Graph.Cli
{
    class Program {
        static async Task<int> Main(string[] args) {
            var authServiceFactory = new AuthenticationServiceFactory();
            var authStrategy = AuthenticationStrategy.DeviceCode;
            var persistToken = true;

            var credential = await authServiceFactory.GetTokenCredentialAsync(authStrategy, persistToken);
            var authProvider = new AzureIdentityAuthenticationProvider(credential);
            var core = new HttpClientRequestAdapter(authProvider);
            var client = new GraphClient(core);

            var rootCommand = client.BuildCommand();
            rootCommand.Description = "Microsoft Graph CLI";

            var authenticationService = await authServiceFactory.GetAuthenticationServiceAsync(authStrategy, persistToken);
            var loginCommand = new LoginCommand(authenticationService);
            rootCommand.AddCommand(loginCommand.Build());
            return await rootCommand.InvokeAsync(args);
        }
    }
}
