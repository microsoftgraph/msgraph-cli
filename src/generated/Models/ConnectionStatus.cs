namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public enum ConnectionStatus {
        Unknown,
        Attempted,
        Succeeded,
        Blocked,
        Failed,
        UnknownFutureValue,
    }
}
