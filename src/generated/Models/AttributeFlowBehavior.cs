using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AttributeFlowBehavior {
        [EnumMember(Value = "FlowWhenChanged")]
        FlowWhenChanged,
        [EnumMember(Value = "FlowAlways")]
        FlowAlways,
    }
}
