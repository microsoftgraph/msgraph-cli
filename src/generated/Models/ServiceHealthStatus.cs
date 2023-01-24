namespace ApiSdk.Models {
    public enum ServiceHealthStatus {
        ServiceOperational,
        Investigating,
        RestoringService,
        VerifyingService,
        ServiceRestored,
        PostIncidentReviewPublished,
        ServiceDegradation,
        ServiceInterruption,
        ExtendedRecovery,
        FalsePositive,
        InvestigationSuspended,
        Resolved,
        MitigatedExternal,
        Mitigated,
        ResolvedExternal,
        Confirmed,
        Reported,
        UnknownFutureValue,
    }
}
