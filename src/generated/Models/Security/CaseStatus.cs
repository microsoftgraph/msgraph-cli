namespace ApiSdk.Models.Security {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum CaseStatus {
        Unknown,
        Active,
        PendingDelete,
        Closing,
        Closed,
        ClosedWithError,
        UnknownFutureValue,
    }
}
