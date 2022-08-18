namespace ApiSdk.Models.Security {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum DataSourceHoldStatus {
        NotApplied,
        Applied,
        Applying,
        Removing,
        Partial,
        UnknownFutureValue,
    }
}
