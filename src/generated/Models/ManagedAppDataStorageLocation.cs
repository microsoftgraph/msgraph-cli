namespace ApiSdk.Models {
    /// <summary>Storage locations where managed apps can potentially store their data</summary>
    public enum ManagedAppDataStorageLocation {
        /// <summary>OneDrive for business</summary>
        OneDriveForBusiness,
        /// <summary>SharePoint</summary>
        SharePoint,
        /// <summary>Box</summary>
        Box,
        /// <summary>Local storage on the device</summary>
        LocalStorage,
    }
}
