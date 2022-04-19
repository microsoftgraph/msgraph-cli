namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum ActionState {
        None,
        Pending,
        Canceled,
        Active,
        Done,
        Failed,
        NotSupported,
    }
}
