namespace ApiSdk.Models {
    /// <summary>Possible values of required passwords.</summary>
    public enum RequiredPasswordType {
        /// <summary>Device default value, no intent.</summary>
        DeviceDefault,
        /// <summary>Alphanumeric password required.</summary>
        Alphanumeric,
        /// <summary>Numeric password required.</summary>
        Numeric,
    }
}
