namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the drive singleton.</summary>
    public enum LongRunningOperationStatus {
        NotStarted,
        Running,
        Succeeded,
        Failed,
        UnknownFutureValue,
    }
}
