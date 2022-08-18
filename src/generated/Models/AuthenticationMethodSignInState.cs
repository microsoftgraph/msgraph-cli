namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of authenticationMethodConfiguration entities.</summary>
    public enum AuthenticationMethodSignInState {
        NotSupported,
        NotAllowedByPolicy,
        NotEnabled,
        PhoneNumberNotUnique,
        Ready,
        NotConfigured,
        UnknownFutureValue,
    }
}
