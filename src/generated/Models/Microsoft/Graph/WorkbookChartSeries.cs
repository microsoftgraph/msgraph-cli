using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartSeries : Entity, IParsable {
        /// <summary>Represents the formatting of a chart series, which includes fill and line formatting. Read-only.</summary>
        public WorkbookChartSeriesFormat Format { get; set; }
        /// <summary>Represents the name of a series in a chart.</summary>
        public string Name { get; set; }
        /// <summary>Represents a collection of all points in the series. Read-only.</summary>
        public List<WorkbookChartPoint> Points { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as WorkbookChartSeries).Format = n.GetObjectValue<WorkbookChartSeriesFormat>(); } },
                {"name", (o,n) => { (o as WorkbookChartSeries).Name = n.GetStringValue(); } },
                {"points", (o,n) => { (o as WorkbookChartSeries).Points = n.GetCollectionOfObjectValues<WorkbookChartPoint>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartSeriesFormat>("format", Format);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<WorkbookChartPoint>("points", Points);
        }
    }
}
