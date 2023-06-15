using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum OnlineMeetingContentSharingDisabledReason {
        [EnumMember(Value = "watermarkProtection")]
        WatermarkProtection,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
