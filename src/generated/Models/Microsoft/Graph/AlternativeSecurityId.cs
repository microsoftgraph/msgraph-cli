using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AlternativeSecurityId : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>For internal use only</summary>
        public string IdentityProvider { get; set; }
        /// <summary>For internal use only</summary>
        public byte[] Key { get; set; }
        /// <summary>For internal use only</summary>
        public int? Type { get; set; }
        /// <summary>
        /// Instantiates a new alternativeSecurityId and sets the default values.
        /// </summary>
        public AlternativeSecurityId() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"identityProvider", (o,n) => { (o as AlternativeSecurityId).IdentityProvider = n.GetStringValue(); } },
                {"key", (o,n) => { (o as AlternativeSecurityId).Key = n.GetByteArrayValue(); } },
                {"type", (o,n) => { (o as AlternativeSecurityId).Type = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("identityProvider", IdentityProvider);
            writer.WriteByteArrayValue("key", Key);
            writer.WriteIntValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
