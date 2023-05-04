using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PrintMargin : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The margin in microns from the bottom edge.</summary>
        public int? Bottom { get; set; }
        /// <summary>The margin in microns from the left edge.</summary>
        public int? Left { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrintMargin CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintMargin();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bottom", n => { Bottom = n.GetIntValue(); } },
                {"left", n => { Left = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"right", n => { Right = n.GetIntValue(); } },
                {"top", n => { Top = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("bottom", Bottom);
            writer.WriteIntValue("left", Left);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("right", Right);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
