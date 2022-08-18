namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of agreementAcceptance entities.</summary>
    public enum AppLockerApplicationControlType {
        /// <summary>Device default value, no Application Control type selected.</summary>
        NotConfigured,
        /// <summary>Enforce Windows component and store apps.</summary>
        EnforceComponentsAndStoreApps,
        /// <summary>Audit Windows component and store apps.</summary>
        AuditComponentsAndStoreApps,
        /// <summary>Enforce Windows components, store apps and smart locker.</summary>
        EnforceComponentsStoreAppsAndSmartlocker,
        /// <summary>Audit Windows components, store apps and smart locker​.</summary>
        AuditComponentsStoreAppsAndSmartlocker,
    }
}
