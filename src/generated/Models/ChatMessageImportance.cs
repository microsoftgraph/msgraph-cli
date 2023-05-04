using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ChatMessageImportance {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "urgent")]
        Urgent,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
