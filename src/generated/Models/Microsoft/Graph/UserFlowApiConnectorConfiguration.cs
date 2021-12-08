using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserFlowApiConnectorConfiguration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public IdentityApiConnector PostAttributeCollection { get; set; }
        public IdentityApiConnector PostFederationSignup { get; set; }
        /// <summary>
        /// Instantiates a new userFlowApiConnectorConfiguration and sets the default values.
        /// </summary>
        public UserFlowApiConnectorConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"postAttributeCollection", (o,n) => { (o as UserFlowApiConnectorConfiguration).PostAttributeCollection = n.GetObjectValue<IdentityApiConnector>(); } },
                {"postFederationSignup", (o,n) => { (o as UserFlowApiConnectorConfiguration).PostFederationSignup = n.GetObjectValue<IdentityApiConnector>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentityApiConnector>("postAttributeCollection", PostAttributeCollection);
            writer.WriteObjectValue<IdentityApiConnector>("postFederationSignup", PostFederationSignup);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
