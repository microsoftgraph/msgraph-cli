using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartLegend : Entity, IParsable {
        /// <summary>Represents the formatting of a chart legend, which includes fill and font formatting. Read-only.</summary>
        public WorkbookChartLegendFormat Format { get; set; }
        /// <summary>Boolean value for whether the chart legend should overlap with the main body of the chart.</summary>
        public bool? Overlay { get; set; }
        /// <summary>Represents the position of the legend on the chart. The possible values are: Top, Bottom, Left, Right, Corner, Custom.</summary>
        public string Position { get; set; }
        /// <summary>A boolean value the represents the visibility of a ChartLegend object.</summary>
        public bool? Visible { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as WorkbookChartLegend).Format = n.GetObjectValue<WorkbookChartLegendFormat>(); } },
                {"overlay", (o,n) => { (o as WorkbookChartLegend).Overlay = n.GetBoolValue(); } },
                {"position", (o,n) => { (o as WorkbookChartLegend).Position = n.GetStringValue(); } },
                {"visible", (o,n) => { (o as WorkbookChartLegend).Visible = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartLegendFormat>("format", Format);
            writer.WriteBoolValue("overlay", Overlay);
            writer.WriteStringValue("position", Position);
            writer.WriteBoolValue("visible", Visible);
        }
    }
}
