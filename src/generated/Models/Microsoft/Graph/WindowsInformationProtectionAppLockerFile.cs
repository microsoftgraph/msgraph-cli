using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WindowsInformationProtectionAppLockerFile : Entity, IParsable {
        /// <summary>The friendly name</summary>
        public string DisplayName { get; set; }
        /// <summary>File as a byte array</summary>
        public byte[] File { get; set; }
        /// <summary>SHA256 hash of the file</summary>
        public string FileHash { get; set; }
        /// <summary>Version of the entity.</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsInformationProtectionAppLockerFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionAppLockerFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as WindowsInformationProtectionAppLockerFile).DisplayName = n.GetStringValue(); } },
                {"file", (o,n) => { (o as WindowsInformationProtectionAppLockerFile).File = n.GetByteArrayValue(); } },
                {"fileHash", (o,n) => { (o as WindowsInformationProtectionAppLockerFile).FileHash = n.GetStringValue(); } },
                {"version", (o,n) => { (o as WindowsInformationProtectionAppLockerFile).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteByteArrayValue("file", File);
            writer.WriteStringValue("fileHash", FileHash);
            writer.WriteStringValue("version", Version);
        }
    }
}
