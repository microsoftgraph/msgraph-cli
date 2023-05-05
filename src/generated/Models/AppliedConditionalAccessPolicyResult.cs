using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AppliedConditionalAccessPolicyResult {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "notApplied")]
        NotApplied,
        [EnumMember(Value = "notEnabled")]
        NotEnabled,
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
