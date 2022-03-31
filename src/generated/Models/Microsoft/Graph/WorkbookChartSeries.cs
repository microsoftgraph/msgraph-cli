using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartSeries : Entity, IParsable {
        /// <summary>Represents the formatting of a chart series, which includes fill and line formatting. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartSeriesFormat Format { get; set; }
        /// <summary>Represents the name of a series in a chart.</summary>
        public string Name { get; set; }
        /// <summary>Represents a collection of all points in the series. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookChartPoint> Points { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.WorkbookChartSeries CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartSeries();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as WorkbookChartSeries).Format = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartSeriesFormat>(ApiSdk.Models.Microsoft.Graph.WorkbookChartSeriesFormat.CreateFromDiscriminatorValue); } },
                {"name", (o,n) => { (o as WorkbookChartSeries).Name = n.GetStringValue(); } },
                {"points", (o,n) => { (o as WorkbookChartSeries).Points = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookChartPoint>(ApiSdk.Models.Microsoft.Graph.WorkbookChartPoint.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartSeriesFormat>("format", Format);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookChartPoint>("points", Points);
        }
    }
}
