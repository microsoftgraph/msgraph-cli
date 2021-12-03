using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintMargin : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The margin in microns from the bottom edge.</summary>
        public int? Bottom { get; set; }
        /// <summary>The margin in microns from the left edge.</summary>
        public int? Left { get; set; }
        /// <summary>The margin in microns from the right edge.</summary>
        public int? Right { get; set; }
        /// <summary>The margin in microns from the top edge.</summary>
        public int? Top { get; set; }
        /// <summary>
        /// Instantiates a new printMargin and sets the default values.
        /// </summary>
        public PrintMargin() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bottom", (o,n) => { (o as PrintMargin).Bottom = n.GetIntValue(); } },
                {"left", (o,n) => { (o as PrintMargin).Left = n.GetIntValue(); } },
                {"right", (o,n) => { (o as PrintMargin).Right = n.GetIntValue(); } },
                {"top", (o,n) => { (o as PrintMargin).Top = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("bottom", Bottom);
            writer.WriteIntValue("left", Left);
            writer.WriteIntValue("right", Right);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
