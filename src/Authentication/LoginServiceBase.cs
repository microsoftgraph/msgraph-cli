using System.IO;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.Graph.Cli.Utils;

namespace Microsoft.Graph.Cli.Authentication;

abstract class LoginServiceBase : ILoginService {
    public async Task LoginAsync(string[] scopes) {
        var record = await this.DoLoginAsync(scopes);
        await this.SaveSessionAsync(record);
    }

    public void Logout() {
        if (File.Exists(Constants.AuthRecordPath)) {
            File.Delete(Constants.AuthRecordPath);
        }
    }

    protected abstract Task<AuthenticationRecord> DoLoginAsync(string[] scopes);

    public async Task SaveSessionAsync(AuthenticationRecord record) {
        using var authRecordStream = new FileStream(Constants.AuthRecordPath, FileMode.OpenOrCreate, FileAccess.Write);
        await record.SerializeAsync(authRecordStream);
    }
}