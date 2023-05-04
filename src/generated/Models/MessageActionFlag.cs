using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum MessageActionFlag {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "call")]
        Call,
        [EnumMember(Value = "doNotForward")]
        DoNotForward,
        [EnumMember(Value = "followUp")]
        FollowUp,
        [EnumMember(Value = "fyi")]
        Fyi,
        [EnumMember(Value = "forward")]
        Forward,
        [EnumMember(Value = "noResponseNecessary")]
        NoResponseNecessary,
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "reply")]
        Reply,
        [EnumMember(Value = "replyToAll")]
        ReplyToAll,
        [EnumMember(Value = "review")]
        Review,
    }
}
