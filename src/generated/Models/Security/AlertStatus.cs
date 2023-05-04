using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum AlertStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "resolved")]
        Resolved,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
