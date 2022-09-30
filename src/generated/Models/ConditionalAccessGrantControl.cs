namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public enum ConditionalAccessGrantControl {
        Block,
        Mfa,
        CompliantDevice,
        DomainJoinedDevice,
        ApprovedApplication,
        CompliantApplication,
        PasswordChange,
        UnknownFutureValue,
    }
}
