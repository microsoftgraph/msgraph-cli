using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ImageInfo : IParsable {
        /// <summary>Optional; parameter used to indicate the server is able to render image dynamically in response to parameterization. For example – a high contrast image</summary>
        public bool? AddImageQuery { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional; alt-text accessible content for the image</summary>
        public string AlternateText { get; set; }
        public string AlternativeText { get; set; }
        /// <summary>Optional; URI that points to an icon which represents the application used to generate the activity</summary>
        public string IconUrl { get; set; }
        /// <summary>
        /// Instantiates a new imageInfo and sets the default values.
        /// </summary>
        public ImageInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addImageQuery", (o,n) => { (o as ImageInfo).AddImageQuery = n.GetBoolValue(); } },
                {"alternateText", (o,n) => { (o as ImageInfo).AlternateText = n.GetStringValue(); } },
                {"alternativeText", (o,n) => { (o as ImageInfo).AlternativeText = n.GetStringValue(); } },
                {"iconUrl", (o,n) => { (o as ImageInfo).IconUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("addImageQuery", AddImageQuery);
            writer.WriteStringValue("alternateText", AlternateText);
            writer.WriteStringValue("alternativeText", AlternativeText);
            writer.WriteStringValue("iconUrl", IconUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
