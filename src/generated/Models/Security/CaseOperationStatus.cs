namespace ApiSdk.Models.Security {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
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
