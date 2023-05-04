using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum NetworkConnectionType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "wired")]
        Wired,
        [EnumMember(Value = "wifi")]
        Wifi,
        [EnumMember(Value = "mobile")]
        Mobile,
        [EnumMember(Value = "tunnel")]
        Tunnel,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
