using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AccessPackageCatalogState {
        [EnumMember(Value = "unpublished")]
        Unpublished,
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
