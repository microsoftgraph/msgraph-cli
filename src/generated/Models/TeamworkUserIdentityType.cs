namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of chat entities.</summary>
    public enum TeamworkUserIdentityType {
        AadUser,
        OnPremiseAadUser,
        AnonymousGuest,
        FederatedUser,
        PersonalMicrosoftAccountUser,
        SkypeUser,
        PhoneUser,
        UnknownFutureValue,
    }
}
