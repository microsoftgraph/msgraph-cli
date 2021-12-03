using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartTitle : Entity, IParsable {
        /// <summary>Represents the formatting of a chart title, which includes fill and font formatting. Read-only.</summary>
        public WorkbookChartTitleFormat Format { get; set; }
        /// <summary>Boolean value representing if the chart title will overlay the chart or not.</summary>
        public bool? Overlay { get; set; }
        /// <summary>Represents the title text of a chart.</summary>
        public string Text { get; set; }
        /// <summary>A boolean value the represents the visibility of a chart title object.</summary>
        public bool? Visible { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as WorkbookChartTitle).Format = n.GetObjectValue<WorkbookChartTitleFormat>(); } },
                {"overlay", (o,n) => { (o as WorkbookChartTitle).Overlay = n.GetBoolValue(); } },
                {"text", (o,n) => { (o as WorkbookChartTitle).Text = n.GetStringValue(); } },
                {"visible", (o,n) => { (o as WorkbookChartTitle).Visible = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartTitleFormat>("format", Format);
            writer.WriteBoolValue("overlay", Overlay);
            writer.WriteStringValue("text", Text);
            writer.WriteBoolValue("visible", Visible);
        }
    }
}
