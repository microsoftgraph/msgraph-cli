using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public enum LifecycleWorkflowProcessingStatus {
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "completedWithErrors")]
        CompletedWithErrors,
        [EnumMember(Value = "canceled")]
        Canceled,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
