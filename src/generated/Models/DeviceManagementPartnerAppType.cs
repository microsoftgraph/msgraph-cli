namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum DeviceManagementPartnerAppType {
        /// <summary>Partner App type is unknown.</summary>
        Unknown,
        /// <summary>Partner App is Single tenant in AAD.</summary>
        SingleTenantApp,
        /// <summary>Partner App is Multi tenant in AAD.</summary>
        MultiTenantApp,
    }
}
