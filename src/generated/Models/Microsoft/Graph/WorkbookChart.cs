using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChart : Entity, IParsable {
        /// <summary>Represents chart axes. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartAxes Axes { get; set; }
        /// <summary>Represents the datalabels on the chart. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartDataLabels DataLabels { get; set; }
        /// <summary>Encapsulates the format properties for the chart area. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartAreaFormat Format { get; set; }
        /// <summary>Represents the height, in points, of the chart object.</summary>
        public double? Height { get; set; }
        /// <summary>The distance, in points, from the left side of the chart to the worksheet origin.</summary>
        public double? Left { get; set; }
        /// <summary>Represents the legend for the chart. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartLegend Legend { get; set; }
        /// <summary>Represents the name of a chart object.</summary>
        public string Name { get; set; }
        /// <summary>Represents either a single series or collection of series in the chart. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookChartSeries> Series { get; set; }
        /// <summary>Represents the title of the specified chart, including the text, visibility, position and formating of the title. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartTitle Title { get; set; }
        /// <summary>Represents the distance, in points, from the top edge of the object to the top of row 1 (on a worksheet) or the top of the chart area (on a chart).</summary>
        public double? Top { get; set; }
        /// <summary>Represents the width, in points, of the chart object.</summary>
        public double? Width { get; set; }
        /// <summary>The worksheet containing the current chart. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet Worksheet { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.WorkbookChart CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"axes", (o,n) => { (o as WorkbookChart).Axes = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartAxes>(ApiSdk.Models.Microsoft.Graph.WorkbookChartAxes.CreateFromDiscriminatorValue); } },
                {"dataLabels", (o,n) => { (o as WorkbookChart).DataLabels = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartDataLabels>(ApiSdk.Models.Microsoft.Graph.WorkbookChartDataLabels.CreateFromDiscriminatorValue); } },
                {"format", (o,n) => { (o as WorkbookChart).Format = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartAreaFormat>(ApiSdk.Models.Microsoft.Graph.WorkbookChartAreaFormat.CreateFromDiscriminatorValue); } },
                {"height", (o,n) => { (o as WorkbookChart).Height = n.GetDoubleValue(); } },
                {"left", (o,n) => { (o as WorkbookChart).Left = n.GetDoubleValue(); } },
                {"legend", (o,n) => { (o as WorkbookChart).Legend = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartLegend>(ApiSdk.Models.Microsoft.Graph.WorkbookChartLegend.CreateFromDiscriminatorValue); } },
                {"name", (o,n) => { (o as WorkbookChart).Name = n.GetStringValue(); } },
                {"series", (o,n) => { (o as WorkbookChart).Series = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookChartSeries>(ApiSdk.Models.Microsoft.Graph.WorkbookChartSeries.CreateFromDiscriminatorValue).ToList(); } },
                {"title", (o,n) => { (o as WorkbookChart).Title = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartTitle>(ApiSdk.Models.Microsoft.Graph.WorkbookChartTitle.CreateFromDiscriminatorValue); } },
                {"top", (o,n) => { (o as WorkbookChart).Top = n.GetDoubleValue(); } },
                {"width", (o,n) => { (o as WorkbookChart).Width = n.GetDoubleValue(); } },
                {"worksheet", (o,n) => { (o as WorkbookChart).Worksheet = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet>(ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartAxes>("axes", Axes);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartDataLabels>("dataLabels", DataLabels);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartAreaFormat>("format", Format);
            writer.WriteDoubleValue("height", Height);
            writer.WriteDoubleValue("left", Left);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartLegend>("legend", Legend);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookChartSeries>("series", Series);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartTitle>("title", Title);
            writer.WriteDoubleValue("top", Top);
            writer.WriteDoubleValue("width", Width);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
