using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AccessPackageRequestType {
        [EnumMember(Value = "notSpecified")]
        NotSpecified,
        [EnumMember(Value = "userAdd")]
        UserAdd,
        [EnumMember(Value = "userUpdate")]
        UserUpdate,
        [EnumMember(Value = "userRemove")]
        UserRemove,
        [EnumMember(Value = "adminAdd")]
        AdminAdd,
        [EnumMember(Value = "adminUpdate")]
        AdminUpdate,
        [EnumMember(Value = "adminRemove")]
        AdminRemove,
        [EnumMember(Value = "systemAdd")]
        SystemAdd,
        [EnumMember(Value = "systemUpdate")]
        SystemUpdate,
        [EnumMember(Value = "systemRemove")]
        SystemRemove,
        [EnumMember(Value = "onBehalfAdd")]
        OnBehalfAdd,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
