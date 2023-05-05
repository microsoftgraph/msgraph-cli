using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TeamworkActivityTopicSource {
        [EnumMember(Value = "entityUrl")]
        EntityUrl,
        [EnumMember(Value = "text")]
        Text,
    }
}
