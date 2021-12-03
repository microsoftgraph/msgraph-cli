using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ItemBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content of the item.</summary>
        public string Content { get; set; }
        /// <summary>The type of the content. Possible values are text and html.</summary>
        public BodyType? ContentType { get; set; }
        /// <summary>
        /// Instantiates a new itemBody and sets the default values.
        /// </summary>
        public ItemBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"content", (o,n) => { (o as ItemBody).Content = n.GetStringValue(); } },
                {"contentType", (o,n) => { (o as ItemBody).ContentType = n.GetEnumValue<BodyType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("content", Content);
            writer.WriteEnumValue<BodyType>("contentType", ContentType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
