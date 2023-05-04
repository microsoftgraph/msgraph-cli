using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum SourceType {
        [EnumMember(Value = "mailbox")]
        Mailbox,
        [EnumMember(Value = "site")]
        Site,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
