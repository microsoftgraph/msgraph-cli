namespace ApiSdk.Models {
    /// <summary>Contains all supported Powershell Script output detection type.</summary>
    public enum Win32LobAppPowerShellScriptRuleOperationType {
        /// <summary>Not configured.</summary>
        NotConfigured,
        /// <summary>Output data type is string.</summary>
        String,
        /// <summary>Output data type is date time.</summary>
        DateTime,
        /// <summary>Output data type is integer.</summary>
        Integer,
        /// <summary>Output data type is float.</summary>
        Float,
        /// <summary>Output data type is version.</summary>
        Version,
        /// <summary>Output data type is boolean.</summary>
        Boolean,
    }
}
