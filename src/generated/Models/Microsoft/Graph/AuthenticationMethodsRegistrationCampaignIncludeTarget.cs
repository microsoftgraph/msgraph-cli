using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AuthenticationMethodsRegistrationCampaignIncludeTarget : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The object identifier of an Azure Active Directory user or group.</summary>
        public string Id { get; set; }
        /// <summary>The authentication method that the user is prompted to register. The value must be microsoftAuthenticator.</summary>
        public string TargetedAuthenticationMethod { get; set; }
        /// <summary>The type of the authentication method target. Possible values are: user, group, unknownFutureValue.</summary>
        public AuthenticationMethodTargetType? TargetType { get; set; }
        /// <summary>
        /// Instantiates a new authenticationMethodsRegistrationCampaignIncludeTarget and sets the default values.
        /// </summary>
        public AuthenticationMethodsRegistrationCampaignIncludeTarget() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AuthenticationMethodsRegistrationCampaignIncludeTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationMethodsRegistrationCampaignIncludeTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"id", (o,n) => { (o as AuthenticationMethodsRegistrationCampaignIncludeTarget).Id = n.GetStringValue(); } },
                {"targetedAuthenticationMethod", (o,n) => { (o as AuthenticationMethodsRegistrationCampaignIncludeTarget).TargetedAuthenticationMethod = n.GetStringValue(); } },
                {"targetType", (o,n) => { (o as AuthenticationMethodsRegistrationCampaignIncludeTarget).TargetType = n.GetEnumValue<AuthenticationMethodTargetType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("targetedAuthenticationMethod", TargetedAuthenticationMethod);
            writer.WriteEnumValue<AuthenticationMethodTargetType>("targetType", TargetType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
