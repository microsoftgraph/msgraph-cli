using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnenoteEntityHierarchyModel : OnenoteEntitySchemaObjectModel, IParsable {
        /// <summary>Identity of the user, device, and application which created the item. Read-only.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The name of the notebook.</summary>
        public string DisplayName { get; set; }
        /// <summary>Identity of the user, device, and application which created the item. Read-only.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as OnenoteEntityHierarchyModel).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"displayName", (o,n) => { (o as OnenoteEntityHierarchyModel).DisplayName = n.GetStringValue(); } },
                {"lastModifiedBy", (o,n) => { (o as OnenoteEntityHierarchyModel).LastModifiedBy = n.GetObjectValue<IdentitySet>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as OnenoteEntityHierarchyModel).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
