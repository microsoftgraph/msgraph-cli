using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum QueryType {
        [EnumMember(Value = "files")]
        Files,
        [EnumMember(Value = "messages")]
        Messages,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
