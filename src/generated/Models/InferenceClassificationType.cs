using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum InferenceClassificationType {
        [EnumMember(Value = "focused")]
        Focused,
        [EnumMember(Value = "other")]
        Other,
    }
}
