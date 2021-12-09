using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Microsoft.Graph.Cli.Utils;

namespace Microsoft.Graph.Cli.Authentication;

class AuthenticationServiceFactory {
    public async Task<ILoginService> GetAuthenticationServiceAsync(AuthenticationStrategy strategy) {
        switch (strategy) {
            case AuthenticationStrategy.DeviceCode:
                return await GetDeviceCodeLoginServiceAsync();
            default:
                throw new InvalidOperationException($"The authentication strategy {strategy} is not supported");
        }

    }

    public async Task<TokenCredential> GetTokenCredentialAsync(AuthenticationStrategy strategy) {
        switch (strategy) {
            case AuthenticationStrategy.DeviceCode:
                return await GetDeviceCodeCredentialAsync();
            default:
                throw new InvalidOperationException($"The authentication strategy {strategy} is not supported");
        }
    }

    private async Task<DeviceCodeLoginService> GetDeviceCodeLoginServiceAsync() {
        var credential = await GetDeviceCodeCredentialAsync();
        return new(credential);
    }

    private async Task<DeviceCodeCredential> GetDeviceCodeCredentialAsync() {
        DeviceCodeCredentialOptions credOptions = new()
        {
            ClientId = Constants.ClientId,
            TenantId = Constants.TenantId
        };

        TokenCachePersistenceOptions tokenCacheOptions = new() { Name = Constants.TokenCacheName };
        credOptions.TokenCachePersistenceOptions = tokenCacheOptions;
        var recordPath = Constants.AuthRecordPath;

        if (File.Exists(recordPath))
        {
            using var authRecordStream = new FileStream(recordPath, FileMode.Open, FileAccess.Read);
            var authRecord = await AuthenticationRecord.DeserializeAsync(authRecordStream);
            credOptions.AuthenticationRecord = authRecord;
        }

        return new DeviceCodeCredential(credOptions);
    }
}
