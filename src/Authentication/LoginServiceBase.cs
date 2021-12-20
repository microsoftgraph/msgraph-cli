using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.Graph.Cli.IO;
using Microsoft.Graph.Cli.Utils;

namespace Microsoft.Graph.Cli.Authentication;

abstract class LoginServiceBase : ILoginService {
    private readonly IPathUtility pathUtility;

    protected LoginServiceBase(IPathUtility pathUtility) {
        this.pathUtility = pathUtility;
    }

    public async Task LoginAsync(string[] scopes) {
        var record = await this.DoLoginAsync(scopes);
        await this.SaveSessionAsync(record);
    }

    protected abstract Task<AuthenticationRecord> DoLoginAsync(string[] scopes);

    public async Task SaveSessionAsync(AuthenticationRecord record) {
        var homeDir = pathUtility.GetUserHomeDirectory();
        var recordPath = Path.Combine(homeDir, Constants.ApplicationDataDirectory, Constants.AuthRecordPath);
        using var authRecordStream = new FileStream(recordPath, FileMode.OpenOrCreate, FileAccess.Write);
        await record.SerializeAsync(authRecordStream);
    }
}