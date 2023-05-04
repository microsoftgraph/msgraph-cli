using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AttachmentItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of attachment. Possible values are: file, item, reference. Required.</summary>
        public ApiSdk.Models.AttachmentType? AttachmentType { get; set; }
        /// <summary>The CID or Content-Id of the attachment for referencing in case of in-line attachments using &lt;img src=&apos;cid:contentId&apos;&gt; tag in HTML messages. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentId { get; set; }
#nullable restore
#else
        public string ContentId { get; set; }
#endif
        /// <summary>The nature of the data in the attachment. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType { get; set; }
#nullable restore
#else
        public string ContentType { get; set; }
#endif
        /// <summary>true if the attachment is an inline attachment; otherwise, false. Optional.</summary>
        public bool? IsInline { get; set; }
        /// <summary>The display name of the attachment. This can be a descriptive string and does not have to be the actual file name. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The length of the attachment in bytes. Required.</summary>
        public long? Size { get; set; }
        /// <summary>
        /// Instantiates a new attachmentItem and sets the default values.
        /// </summary>
        public AttachmentItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttachmentItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttachmentItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attachmentType", n => { AttachmentType = n.GetEnumValue<AttachmentType>(); } },
                {"contentId", n => { ContentId = n.GetStringValue(); } },
                {"contentType", n => { ContentType = n.GetStringValue(); } },
                {"isInline", n => { IsInline = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"size", n => { Size = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AttachmentType>("attachmentType", AttachmentType);
            writer.WriteStringValue("contentId", ContentId);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteBoolValue("isInline", IsInline);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("size", Size);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
