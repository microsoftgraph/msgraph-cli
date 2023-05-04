using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ComplianceStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "notApplicable")]
        NotApplicable,
        [EnumMember(Value = "compliant")]
        Compliant,
        [EnumMember(Value = "remediated")]
        Remediated,
        [EnumMember(Value = "nonCompliant")]
        NonCompliant,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "conflict")]
        Conflict,
        [EnumMember(Value = "notAssigned")]
        NotAssigned,
    }
}
