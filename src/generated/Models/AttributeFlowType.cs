using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AttributeFlowType {
        [EnumMember(Value = "Always")]
        Always,
        [EnumMember(Value = "ObjectAddOnly")]
        ObjectAddOnly,
        [EnumMember(Value = "MultiValueAddOnly")]
        MultiValueAddOnly,
        [EnumMember(Value = "ValueAddOnly")]
        ValueAddOnly,
        [EnumMember(Value = "AttributeAddOnly")]
        AttributeAddOnly,
    }
}
