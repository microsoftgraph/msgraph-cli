namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum RiskDetail {
        None,
        AdminGeneratedTemporaryPassword,
        UserPerformedSecuredPasswordChange,
        UserPerformedSecuredPasswordReset,
        AdminConfirmedSigninSafe,
        AiConfirmedSigninSafe,
        UserPassedMFADrivenByRiskBasedPolicy,
        AdminDismissedAllRiskForUser,
        AdminConfirmedSigninCompromised,
        Hidden,
        AdminConfirmedUserCompromised,
        UnknownFutureValue,
    }
}
