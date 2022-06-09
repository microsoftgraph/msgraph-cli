using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Policies.FeatureRolloutPolicies.Item.AppliesTo.ValidateProperties {
    /// <summary>Provides operations to call the validateProperties method.</summary>
    public class ValidatePropertiesPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The entityType property</summary>
        public string EntityType { get; set; }
        /// <summary>The mailNickname property</summary>
        public string MailNickname { get; set; }
        /// <summary>The onBehalfOfUserId property</summary>
        public string OnBehalfOfUserId { get; set; }
        /// <summary>
        /// Instantiates a new validatePropertiesPostRequestBody and sets the default values.
        /// </summary>
        public ValidatePropertiesPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ValidatePropertiesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidatePropertiesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"entityType", n => { EntityType = n.GetStringValue(); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"onBehalfOfUserId", n => { OnBehalfOfUserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("entityType", EntityType);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteStringValue("onBehalfOfUserId", OnBehalfOfUserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
