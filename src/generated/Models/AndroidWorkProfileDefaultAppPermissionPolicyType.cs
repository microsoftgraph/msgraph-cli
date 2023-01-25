namespace ApiSdk.Models {
    /// <summary>Android Work Profile default app permission policy type.</summary>
    public enum AndroidWorkProfileDefaultAppPermissionPolicyType {
        /// <summary>Device default value, no intent.</summary>
        DeviceDefault,
        /// <summary>Prompt.</summary>
        Prompt,
        /// <summary>Auto grant.</summary>
        AutoGrant,
        /// <summary>Auto deny.</summary>
        AutoDeny,
    }
}
