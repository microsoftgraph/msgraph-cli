namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public enum AccessPackageRequestType {
        NotSpecified,
        UserAdd,
        UserUpdate,
        UserRemove,
        AdminAdd,
        AdminUpdate,
        AdminRemove,
        SystemAdd,
        SystemUpdate,
        SystemRemove,
        OnBehalfAdd,
        UnknownFutureValue,
    }
}
