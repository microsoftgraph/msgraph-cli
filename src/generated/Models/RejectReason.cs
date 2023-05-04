using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum RejectReason {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "forbidden")]
        Forbidden,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
