using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum IdentityUserFlowAttributeDataType {
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "int64")]
        Int64,
        [EnumMember(Value = "stringCollection")]
        StringCollection,
        [EnumMember(Value = "dateTime")]
        DateTime,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
