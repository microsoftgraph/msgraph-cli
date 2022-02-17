using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ServiceAnnouncementAttachment : Entity, IParsable {
        /// <summary>The attachment content.</summary>
        public byte[] Content { get; set; }
        public string ContentType { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Name { get; set; }
        public int? Size { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as ServiceAnnouncementAttachment).Content = n.GetByteArrayValue(); } },
                {"contentType", (o,n) => { (o as ServiceAnnouncementAttachment).ContentType = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ServiceAnnouncementAttachment).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as ServiceAnnouncementAttachment).Name = n.GetStringValue(); } },
                {"size", (o,n) => { (o as ServiceAnnouncementAttachment).Size = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("size", Size);
        }
    }
}
