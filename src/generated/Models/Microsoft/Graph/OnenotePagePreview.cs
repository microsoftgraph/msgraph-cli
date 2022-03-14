using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnenotePagePreview : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public OnenotePagePreviewLinks Links { get; set; }
        public string PreviewText { get; set; }
        /// <summary>
        /// Instantiates a new onenotePagePreview and sets the default values.
        /// </summary>
        public OnenotePagePreview() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OnenotePagePreview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnenotePagePreview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"links", (o,n) => { (o as OnenotePagePreview).Links = n.GetObjectValue<OnenotePagePreviewLinks>(OnenotePagePreviewLinks.CreateFromDiscriminatorValue); } },
                {"previewText", (o,n) => { (o as OnenotePagePreview).PreviewText = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<OnenotePagePreviewLinks>("links", Links);
            writer.WriteStringValue("previewText", PreviewText);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
