using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TeamsAsyncOperationStatus {
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
