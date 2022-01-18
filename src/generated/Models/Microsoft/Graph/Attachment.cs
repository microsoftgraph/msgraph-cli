using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Attachment : Entity, IParsable {
        /// <summary>The MIME type.</summary>
        public string ContentType { get; set; }
        /// <summary>true if the attachment is an inline attachment; otherwise, false.</summary>
        public bool? IsInline { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The display name of the attachment. This does not need to be the actual file name.</summary>
        public string Name { get; set; }
        /// <summary>The length of the attachment in bytes.</summary>
        public int? Size { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contentType", (o,n) => { (o as Attachment).ContentType = n.GetStringValue(); } },
                {"isInline", (o,n) => { (o as Attachment).IsInline = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Attachment).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as Attachment).Name = n.GetStringValue(); } },
                {"size", (o,n) => { (o as Attachment).Size = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteBoolValue("isInline", IsInline);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("size", Size);
        }
    }
}
