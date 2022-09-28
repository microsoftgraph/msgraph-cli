namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
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
