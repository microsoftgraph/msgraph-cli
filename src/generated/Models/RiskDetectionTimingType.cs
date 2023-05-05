using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum RiskDetectionTimingType {
        [EnumMember(Value = "notDefined")]
        NotDefined,
        [EnumMember(Value = "realtime")]
        Realtime,
        [EnumMember(Value = "nearRealtime")]
        NearRealtime,
        [EnumMember(Value = "offline")]
        Offline,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
