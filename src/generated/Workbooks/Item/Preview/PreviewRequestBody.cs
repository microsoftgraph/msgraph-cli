using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Preview {
    public class PreviewRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Page { get; set; }
        public double? Zoom { get; set; }
        /// <summary>
        /// Instantiates a new previewRequestBody and sets the default values.
        /// </summary>
        public PreviewRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"page", (o,n) => { (o as PreviewRequestBody).Page = n.GetStringValue(); } },
                {"zoom", (o,n) => { (o as PreviewRequestBody).Zoom = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("page", Page);
            writer.WriteDoubleValue("zoom", Zoom);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
