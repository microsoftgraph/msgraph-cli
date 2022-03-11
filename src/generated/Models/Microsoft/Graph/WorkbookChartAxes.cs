using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartAxes : Entity, IParsable {
        /// <summary>Represents the category axis in a chart. Read-only.</summary>
        public WorkbookChartAxis CategoryAxis { get; set; }
        /// <summary>Represents the series axis of a 3-dimensional chart. Read-only.</summary>
        public WorkbookChartAxis SeriesAxis { get; set; }
        /// <summary>Represents the value axis in an axis. Read-only.</summary>
        public WorkbookChartAxis ValueAxis { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookChartAxes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartAxes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categoryAxis", (o,n) => { (o as WorkbookChartAxes).CategoryAxis = n.GetObjectValue<WorkbookChartAxis>(WorkbookChartAxis.CreateFromDiscriminatorValue); } },
                {"seriesAxis", (o,n) => { (o as WorkbookChartAxes).SeriesAxis = n.GetObjectValue<WorkbookChartAxis>(WorkbookChartAxis.CreateFromDiscriminatorValue); } },
                {"valueAxis", (o,n) => { (o as WorkbookChartAxes).ValueAxis = n.GetObjectValue<WorkbookChartAxis>(WorkbookChartAxis.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartAxis>("categoryAxis", CategoryAxis);
            writer.WriteObjectValue<WorkbookChartAxis>("seriesAxis", SeriesAxis);
            writer.WriteObjectValue<WorkbookChartAxis>("valueAxis", ValueAxis);
        }
    }
}
