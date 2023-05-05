using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum CalendarSharingActionImportance {
        [EnumMember(Value = "primary")]
        Primary,
        [EnumMember(Value = "secondary")]
        Secondary,
    }
}
