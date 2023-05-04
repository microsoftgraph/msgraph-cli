using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum StagedFeatureName {
        [EnumMember(Value = "passthroughAuthentication")]
        PassthroughAuthentication,
        [EnumMember(Value = "seamlessSso")]
        SeamlessSso,
        [EnumMember(Value = "passwordHashSync")]
        PasswordHashSync,
        [EnumMember(Value = "emailAsAlternateId")]
        EmailAsAlternateId,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "certificateBasedAuthentication")]
        CertificateBasedAuthentication,
        [EnumMember(Value = "multiFactorAuthentication")]
        MultiFactorAuthentication,
    }
}
