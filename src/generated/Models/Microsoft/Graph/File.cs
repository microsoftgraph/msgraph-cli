using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class File : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Hashes of the file's binary content, if available. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Hashes Hashes { get; set; }
        /// <summary>The MIME type for the file. This is determined by logic on the server and might not be the value provided when the file was uploaded. Read-only.</summary>
        public string MimeType { get; set; }
        public bool? ProcessingMetadata { get; set; }
        /// <summary>
        /// Instantiates a new file and sets the default values.
        /// </summary>
        public File() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.File CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new File();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hashes", (o,n) => { (o as File).Hashes = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Hashes>(ApiSdk.Models.Microsoft.Graph.Hashes.CreateFromDiscriminatorValue); } },
                {"mimeType", (o,n) => { (o as File).MimeType = n.GetStringValue(); } },
                {"processingMetadata", (o,n) => { (o as File).ProcessingMetadata = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Hashes>("hashes", Hashes);
            writer.WriteStringValue("mimeType", MimeType);
            writer.WriteBoolValue("processingMetadata", ProcessingMetadata);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
