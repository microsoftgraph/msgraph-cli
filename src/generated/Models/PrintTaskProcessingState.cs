using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrintTaskProcessingState {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "aborted")]
        Aborted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
