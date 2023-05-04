using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum EventStatusType {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "notAvaliable")]
        NotAvaliable,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
