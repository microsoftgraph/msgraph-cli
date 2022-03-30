namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum RiskState {
        None,
        ConfirmedSafe,
        Remediated,
        Dismissed,
        AtRisk,
        ConfirmedCompromised,
        UnknownFutureValue,
    }
}
