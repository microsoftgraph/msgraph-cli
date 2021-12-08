using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class FileSecurityState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Complex type containing file hashes (cryptographic and location-sensitive).</summary>
        public FileHash FileHash { get; set; }
        /// <summary>File name (without path).</summary>
        public string Name { get; set; }
        /// <summary>Full file path of the file/imageFile.</summary>
        public string Path { get; set; }
        /// <summary>Provider generated/calculated risk score of the alert file. Recommended value range of 0-1, which equates to a percentage.</summary>
        public string RiskScore { get; set; }
        /// <summary>
        /// Instantiates a new fileSecurityState and sets the default values.
        /// </summary>
        public FileSecurityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fileHash", (o,n) => { (o as FileSecurityState).FileHash = n.GetObjectValue<FileHash>(); } },
                {"name", (o,n) => { (o as FileSecurityState).Name = n.GetStringValue(); } },
                {"path", (o,n) => { (o as FileSecurityState).Path = n.GetStringValue(); } },
                {"riskScore", (o,n) => { (o as FileSecurityState).RiskScore = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<FileHash>("fileHash", FileHash);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("path", Path);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
