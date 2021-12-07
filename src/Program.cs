using ApiSdk;
using Azure.Identity;
using Microsoft.Graph.Cli.Utils;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.CommandLine;
using System.Threading.Tasks;

namespace Microsoft.Graph.Cli
{
    class Program {
        static async Task<int> Main(string[] args) {
            DeviceCodeCredentialOptions credOptions = new()
            {
                ClientId = Constants.ClientId,
                TenantId = Constants.TenantId
            };

            var credential = new DeviceCodeCredential(credOptions);
            var authProvider = new AzureIdentityAuthenticationProvider(credential);
            var core = new HttpClientRequestAdapter(authProvider);
            var client = new GraphClient(core);

            var rootCommand = client.BuildCommand();
            rootCommand.Description = "Microsoft Graph CLI";
            return await rootCommand.InvokeAsync(args);
        }
    }
}
