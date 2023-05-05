using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TrainingStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "assigned")]
        Assigned,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "overdue")]
        Overdue,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
