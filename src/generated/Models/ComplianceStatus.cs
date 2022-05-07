namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum ComplianceStatus {
        Unknown,
        NotApplicable,
        Compliant,
        Remediated,
        NonCompliant,
        Error,
        Conflict,
        NotAssigned,
    }
}
