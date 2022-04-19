namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum ComplianceState {
        Unknown,
        Compliant,
        Noncompliant,
        Conflict,
        Error,
        InGracePeriod,
        ConfigManager,
    }
}
