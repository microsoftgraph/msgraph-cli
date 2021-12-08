using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Microsoft.Graph.Cli.Utils;

namespace Microsoft.Graph.Cli.Authentication;

class AuthenticationServiceFactory {
    public async Task<IAuthenticationService> GetAuthenticationServiceAsync(AuthenticationStrategy strategy, bool persistToken = false) {
        switch (strategy) {
            case AuthenticationStrategy.DeviceCode:
                return await GetDeviceCodeAuthenticationServiceAsync(persistToken);
            default:
                throw new InvalidOperationException($"The authentication strategy {strategy} is not supported");
        }

    }

    public async Task<TokenCredential> GetTokenCredentialAsync(AuthenticationStrategy strategy, bool persistToken = false) {
        switch (strategy) {
            case AuthenticationStrategy.DeviceCode:
                return await GetDeviceCodeCredentialAsync(persistToken);
            default:
                throw new InvalidOperationException($"The authentication strategy {strategy} is not supported");
        }
    }

    private async Task<DeviceCodeAuthenticationService> GetDeviceCodeAuthenticationServiceAsync(bool persistToken = false) {
        var credential = await GetDeviceCodeCredentialAsync(persistToken);
        return new(credential);
    }

    private async Task<DeviceCodeCredential> GetDeviceCodeCredentialAsync(bool persistToken) {
        DeviceCodeCredentialOptions credOptions = new()
        {
            ClientId = Constants.ClientId,
            TenantId = Constants.TenantId
        };

        if (persistToken) {
            TokenCachePersistenceOptions tokenCacheOptions = new() { Name = Constants.TokenCacheName };
            credOptions.TokenCachePersistenceOptions = tokenCacheOptions;
            var recordPath = Constants.AuthRecordPath;

            if (File.Exists(recordPath))
            {
                using var authRecordStream = new FileStream(recordPath, FileMode.Open, FileAccess.Read);
                var authRecord = await AuthenticationRecord.DeserializeAsync(authRecordStream);
                credOptions.AuthenticationRecord = authRecord;
            }
        }

        return new DeviceCodeCredential(credOptions);
    }
}

enum AuthenticationStrategy {
    DeviceCode
}