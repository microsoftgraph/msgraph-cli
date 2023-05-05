using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ExpirationPatternType {
        [EnumMember(Value = "notSpecified")]
        NotSpecified,
        [EnumMember(Value = "noExpiration")]
        NoExpiration,
        [EnumMember(Value = "afterDateTime")]
        AfterDateTime,
        [EnumMember(Value = "afterDuration")]
        AfterDuration,
    }
}
