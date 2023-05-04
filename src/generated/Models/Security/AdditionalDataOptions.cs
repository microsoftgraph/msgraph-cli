using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum AdditionalDataOptions {
        [EnumMember(Value = "allVersions")]
        AllVersions,
        [EnumMember(Value = "linkedFiles")]
        LinkedFiles,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
