using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Cli.Configuration;
using Microsoft.Graph.Cli.IO;
using Microsoft.Graph.Cli.Utils;

namespace Microsoft.Graph.Cli.Authentication;

class AuthenticationServiceFactory {
    public async Task<ILoginService> GetAuthenticationServiceAsync(AuthenticationStrategy strategy, string tenantId, string clientId) {
        switch (strategy) {
            case AuthenticationStrategy.DeviceCode:
                return await GetDeviceCodeLoginServiceAsync(tenantId, clientId);
            default:
                throw new InvalidOperationException($"The authentication strategy {strategy} is not supported");
        }

    }

    public async Task<TokenCredential> GetTokenCredentialAsync(AuthenticationStrategy strategy, string tenantId, string clientId) {
        switch (strategy) {
            case AuthenticationStrategy.DeviceCode:
                return await GetDeviceCodeCredentialAsync(tenantId, clientId);
            default:
                throw new InvalidOperationException($"The authentication strategy {strategy} is not supported");
        }
    }

    private async Task<DeviceCodeLoginService> GetDeviceCodeLoginServiceAsync(string tenantId, string clientId) {
        var credential = await GetDeviceCodeCredentialAsync(tenantId, clientId);
        return new(credential, new PathUtility());
    }

    private async Task<DeviceCodeCredential> GetDeviceCodeCredentialAsync(string tenantId, string clientId) {
        DeviceCodeCredentialOptions credOptions = new()
        {
            ClientId = clientId,
            TenantId = tenantId,
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
