using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Color in RGB.</summary>
    public class RgbColor : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Blue value</summary>
        public byte? B { get; set; }
        /// <summary>Green value</summary>
        public byte? G { get; set; }
        /// <summary>Red value</summary>
        public byte? R { get; set; }
        /// <summary>
        /// Instantiates a new rgbColor and sets the default values.
        /// </summary>
        public RgbColor() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.RgbColor CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RgbColor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"b", (o,n) => { (o as RgbColor).B = n.GetByteValue(); } },
                {"g", (o,n) => { (o as RgbColor).G = n.GetByteValue(); } },
                {"r", (o,n) => { (o as RgbColor).R = n.GetByteValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteValue("b", B);
            writer.WriteByteValue("g", G);
            writer.WriteByteValue("r", R);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
