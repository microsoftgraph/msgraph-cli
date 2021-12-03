using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintDocumentUploadProperties : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The document's content (MIME) type.</summary>
        public string ContentType { get; set; }
        /// <summary>The document's name.</summary>
        public string DocumentName { get; set; }
        /// <summary>The document's size in bytes.</summary>
        public long? Size { get; set; }
        /// <summary>
        /// Instantiates a new printDocumentUploadProperties and sets the default values.
        /// </summary>
        public PrintDocumentUploadProperties() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentType", (o,n) => { (o as PrintDocumentUploadProperties).ContentType = n.GetStringValue(); } },
                {"documentName", (o,n) => { (o as PrintDocumentUploadProperties).DocumentName = n.GetStringValue(); } },
                {"size", (o,n) => { (o as PrintDocumentUploadProperties).Size = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteStringValue("documentName", DocumentName);
            writer.WriteLongValue("size", Size);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
