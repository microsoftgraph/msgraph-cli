using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkforceIntegrationEncryption : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Possible values are: sharedSecret, unknownFutureValue.</summary>
        public WorkforceIntegrationEncryptionProtocol? Protocol { get; set; }
        /// <summary>Encryption shared secret.</summary>
        public string Secret { get; set; }
        /// <summary>
        /// Instantiates a new workforceIntegrationEncryption and sets the default values.
        /// </summary>
        public WorkforceIntegrationEncryption() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"protocol", (o,n) => { (o as WorkforceIntegrationEncryption).Protocol = n.GetEnumValue<WorkforceIntegrationEncryptionProtocol>(); } },
                {"secret", (o,n) => { (o as WorkforceIntegrationEncryption).Secret = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WorkforceIntegrationEncryptionProtocol>("protocol", Protocol);
            writer.WriteStringValue("secret", Secret);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
