namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum EnrollmentState {
        Unknown,
        Enrolled,
        PendingReset,
        Failed,
        NotContacted,
    }
}
