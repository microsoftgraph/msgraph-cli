namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityContainer singleton.</summary>
    public enum UserFlowType {
        SignUp,
        SignIn,
        SignUpOrSignIn,
        PasswordReset,
        ProfileUpdate,
        ResourceOwner,
        UnknownFutureValue,
    }
}
