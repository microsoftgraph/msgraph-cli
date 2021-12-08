using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SizeRange : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The maximum size (in kilobytes) that an incoming message must have in order for a condition or exception to apply.</summary>
        public int? MaximumSize { get; set; }
        /// <summary>The minimum size (in kilobytes) that an incoming message must have in order for a condition or exception to apply.</summary>
        public int? MinimumSize { get; set; }
        /// <summary>
        /// Instantiates a new sizeRange and sets the default values.
        /// </summary>
        public SizeRange() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"maximumSize", (o,n) => { (o as SizeRange).MaximumSize = n.GetIntValue(); } },
                {"minimumSize", (o,n) => { (o as SizeRange).MinimumSize = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("maximumSize", MaximumSize);
            writer.WriteIntValue("minimumSize", MinimumSize);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
