namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum AlertStatus {
        Unknown,
        NewAlert,
        InProgress,
        Resolved,
        Dismissed,
        UnknownFutureValue,
    }
}
