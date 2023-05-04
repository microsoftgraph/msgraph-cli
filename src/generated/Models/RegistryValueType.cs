using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum RegistryValueType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "dword")]
        Dword,
        [EnumMember(Value = "dwordLittleEndian")]
        DwordLittleEndian,
        [EnumMember(Value = "dwordBigEndian")]
        DwordBigEndian,
        [EnumMember(Value = "expandSz")]
        ExpandSz,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "multiSz")]
        MultiSz,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "qword")]
        Qword,
        [EnumMember(Value = "qwordlittleEndian")]
        QwordlittleEndian,
        [EnumMember(Value = "sz")]
        Sz,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
