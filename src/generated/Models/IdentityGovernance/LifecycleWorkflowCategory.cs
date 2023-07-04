using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public enum LifecycleWorkflowCategory {
        [EnumMember(Value = "joiner")]
        Joiner,
        [EnumMember(Value = "leaver")]
        Leaver,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "mover")]
        Mover,
    }
}
