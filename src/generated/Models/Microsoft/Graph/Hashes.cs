using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Hashes : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CRC32 value of the file (if available). Read-only.</summary>
        public string Crc32Hash { get; set; }
        /// <summary>A proprietary hash of the file that can be used to determine if the contents of the file have changed (if available). Read-only.</summary>
        public string QuickXorHash { get; set; }
        /// <summary>SHA1 hash for the contents of the file (if available). Read-only.</summary>
        public string Sha1Hash { get; set; }
        /// <summary>SHA256 hash for the contents of the file (if available). Read-only.</summary>
        public string Sha256Hash { get; set; }
        /// <summary>
        /// Instantiates a new hashes and sets the default values.
        /// </summary>
        public Hashes() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"crc32Hash", (o,n) => { (o as Hashes).Crc32Hash = n.GetStringValue(); } },
                {"quickXorHash", (o,n) => { (o as Hashes).QuickXorHash = n.GetStringValue(); } },
                {"sha1Hash", (o,n) => { (o as Hashes).Sha1Hash = n.GetStringValue(); } },
                {"sha256Hash", (o,n) => { (o as Hashes).Sha256Hash = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("crc32Hash", Crc32Hash);
            writer.WriteStringValue("quickXorHash", QuickXorHash);
            writer.WriteStringValue("sha1Hash", Sha1Hash);
            writer.WriteStringValue("sha256Hash", Sha256Hash);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
