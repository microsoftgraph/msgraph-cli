namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum RiskEventType {
        UnlikelyTravel,
        AnonymizedIPAddress,
        MaliciousIPAddress,
        UnfamiliarFeatures,
        MalwareInfectedIPAddress,
        SuspiciousIPAddress,
        LeakedCredentials,
        InvestigationsThreatIntelligence,
        Generic,
        AdminConfirmedUserCompromised,
        McasImpossibleTravel,
        McasSuspiciousInboxManipulationRules,
        InvestigationsThreatIntelligenceSigninLinked,
        MaliciousIPAddressValidCredentialsBlockedIP,
        UnknownFutureValue,
    }
}
