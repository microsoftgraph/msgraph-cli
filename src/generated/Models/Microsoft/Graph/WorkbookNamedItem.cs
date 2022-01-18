using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookNamedItem : Entity, IParsable {
        /// <summary>Represents the comment associated with this name.</summary>
        public string Comment { get; set; }
        /// <summary>The name of the object. Read-only.</summary>
        public string Name { get; set; }
        /// <summary>Indicates whether the name is scoped to the workbook or to a specific worksheet. Read-only.</summary>
        public string Scope { get; set; }
        /// <summary>Indicates what type of reference is associated with the name. Possible values are: String, Integer, Double, Boolean, Range. Read-only.</summary>
        public string Type { get; set; }
        /// <summary>Represents the formula that the name is defined to refer to. E.g. =Sheet14!$B$2:$H$12, =4.75, etc. Read-only.</summary>
        public Json Value { get; set; }
        /// <summary>Specifies whether the object is visible or not.</summary>
        public bool? Visible { get; set; }
        /// <summary>Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.</summary>
        public WorkbookWorksheet Worksheet { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"comment", (o,n) => { (o as WorkbookNamedItem).Comment = n.GetStringValue(); } },
                {"name", (o,n) => { (o as WorkbookNamedItem).Name = n.GetStringValue(); } },
                {"scope", (o,n) => { (o as WorkbookNamedItem).Scope = n.GetStringValue(); } },
                {"type", (o,n) => { (o as WorkbookNamedItem).Type = n.GetStringValue(); } },
                {"value", (o,n) => { (o as WorkbookNamedItem).Value = n.GetObjectValue<Json>(); } },
                {"visible", (o,n) => { (o as WorkbookNamedItem).Visible = n.GetBoolValue(); } },
                {"worksheet", (o,n) => { (o as WorkbookNamedItem).Worksheet = n.GetObjectValue<WorkbookWorksheet>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("type", Type);
            writer.WriteObjectValue<Json>("value", Value);
            writer.WriteBoolValue("visible", Visible);
            writer.WriteObjectValue<WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
