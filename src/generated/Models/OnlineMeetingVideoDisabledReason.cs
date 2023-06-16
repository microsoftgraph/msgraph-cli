using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum OnlineMeetingVideoDisabledReason {
        [EnumMember(Value = "watermarkProtection")]
        WatermarkProtection,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
