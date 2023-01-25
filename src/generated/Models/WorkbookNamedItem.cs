using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WorkbookNamedItem : Entity, IParsable {
        /// <summary>Represents the comment associated with this name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The name of the object. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Indicates whether the name is scoped to the workbook or to a specific worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scope { get; set; }
#nullable restore
#else
        public string Scope { get; set; }
#endif
        /// <summary>Indicates what type of reference is associated with the name. The possible values are: String, Integer, Double, Boolean, Range. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>Represents the formula that the name is defined to refer to. E.g. =Sheet14!$B$2:$H$12, =4.75, etc. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Value { get; set; }
#nullable restore
#else
        public Json Value { get; set; }
#endif
        /// <summary>Specifies whether the object is visible or not.</summary>
        public bool? Visible { get; set; }
        /// <summary>Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookWorksheet? Worksheet { get; set; }
#nullable restore
#else
        public WorkbookWorksheet Worksheet { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookNamedItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookNamedItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"value", n => { Value = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"visible", n => { Visible = n.GetBoolValue(); } },
                {"worksheet", n => { Worksheet = n.GetObjectValue<WorkbookWorksheet>(WorkbookWorksheet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
