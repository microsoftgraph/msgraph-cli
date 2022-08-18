using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Contains properties for a single installer file that is associated with a given mobileAppContent version.</summary>
    public class MobileAppContentFile : Entity, IParsable {
        /// <summary>The Azure Storage URI.</summary>
        public string AzureStorageUri { get; set; }
        /// <summary>The time the Azure storage Uri expires.</summary>
        public DateTimeOffset? AzureStorageUriExpirationDateTime { get; set; }
        /// <summary>The time the file was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A value indicating whether the file is committed.</summary>
        public bool? IsCommitted { get; set; }
        /// <summary>The manifest information.</summary>
        public byte[] Manifest { get; set; }
        /// <summary>the file name.</summary>
        public string Name { get; set; }
        /// <summary>The size of the file prior to encryption.</summary>
        public long? Size { get; set; }
        /// <summary>The size of the file after encryption.</summary>
        public long? SizeEncrypted { get; set; }
        /// <summary>Contains properties for upload request states.</summary>
        public MobileAppContentFileUploadState? UploadState { get; set; }
        /// <summary>
        /// Instantiates a new mobileAppContentFile and sets the default values.
        /// </summary>
        public MobileAppContentFile() : base() {
            OdataType = "#microsoft.graph.mobileAppContentFile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppContentFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppContentFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureStorageUri", n => { AzureStorageUri = n.GetStringValue(); } },
                {"azureStorageUriExpirationDateTime", n => { AzureStorageUriExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isCommitted", n => { IsCommitted = n.GetBoolValue(); } },
                {"manifest", n => { Manifest = n.GetByteArrayValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"sizeEncrypted", n => { SizeEncrypted = n.GetLongValue(); } },
                {"uploadState", n => { UploadState = n.GetEnumValue<MobileAppContentFileUploadState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureStorageUri", AzureStorageUri);
            writer.WriteDateTimeOffsetValue("azureStorageUriExpirationDateTime", AzureStorageUriExpirationDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteBoolValue("isCommitted", IsCommitted);
            writer.WriteByteArrayValue("manifest", Manifest);
            writer.WriteStringValue("name", Name);
            writer.WriteLongValue("size", Size);
            writer.WriteLongValue("sizeEncrypted", SizeEncrypted);
            writer.WriteEnumValue<MobileAppContentFileUploadState>("uploadState", UploadState);
        }
    }
}
