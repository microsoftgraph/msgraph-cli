using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum Status {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "updated")]
        Updated,
        [EnumMember(Value = "deleted")]
        Deleted,
        [EnumMember(Value = "ignored")]
        Ignored,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
