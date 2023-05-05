using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AuthenticationPhoneType {
        [EnumMember(Value = "mobile")]
        Mobile,
        [EnumMember(Value = "alternateMobile")]
        AlternateMobile,
        [EnumMember(Value = "office")]
        Office,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
