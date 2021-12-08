using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartAxisTitle : Entity, IParsable {
        /// <summary>Represents the formatting of chart axis title. Read-only.</summary>
        public WorkbookChartAxisTitleFormat Format { get; set; }
        /// <summary>Represents the axis title.</summary>
        public string Text { get; set; }
        /// <summary>A boolean that specifies the visibility of an axis title.</summary>
        public bool? Visible { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as WorkbookChartAxisTitle).Format = n.GetObjectValue<WorkbookChartAxisTitleFormat>(); } },
                {"text", (o,n) => { (o as WorkbookChartAxisTitle).Text = n.GetStringValue(); } },
                {"visible", (o,n) => { (o as WorkbookChartAxisTitle).Visible = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartAxisTitleFormat>("format", Format);
            writer.WriteStringValue("text", Text);
            writer.WriteBoolValue("visible", Visible);
        }
    }
}
