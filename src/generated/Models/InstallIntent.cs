namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum InstallIntent {
        Available,
        Required,
        Uninstall,
        AvailableWithoutEnrollment,
    }
}
