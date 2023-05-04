using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum LogonType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "interactive")]
        Interactive,
        [EnumMember(Value = "remoteInteractive")]
        RemoteInteractive,
        [EnumMember(Value = "network")]
        Network,
        [EnumMember(Value = "batch")]
        Batch,
        [EnumMember(Value = "service")]
        Service,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
