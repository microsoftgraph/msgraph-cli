namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum RequiredPasswordType {
        /// <summary>Device default value, no intent.</summary>
        DeviceDefault,
        /// <summary>Alphanumeric password required.</summary>
        Alphanumeric,
        /// <summary>Numeric password required.</summary>
        Numeric,
    }
}
