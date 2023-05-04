using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ProvisioningStepType {
        [EnumMember(Value = "import")]
        Import,
        [EnumMember(Value = "scoping")]
        Scoping,
        [EnumMember(Value = "matching")]
        Matching,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "referenceResolution")]
        ReferenceResolution,
        [EnumMember(Value = "export")]
        Export,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
