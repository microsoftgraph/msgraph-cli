using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.ExternalConnectors {
    public enum ConnectionState {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "ready")]
        Ready,
        [EnumMember(Value = "obsolete")]
        Obsolete,
        [EnumMember(Value = "limitExceeded")]
        LimitExceeded,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
