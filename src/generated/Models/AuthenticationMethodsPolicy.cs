using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AuthenticationMethodsPolicy : Entity, IParsable {
        /// <summary>Represents the settings for each authentication method. Automatically expanded on GET /policies/authenticationMethodsPolicy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodConfiguration>? AuthenticationMethodConfigurations { get; set; }
#nullable restore
#else
        public List<AuthenticationMethodConfiguration> AuthenticationMethodConfigurations { get; set; }
#endif
        /// <summary>A description of the policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The name of the policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The date and time of the last update to the policy. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The version of the policy in use. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyVersion { get; set; }
#nullable restore
#else
        public string PolicyVersion { get; set; }
#endif
        public int? ReconfirmationInDays { get; set; }
        /// <summary>Enforce registration at sign-in time. This property can be used to remind users to set up targeted authentication methods.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RegistrationEnforcement? RegistrationEnforcement { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RegistrationEnforcement RegistrationEnforcement { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new AuthenticationMethodsPolicy CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new AuthenticationMethodsPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationMethodsPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethodConfigurations", n => { AuthenticationMethodConfigurations = n.GetCollectionOfObjectValues<AuthenticationMethodConfiguration>(AuthenticationMethodConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"policyVersion", n => { PolicyVersion = n.GetStringValue(); } },
                {"reconfirmationInDays", n => { ReconfirmationInDays = n.GetIntValue(); } },
                {"registrationEnforcement", n => { RegistrationEnforcement = n.GetObjectValue<ApiSdk.Models.RegistrationEnforcement>(ApiSdk.Models.RegistrationEnforcement.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodConfiguration>("authenticationMethodConfigurations", AuthenticationMethodConfigurations);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("policyVersion", PolicyVersion);
            writer.WriteIntValue("reconfirmationInDays", ReconfirmationInDays);
            writer.WriteObjectValue<ApiSdk.Models.RegistrationEnforcement>("registrationEnforcement", RegistrationEnforcement);
        }
    }
}
