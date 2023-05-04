using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AllowedTargetScope {
        [EnumMember(Value = "notSpecified")]
        NotSpecified,
        [EnumMember(Value = "specificDirectoryUsers")]
        SpecificDirectoryUsers,
        [EnumMember(Value = "specificConnectedOrganizationUsers")]
        SpecificConnectedOrganizationUsers,
        [EnumMember(Value = "specificDirectoryServicePrincipals")]
        SpecificDirectoryServicePrincipals,
        [EnumMember(Value = "allMemberUsers")]
        AllMemberUsers,
        [EnumMember(Value = "allDirectoryUsers")]
        AllDirectoryUsers,
        [EnumMember(Value = "allDirectoryServicePrincipals")]
        AllDirectoryServicePrincipals,
        [EnumMember(Value = "allConfiguredConnectedOrganizationUsers")]
        AllConfiguredConnectedOrganizationUsers,
        [EnumMember(Value = "allExternalUsers")]
        AllExternalUsers,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
