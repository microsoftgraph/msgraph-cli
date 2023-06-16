using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AttributeMappingSourceType {
        [EnumMember(Value = "Attribute")]
        Attribute,
        [EnumMember(Value = "Constant")]
        Constant,
        [EnumMember(Value = "Function")]
        Function,
    }
}
