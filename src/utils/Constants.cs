using Microsoft.Graph.Cli.Authentication;

namespace Microsoft.Graph.Cli.Utils
{
    class Constants
    {
        public const string ApplicationDataDirectory = ".mgc";

        public const string AuthRecordPath = "authRecord";

        public const string TokenCacheName = "MicrosoftGraph";

        public const string AuthenticationSection = "Authentication";

        public const AuthenticationStrategy defaultAuthStrategy = AuthenticationStrategy.DeviceCode;
    }
}