using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamworkHostedContent : Entity, IParsable {
        /// <summary>Write only. Bytes for the hosted content (such as images).</summary>
        public byte[] ContentBytes { get; set; }
        /// <summary>Write only. Content type, such as image/png, image/jpg.</summary>
        public string ContentType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contentBytes", (o,n) => { (o as TeamworkHostedContent).ContentBytes = n.GetByteArrayValue(); } },
                {"contentType", (o,n) => { (o as TeamworkHostedContent).ContentType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("contentBytes", ContentBytes);
            writer.WriteStringValue("contentType", ContentType);
        }
    }
}
