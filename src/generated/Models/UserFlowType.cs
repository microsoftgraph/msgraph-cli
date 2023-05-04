using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum UserFlowType {
        [EnumMember(Value = "signUp")]
        SignUp,
        [EnumMember(Value = "signIn")]
        SignIn,
        [EnumMember(Value = "signUpOrSignIn")]
        SignUpOrSignIn,
        [EnumMember(Value = "passwordReset")]
        PasswordReset,
        [EnumMember(Value = "profileUpdate")]
        ProfileUpdate,
        [EnumMember(Value = "resourceOwner")]
        ResourceOwner,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
