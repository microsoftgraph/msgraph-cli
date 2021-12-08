using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OutlookCategory : Entity, IParsable {
        /// <summary>A pre-set color constant that characterizes a category, and that is mapped to one of 25 predefined colors. See the note below.</summary>
        public CategoryColor? Color { get; set; }
        /// <summary>A unique name that identifies a category in the user's mailbox. After a category is created, the name cannot be changed. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"color", (o,n) => { (o as OutlookCategory).Color = n.GetEnumValue<CategoryColor>(); } },
                {"displayName", (o,n) => { (o as OutlookCategory).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CategoryColor>("color", Color);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
