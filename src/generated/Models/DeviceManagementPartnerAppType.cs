namespace ApiSdk.Models {
    /// <summary>Partner App Type.</summary>
    public enum DeviceManagementPartnerAppType {
        /// <summary>Partner App type is unknown.</summary>
        Unknown,
        /// <summary>Partner App is Single tenant in AAD.</summary>
        SingleTenantApp,
        /// <summary>Partner App is Multi tenant in AAD.</summary>
        MultiTenantApp,
    }
}
