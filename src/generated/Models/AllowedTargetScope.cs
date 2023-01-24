namespace ApiSdk.Models {
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
