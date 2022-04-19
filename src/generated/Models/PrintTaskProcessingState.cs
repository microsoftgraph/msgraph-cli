namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public enum PrintTaskProcessingState {
        Pending,
        Processing,
        Completed,
        Aborted,
        UnknownFutureValue,
    }
}
