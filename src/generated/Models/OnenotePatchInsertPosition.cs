using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum OnenotePatchInsertPosition {
        [EnumMember(Value = "After")]
        After,
        [EnumMember(Value = "Before")]
        Before,
    }
}
