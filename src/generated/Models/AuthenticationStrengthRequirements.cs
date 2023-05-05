using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AuthenticationStrengthRequirements {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "mfa")]
        Mfa,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
