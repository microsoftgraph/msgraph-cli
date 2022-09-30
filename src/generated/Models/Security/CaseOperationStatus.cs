namespace ApiSdk.Models.Security {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public enum CaseOperationStatus {
        NotStarted,
        SubmissionFailed,
        Running,
        Succeeded,
        PartiallySucceeded,
        Failed,
        UnknownFutureValue,
    }
}
