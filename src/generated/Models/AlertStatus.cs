using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AlertStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "newAlert")]
        NewAlert,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "resolved")]
        Resolved,
        [EnumMember(Value = "dismissed")]
        Dismissed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
