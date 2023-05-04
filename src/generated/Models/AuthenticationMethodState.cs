using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AuthenticationMethodState {
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
    }
}
