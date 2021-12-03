using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DocumentSetContent : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Content type information of the file.</summary>
        public ContentTypeInfo ContentType { get; set; }
        /// <summary>Name of the file in resource folder that should be added as a default content or a template in the document set.</summary>
        public string FileName { get; set; }
        /// <summary>Folder name in which the file will be placed when a new document set is created in the library.</summary>
        public string FolderName { get; set; }
        /// <summary>
        /// Instantiates a new documentSetContent and sets the default values.
        /// </summary>
        public DocumentSetContent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentType", (o,n) => { (o as DocumentSetContent).ContentType = n.GetObjectValue<ContentTypeInfo>(); } },
                {"fileName", (o,n) => { (o as DocumentSetContent).FileName = n.GetStringValue(); } },
                {"folderName", (o,n) => { (o as DocumentSetContent).FolderName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ContentTypeInfo>("contentType", ContentType);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("folderName", FolderName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
