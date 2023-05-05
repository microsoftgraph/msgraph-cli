using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.TermStore {
    public enum TermGroupScope {
        [EnumMember(Value = "global")]
        Global,
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "siteCollection")]
        SiteCollection,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
