using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DriveItemUploadableProperties : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Provides a user-visible description of the item. Read-write. Only on OneDrive Personal.</summary>
        public string Description { get; set; }
        /// <summary>Provides an expected file size to perform a quota check prior to upload. Only on OneDrive Personal.</summary>
        public long? FileSize { get; set; }
        /// <summary>File system information on client. Read-write.</summary>
        public FileSystemInfo FileSystemInfo { get; set; }
        /// <summary>The name of the item (filename and extension). Read-write.</summary>
        public string Name { get; set; }
        /// <summary>
        /// Instantiates a new driveItemUploadableProperties and sets the default values.
        /// </summary>
        public DriveItemUploadableProperties() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as DriveItemUploadableProperties).Description = n.GetStringValue(); } },
                {"fileSize", (o,n) => { (o as DriveItemUploadableProperties).FileSize = n.GetLongValue(); } },
                {"fileSystemInfo", (o,n) => { (o as DriveItemUploadableProperties).FileSystemInfo = n.GetObjectValue<FileSystemInfo>(); } },
                {"name", (o,n) => { (o as DriveItemUploadableProperties).Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteLongValue("fileSize", FileSize);
            writer.WriteObjectValue<FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
