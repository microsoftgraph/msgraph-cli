namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public enum AllowedTargetScope {
        NotSpecified,
        SpecificDirectoryUsers,
        SpecificConnectedOrganizationUsers,
        SpecificDirectoryServicePrincipals,
        AllMemberUsers,
        AllDirectoryUsers,
        AllDirectoryServicePrincipals,
        AllConfiguredConnectedOrganizationUsers,
        AllExternalUsers,
        UnknownFutureValue,
    }
}
