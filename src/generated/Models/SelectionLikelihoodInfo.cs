using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SelectionLikelihoodInfo {
        [EnumMember(Value = "notSpecified")]
        NotSpecified,
        [EnumMember(Value = "high")]
        High,
    }
}
