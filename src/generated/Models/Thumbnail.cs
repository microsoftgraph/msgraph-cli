using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Thumbnail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content stream for the thumbnail.</summary>
        public byte[] Content { get; set; }
        /// <summary>The height of the thumbnail, in pixels.</summary>
        public int? Height { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The unique identifier of the item that provided the thumbnail. This is only available when a folder thumbnail is requested.</summary>
        public string SourceItemId { get; set; }
        /// <summary>The URL used to fetch the thumbnail content.</summary>
        public string Url { get; set; }
        /// <summary>The width of the thumbnail, in pixels.</summary>
        public int? Width { get; set; }
        /// <summary>
        /// Instantiates a new thumbnail and sets the default values.
        /// </summary>
        public Thumbnail() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.thumbnail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Thumbnail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Thumbnail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"height", n => { Height = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sourceItemId", n => { SourceItemId = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("content", Content);
            writer.WriteIntValue("height", Height);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sourceItemId", SourceItemId);
            writer.WriteStringValue("url", Url);
            writer.WriteIntValue("width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
