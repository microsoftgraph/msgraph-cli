using Azure.Core;
using Azure.Identity;
using Microsoft.Graph.Cli.Utils;
using System.IO;
using System.Threading.Tasks;

namespace Microsoft.Graph.Cli.Authentication;

class DeviceCodeAuthenticationService : IAuthenticationService {
    private DeviceCodeCredential credential;

    public DeviceCodeAuthenticationService(DeviceCodeCredential credential) {
        this.credential = credential;
    }

    public async Task LoginAsync(string[] scopes) {
        var authRecord = await credential.AuthenticateAsync(new TokenRequestContext(scopes));
        // Serialize the AuthenticationRecord to disk so that it can be re-used across executions of this initialization code.
        using var authRecordStream = new FileStream(Constants.AuthRecordPath, FileMode.OpenOrCreate, FileAccess.Write);
        await authRecord.SerializeAsync(authRecordStream);
    }
}