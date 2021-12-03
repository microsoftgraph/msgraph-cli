using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Thumbnail : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content stream for the thumbnail.</summary>
        public byte[] Content { get; set; }
        /// <summary>The height of the thumbnail, in pixels.</summary>
        public int? Height { get; set; }
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
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"content", (o,n) => { (o as Thumbnail).Content = n.GetByteArrayValue(); } },
                {"height", (o,n) => { (o as Thumbnail).Height = n.GetIntValue(); } },
                {"sourceItemId", (o,n) => { (o as Thumbnail).SourceItemId = n.GetStringValue(); } },
                {"url", (o,n) => { (o as Thumbnail).Url = n.GetStringValue(); } },
                {"width", (o,n) => { (o as Thumbnail).Width = n.GetIntValue(); } },
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
            writer.WriteStringValue("sourceItemId", SourceItemId);
            writer.WriteStringValue("url", Url);
            writer.WriteIntValue("width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
