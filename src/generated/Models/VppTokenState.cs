namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum VppTokenState {
        Unknown,
        Valid,
        Expired,
        Invalid,
        AssignedToExternalMDM,
    }
}
