using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum DataSourceHoldStatus {
        [EnumMember(Value = "notApplied")]
        NotApplied,
        [EnumMember(Value = "applied")]
        Applied,
        [EnumMember(Value = "applying")]
        Applying,
        [EnumMember(Value = "removing")]
        Removing,
        [EnumMember(Value = "partial")]
        Partial,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
