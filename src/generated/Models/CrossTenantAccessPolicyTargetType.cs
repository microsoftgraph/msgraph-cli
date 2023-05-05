using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum CrossTenantAccessPolicyTargetType {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
