using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum CallDirection {
        [EnumMember(Value = "incoming")]
        Incoming,
        [EnumMember(Value = "outgoing")]
        Outgoing,
    }
}
