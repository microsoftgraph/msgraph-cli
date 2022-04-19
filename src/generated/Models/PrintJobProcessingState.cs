namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public enum PrintJobProcessingState {
        Unknown,
        Pending,
        Processing,
        Paused,
        Stopped,
        Completed,
        Canceled,
        Aborted,
        UnknownFutureValue,
    }
}
