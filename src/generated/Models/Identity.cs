using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Identity : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won&apos;t show up as having changed when using delta.</summary>
        public string DisplayName { get; set; }
        /// <summary>Unique identifier for the identity.</summary>
        public string Id { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new identity and sets the default values.
        /// </summary>
        public Identity() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.identity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Identity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.initiator" => new Initiator(),
                "#microsoft.graph.provisionedIdentity" => new ProvisionedIdentity(),
                "#microsoft.graph.provisioningServicePrincipal" => new ProvisioningServicePrincipal(),
                "#microsoft.graph.provisioningSystem" => new ProvisioningSystem(),
                "#microsoft.graph.servicePrincipalIdentity" => new ServicePrincipalIdentity(),
                "#microsoft.graph.sharePointIdentity" => new SharePointIdentity(),
                "#microsoft.graph.teamworkApplicationIdentity" => new TeamworkApplicationIdentity(),
                "#microsoft.graph.teamworkConversationIdentity" => new TeamworkConversationIdentity(),
                "#microsoft.graph.teamworkTagIdentity" => new TeamworkTagIdentity(),
                "#microsoft.graph.teamworkUserIdentity" => new TeamworkUserIdentity(),
                "#microsoft.graph.userIdentity" => new UserIdentity(),
                _ => new Identity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
