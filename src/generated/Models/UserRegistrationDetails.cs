using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class UserRegistrationDetails : Entity, IParsable {
        /// <summary>The isAdmin property</summary>
        public bool? IsAdmin { get; set; }
        /// <summary>The isMfaCapable property</summary>
        public bool? IsMfaCapable { get; set; }
        /// <summary>The isMfaRegistered property</summary>
        public bool? IsMfaRegistered { get; set; }
        /// <summary>The isPasswordlessCapable property</summary>
        public bool? IsPasswordlessCapable { get; set; }
        /// <summary>The isSsprCapable property</summary>
        public bool? IsSsprCapable { get; set; }
        /// <summary>The isSsprEnabled property</summary>
        public bool? IsSsprEnabled { get; set; }
        /// <summary>The isSsprRegistered property</summary>
        public bool? IsSsprRegistered { get; set; }
        /// <summary>The isSystemPreferredAuthenticationMethodEnabled property</summary>
        public bool? IsSystemPreferredAuthenticationMethodEnabled { get; set; }
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The methodsRegistered property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MethodsRegistered { get; set; }
#nullable restore
#else
        public List<string> MethodsRegistered { get; set; }
#endif
        /// <summary>The systemPreferredAuthenticationMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemPreferredAuthenticationMethods { get; set; }
#nullable restore
#else
        public List<string> SystemPreferredAuthenticationMethods { get; set; }
#endif
        /// <summary>The userDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName { get; set; }
#nullable restore
#else
        public string UserDisplayName { get; set; }
#endif
        /// <summary>The userPreferredMethodForSecondaryAuthentication property</summary>
        public UserDefaultAuthenticationMethod? UserPreferredMethodForSecondaryAuthentication { get; set; }
        /// <summary>The userPrincipalName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>The userType property</summary>
        public SignInUserType? UserType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserRegistrationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isAdmin", n => { IsAdmin = n.GetBoolValue(); } },
                {"isMfaCapable", n => { IsMfaCapable = n.GetBoolValue(); } },
                {"isMfaRegistered", n => { IsMfaRegistered = n.GetBoolValue(); } },
                {"isPasswordlessCapable", n => { IsPasswordlessCapable = n.GetBoolValue(); } },
                {"isSsprCapable", n => { IsSsprCapable = n.GetBoolValue(); } },
                {"isSsprEnabled", n => { IsSsprEnabled = n.GetBoolValue(); } },
                {"isSsprRegistered", n => { IsSsprRegistered = n.GetBoolValue(); } },
                {"isSystemPreferredAuthenticationMethodEnabled", n => { IsSystemPreferredAuthenticationMethodEnabled = n.GetBoolValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"methodsRegistered", n => { MethodsRegistered = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"systemPreferredAuthenticationMethods", n => { SystemPreferredAuthenticationMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userPreferredMethodForSecondaryAuthentication", n => { UserPreferredMethodForSecondaryAuthentication = n.GetEnumValue<UserDefaultAuthenticationMethod>(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<SignInUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isAdmin", IsAdmin);
            writer.WriteBoolValue("isMfaCapable", IsMfaCapable);
            writer.WriteBoolValue("isMfaRegistered", IsMfaRegistered);
            writer.WriteBoolValue("isPasswordlessCapable", IsPasswordlessCapable);
            writer.WriteBoolValue("isSsprCapable", IsSsprCapable);
            writer.WriteBoolValue("isSsprEnabled", IsSsprEnabled);
            writer.WriteBoolValue("isSsprRegistered", IsSsprRegistered);
            writer.WriteBoolValue("isSystemPreferredAuthenticationMethodEnabled", IsSystemPreferredAuthenticationMethodEnabled);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("methodsRegistered", MethodsRegistered);
            writer.WriteCollectionOfPrimitiveValues<string>("systemPreferredAuthenticationMethods", SystemPreferredAuthenticationMethods);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteEnumValue<UserDefaultAuthenticationMethod>("userPreferredMethodForSecondaryAuthentication", UserPreferredMethodForSecondaryAuthentication);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<SignInUserType>("userType", UserType);
        }
    }
}
