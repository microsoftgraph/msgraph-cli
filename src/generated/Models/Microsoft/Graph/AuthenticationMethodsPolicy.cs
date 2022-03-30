using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the authenticationMethodsPolicy singleton.</summary>
    public class AuthenticationMethodsPolicy : Entity, IParsable {
        /// <summary>Represents the settings for each authentication method. Automatically expanded on GET /policies/authenticationMethodsPolicy.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AuthenticationMethodConfiguration> AuthenticationMethodConfigurations { get; set; }
        /// <summary>A description of the policy. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The name of the policy. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time of the last update to the policy. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The version of the policy in use. Read-only.</summary>
        public string PolicyVersion { get; set; }
        public int? ReconfirmationInDays { get; set; }
        /// <summary>Enforce registration at sign-in time. This property can be used to remind users to set up targeted authentication methods.</summary>
        public ApiSdk.Models.Microsoft.Graph.RegistrationEnforcement RegistrationEnforcement { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AuthenticationMethodsPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationMethodsPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"authenticationMethodConfigurations", (o,n) => { (o as AuthenticationMethodsPolicy).AuthenticationMethodConfigurations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AuthenticationMethodConfiguration>(ApiSdk.Models.Microsoft.Graph.AuthenticationMethodConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"description", (o,n) => { (o as AuthenticationMethodsPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AuthenticationMethodsPolicy).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as AuthenticationMethodsPolicy).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"policyVersion", (o,n) => { (o as AuthenticationMethodsPolicy).PolicyVersion = n.GetStringValue(); } },
                {"reconfirmationInDays", (o,n) => { (o as AuthenticationMethodsPolicy).ReconfirmationInDays = n.GetIntValue(); } },
                {"registrationEnforcement", (o,n) => { (o as AuthenticationMethodsPolicy).RegistrationEnforcement = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.RegistrationEnforcement>(ApiSdk.Models.Microsoft.Graph.RegistrationEnforcement.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AuthenticationMethodConfiguration>("authenticationMethodConfigurations", AuthenticationMethodConfigurations);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("policyVersion", PolicyVersion);
            writer.WriteIntValue("reconfirmationInDays", ReconfirmationInDays);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.RegistrationEnforcement>("registrationEnforcement", RegistrationEnforcement);
        }
    }
}
