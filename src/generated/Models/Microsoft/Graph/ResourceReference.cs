using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ResourceReference : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The item's unique identifier.</summary>
        public string Id { get; set; }
        /// <summary>A string value that can be used to classify the item, such as 'microsoft.graph.driveItem'</summary>
        public string Type { get; set; }
        /// <summary>A URL leading to the referenced item.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new resourceReference and sets the default values.
        /// </summary>
        public ResourceReference() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"id", (o,n) => { (o as ResourceReference).Id = n.GetStringValue(); } },
                {"type", (o,n) => { (o as ResourceReference).Type = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as ResourceReference).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
