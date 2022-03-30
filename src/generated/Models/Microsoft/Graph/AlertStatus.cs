namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public enum AlertStatus {
        Unknown,
        NewAlert,
        InProgress,
        Resolved,
        Dismissed,
        UnknownFutureValue,
    }
}
