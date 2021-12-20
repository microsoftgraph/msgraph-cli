using Azure.Core;
using Azure.Identity;
using Microsoft.Graph.Cli.IO;
using Microsoft.Graph.Cli.Utils;
using System.IO;
using System.Threading.Tasks;

namespace Microsoft.Graph.Cli.Authentication;

class DeviceCodeLoginService : LoginServiceBase {
    private DeviceCodeCredential credential;

    public DeviceCodeLoginService(DeviceCodeCredential credential, IPathUtility pathUtility) : base(pathUtility) {
        this.credential = credential;
    }

    protected override async Task<AuthenticationRecord> DoLoginAsync(string[] scopes) {
        return await credential.AuthenticateAsync(new TokenRequestContext(scopes));
    }
}