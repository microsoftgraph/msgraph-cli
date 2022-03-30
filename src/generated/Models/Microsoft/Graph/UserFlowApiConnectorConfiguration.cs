using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserFlowApiConnectorConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ApiSdk.Models.Microsoft.Graph.IdentityApiConnector PostAttributeCollection { get; set; }
        public ApiSdk.Models.Microsoft.Graph.IdentityApiConnector PostFederationSignup { get; set; }
        /// <summary>
        /// Instantiates a new userFlowApiConnectorConfiguration and sets the default values.
        /// </summary>
        public UserFlowApiConnectorConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.UserFlowApiConnectorConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserFlowApiConnectorConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"postAttributeCollection", (o,n) => { (o as UserFlowApiConnectorConfiguration).PostAttributeCollection = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentityApiConnector>(ApiSdk.Models.Microsoft.Graph.IdentityApiConnector.CreateFromDiscriminatorValue); } },
                {"postFederationSignup", (o,n) => { (o as UserFlowApiConnectorConfiguration).PostFederationSignup = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentityApiConnector>(ApiSdk.Models.Microsoft.Graph.IdentityApiConnector.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentityApiConnector>("postAttributeCollection", PostAttributeCollection);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentityApiConnector>("postFederationSignup", PostFederationSignup);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
