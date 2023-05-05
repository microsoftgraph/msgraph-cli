using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ChatMessagePolicyViolationVerdictDetailsTypes {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "allowFalsePositiveOverride")]
        AllowFalsePositiveOverride,
        [EnumMember(Value = "allowOverrideWithoutJustification")]
        AllowOverrideWithoutJustification,
        [EnumMember(Value = "allowOverrideWithJustification")]
        AllowOverrideWithJustification,
    }
}
