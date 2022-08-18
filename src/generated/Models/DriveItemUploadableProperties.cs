using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DriveItemUploadableProperties : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Provides a user-visible description of the item. Read-write. Only on OneDrive Personal.</summary>
        public string Description { get; set; }
        /// <summary>Provides an expected file size to perform a quota check prior to upload. Only on OneDrive Personal.</summary>
        public long? FileSize { get; set; }
        /// <summary>File system information on client. Read-write.</summary>
        public ApiSdk.Models.FileSystemInfo FileSystemInfo { get; set; }
        /// <summary>The name of the item (filename and extension). Read-write.</summary>
        public string Name { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new driveItemUploadableProperties and sets the default values.
        /// </summary>
        public DriveItemUploadableProperties() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.driveItemUploadableProperties";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DriveItemUploadableProperties CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DriveItemUploadableProperties();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"fileSize", n => { FileSize = n.GetLongValue(); } },
                {"fileSystemInfo", n => { FileSystemInfo = n.GetObjectValue<ApiSdk.Models.FileSystemInfo>(ApiSdk.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
