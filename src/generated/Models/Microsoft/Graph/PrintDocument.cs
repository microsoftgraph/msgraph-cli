using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintDocument : Entity, IParsable {
        /// <summary>The document's content (MIME) type. Read-only.</summary>
        public string ContentType { get; set; }
        /// <summary>The document's name. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The document's size in bytes. Read-only.</summary>
        public long? Size { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contentType", (o,n) => { (o as PrintDocument).ContentType = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as PrintDocument).DisplayName = n.GetStringValue(); } },
                {"size", (o,n) => { (o as PrintDocument).Size = n.GetLongValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteLongValue("size", Size);
        }
    }
}
