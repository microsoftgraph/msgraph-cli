namespace ApiSdk.Models.Microsoft.Graph {
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
