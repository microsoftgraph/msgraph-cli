namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the cloudCommunications singleton.</summary>
    public enum CallState {
        Incoming,
        Establishing,
        Established,
        Hold,
        Transferring,
        TransferAccepted,
        Redirecting,
        Terminating,
        Terminated,
        UnknownFutureValue,
    }
}
