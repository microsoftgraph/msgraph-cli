namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum ConnectionStatus {
        Unknown,
        Attempted,
        Succeeded,
        Blocked,
        Failed,
        UnknownFutureValue,
    }
}
