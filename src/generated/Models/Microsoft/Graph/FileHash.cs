using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class FileHash : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>File hash type. Possible values are: unknown, sha1, sha256, md5, authenticodeHash256, lsHash, ctph, peSha1, peSha256.</summary>
        public FileHashType? HashType { get; set; }
        /// <summary>Value of the file hash.</summary>
        public string HashValue { get; set; }
        /// <summary>
        /// Instantiates a new fileHash and sets the default values.
        /// </summary>
        public FileHash() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hashType", (o,n) => { (o as FileHash).HashType = n.GetEnumValue<FileHashType>(); } },
                {"hashValue", (o,n) => { (o as FileHash).HashValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<FileHashType>("hashType", HashType);
            writer.WriteStringValue("hashValue", HashValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
