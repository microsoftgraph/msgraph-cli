using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ActivityDomain {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "unrestricted")]
        Unrestricted,
    }
}
