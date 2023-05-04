using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum DataPolicyOperationStatus {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "complete")]
        Complete,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
