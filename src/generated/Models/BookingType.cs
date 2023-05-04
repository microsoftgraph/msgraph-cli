using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum BookingType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "reserved")]
        Reserved,
    }
}
