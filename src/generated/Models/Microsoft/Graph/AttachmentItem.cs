using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AttachmentItem : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of attachment. Possible values are: file, item, reference. Required.</summary>
        public AttachmentType? AttachmentType { get; set; }
        /// <summary>The nature of the data in the attachment. Optional.</summary>
        public string ContentType { get; set; }
        /// <summary>true if the attachment is an inline attachment; otherwise, false. Optional.</summary>
        public bool? IsInline { get; set; }
        /// <summary>The display name of the attachment. This can be a descriptive string and does not have to be the actual file name. Required.</summary>
        public string Name { get; set; }
        /// <summary>The length of the attachment in bytes. Required.</summary>
        public long? Size { get; set; }
        /// <summary>
        /// Instantiates a new attachmentItem and sets the default values.
        /// </summary>
        public AttachmentItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attachmentType", (o,n) => { (o as AttachmentItem).AttachmentType = n.GetEnumValue<AttachmentType>(); } },
                {"contentType", (o,n) => { (o as AttachmentItem).ContentType = n.GetStringValue(); } },
                {"isInline", (o,n) => { (o as AttachmentItem).IsInline = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as AttachmentItem).Name = n.GetStringValue(); } },
                {"size", (o,n) => { (o as AttachmentItem).Size = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AttachmentType>("attachmentType", AttachmentType);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteBoolValue("isInline", IsInline);
            writer.WriteStringValue("name", Name);
            writer.WriteLongValue("size", Size);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
