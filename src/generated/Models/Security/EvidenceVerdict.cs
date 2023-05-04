using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum EvidenceVerdict {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "suspicious")]
        Suspicious,
        [EnumMember(Value = "malicious")]
        Malicious,
        [EnumMember(Value = "noThreatsFound")]
        NoThreatsFound,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
