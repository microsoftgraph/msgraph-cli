using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AuthenticationMethodSignInState {
        [EnumMember(Value = "notSupported")]
        NotSupported,
        [EnumMember(Value = "notAllowedByPolicy")]
        NotAllowedByPolicy,
        [EnumMember(Value = "notEnabled")]
        NotEnabled,
        [EnumMember(Value = "phoneNumberNotUnique")]
        PhoneNumberNotUnique,
        [EnumMember(Value = "ready")]
        Ready,
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
