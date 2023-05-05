using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ServiceHealthClassificationType {
        [EnumMember(Value = "advisory")]
        Advisory,
        [EnumMember(Value = "incident")]
        Incident,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
