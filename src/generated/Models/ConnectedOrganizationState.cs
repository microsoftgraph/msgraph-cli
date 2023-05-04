using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ConnectedOrganizationState {
        [EnumMember(Value = "configured")]
        Configured,
        [EnumMember(Value = "proposed")]
        Proposed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
