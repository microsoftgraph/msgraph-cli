using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ConditionalAccessPolicyState {
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "enabledForReportingButNotEnforced")]
        EnabledForReportingButNotEnforced,
    }
}
