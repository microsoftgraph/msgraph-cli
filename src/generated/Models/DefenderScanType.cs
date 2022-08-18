namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum DefenderScanType {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>System scan disabled.</summary>
        Disabled,
        /// <summary>Quick system scan.</summary>
        Quick,
        /// <summary>Full system scan.</summary>
        Full,
    }
}
