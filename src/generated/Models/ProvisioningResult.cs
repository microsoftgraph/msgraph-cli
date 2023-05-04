using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ProvisioningResult {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "skipped")]
        Skipped,
        [EnumMember(Value = "warning")]
        Warning,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
