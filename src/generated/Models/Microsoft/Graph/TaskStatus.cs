namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the drive singleton.</summary>
    public enum TaskStatus {
        NotStarted,
        InProgress,
        Completed,
        WaitingOnOthers,
        Deferred,
    }
}
