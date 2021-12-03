using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RgbColor : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Blue value</summary>
        public int? B { get; set; }
        /// <summary>Green value</summary>
        public int? G { get; set; }
        /// <summary>Red value</summary>
        public int? R { get; set; }
        /// <summary>
        /// Instantiates a new rgbColor and sets the default values.
        /// </summary>
        public RgbColor() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"b", (o,n) => { (o as RgbColor).B = n.GetIntValue(); } },
                {"g", (o,n) => { (o as RgbColor).G = n.GetIntValue(); } },
                {"r", (o,n) => { (o as RgbColor).R = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("b", B);
            writer.WriteIntValue("g", G);
            writer.WriteIntValue("r", R);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
