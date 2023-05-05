using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AccessPackageExternalUserLifecycleAction {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "blockSignIn")]
        BlockSignIn,
        [EnumMember(Value = "blockSignInAndDelete")]
        BlockSignInAndDelete,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
