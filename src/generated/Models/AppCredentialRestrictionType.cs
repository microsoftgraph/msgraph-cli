using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AppCredentialRestrictionType {
        [EnumMember(Value = "passwordAddition")]
        PasswordAddition,
        [EnumMember(Value = "passwordLifetime")]
        PasswordLifetime,
        [EnumMember(Value = "symmetricKeyAddition")]
        SymmetricKeyAddition,
        [EnumMember(Value = "symmetricKeyLifetime")]
        SymmetricKeyLifetime,
        [EnumMember(Value = "customPasswordAddition")]
        CustomPasswordAddition,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
