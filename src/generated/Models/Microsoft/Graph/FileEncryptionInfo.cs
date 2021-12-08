using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class FileEncryptionInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The key used to encrypt the file content.</summary>
        public byte[] EncryptionKey { get; set; }
        /// <summary>The file digest prior to encryption.</summary>
        public byte[] FileDigest { get; set; }
        /// <summary>The file digest algorithm.</summary>
        public string FileDigestAlgorithm { get; set; }
        /// <summary>The initialization vector used for the encryption algorithm.</summary>
        public byte[] InitializationVector { get; set; }
        /// <summary>The hash of the encrypted file content + IV (content hash).</summary>
        public byte[] Mac { get; set; }
        /// <summary>The key used to get mac.</summary>
        public byte[] MacKey { get; set; }
        /// <summary>The the profile identifier.</summary>
        public string ProfileIdentifier { get; set; }
        /// <summary>
        /// Instantiates a new fileEncryptionInfo and sets the default values.
        /// </summary>
        public FileEncryptionInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"encryptionKey", (o,n) => { (o as FileEncryptionInfo).EncryptionKey = n.GetByteArrayValue(); } },
                {"fileDigest", (o,n) => { (o as FileEncryptionInfo).FileDigest = n.GetByteArrayValue(); } },
                {"fileDigestAlgorithm", (o,n) => { (o as FileEncryptionInfo).FileDigestAlgorithm = n.GetStringValue(); } },
                {"initializationVector", (o,n) => { (o as FileEncryptionInfo).InitializationVector = n.GetByteArrayValue(); } },
                {"mac", (o,n) => { (o as FileEncryptionInfo).Mac = n.GetByteArrayValue(); } },
                {"macKey", (o,n) => { (o as FileEncryptionInfo).MacKey = n.GetByteArrayValue(); } },
                {"profileIdentifier", (o,n) => { (o as FileEncryptionInfo).ProfileIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("encryptionKey", EncryptionKey);
            writer.WriteByteArrayValue("fileDigest", FileDigest);
            writer.WriteStringValue("fileDigestAlgorithm", FileDigestAlgorithm);
            writer.WriteByteArrayValue("initializationVector", InitializationVector);
            writer.WriteByteArrayValue("mac", Mac);
            writer.WriteByteArrayValue("macKey", MacKey);
            writer.WriteStringValue("profileIdentifier", ProfileIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
