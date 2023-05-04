using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AnswerInputType {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "radioButton")]
        RadioButton,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
