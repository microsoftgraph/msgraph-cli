using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum EventPropagationStatus {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "inProcessing")]
        InProcessing,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
