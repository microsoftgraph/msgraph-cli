using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Applications.Item.AddKey {
    public class KeyCredentialRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public KeyCredential KeyCredential { get; set; }
        public PasswordCredential PasswordCredential { get; set; }
        public string Proof { get; set; }
        /// <summary>
        /// Instantiates a new KeyCredentialRequestBody and sets the default values.
        /// </summary>
        public KeyCredentialRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"keyCredential", (o,n) => { (o as KeyCredentialRequestBody).KeyCredential = n.GetObjectValue<KeyCredential>(); } },
                {"passwordCredential", (o,n) => { (o as KeyCredentialRequestBody).PasswordCredential = n.GetObjectValue<PasswordCredential>(); } },
                {"proof", (o,n) => { (o as KeyCredentialRequestBody).Proof = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<KeyCredential>("keyCredential", KeyCredential);
            writer.WriteObjectValue<PasswordCredential>("passwordCredential", PasswordCredential);
            writer.WriteStringValue("proof", Proof);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
