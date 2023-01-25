namespace ApiSdk.Models {
    /// <summary>Contains all supported registry data detection type.</summary>
    public enum Win32LobAppRegistryRuleOperationType {
        /// <summary>Not configured.</summary>
        NotConfigured,
        /// <summary>The specified registry key or value exists.</summary>
        Exists,
        /// <summary>The specified registry key or value does not exist.</summary>
        DoesNotExist,
        /// <summary>String value type.</summary>
        String,
        /// <summary>Integer value type.</summary>
        Integer,
        /// <summary>Version value type.</summary>
        Version,
    }
}
