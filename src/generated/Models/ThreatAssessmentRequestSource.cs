using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ThreatAssessmentRequestSource {
        [EnumMember(Value = "undefined")]
        Undefined,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "administrator")]
        Administrator,
    }
}
