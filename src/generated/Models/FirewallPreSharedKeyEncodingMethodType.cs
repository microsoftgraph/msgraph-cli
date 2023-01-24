namespace ApiSdk.Models {
    /// <summary>Possible values for firewallPreSharedKeyEncodingMethod</summary>
    public enum FirewallPreSharedKeyEncodingMethodType {
        /// <summary>No value configured by Intune, do not override the user-configured device default value</summary>
        DeviceDefault,
        /// <summary>Preshared key is not encoded. Instead, it is kept in its wide-character format</summary>
        None,
        /// <summary>Encode the preshared key using UTF-8</summary>
        UtF8,
    }
}
