using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedAppOperation : Entity, IParsable {
        /// <summary>The operation name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The last time the app operation was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The current state of the operation</summary>
        public string State { get; set; }
        /// <summary>Version of the entity.</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as ManagedAppOperation).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ManagedAppOperation).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", (o,n) => { (o as ManagedAppOperation).State = n.GetStringValue(); } },
                {"version", (o,n) => { (o as ManagedAppOperation).Version = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("version", Version);
        }
    }
}
