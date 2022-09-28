namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
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
