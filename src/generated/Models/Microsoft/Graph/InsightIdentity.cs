using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class InsightIdentity : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address of the user who shared the item.</summary>
        public string Address { get; set; }
        /// <summary>The display name of the user who shared the item.</summary>
        public string DisplayName { get; set; }
        /// <summary>The id of the user who shared the item.</summary>
        public string Id { get; set; }
        /// <summary>
        /// Instantiates a new insightIdentity and sets the default values.
        /// </summary>
        public InsightIdentity() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"address", (o,n) => { (o as InsightIdentity).Address = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as InsightIdentity).DisplayName = n.GetStringValue(); } },
                {"id", (o,n) => { (o as InsightIdentity).Id = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
