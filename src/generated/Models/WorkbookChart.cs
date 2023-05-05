using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class WorkbookChart : Entity, IParsable {
        /// <summary>Represents chart axes. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartAxes? Axes { get; set; }
#nullable restore
#else
        public WorkbookChartAxes Axes { get; set; }
#endif
        /// <summary>Represents the datalabels on the chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartDataLabels? DataLabels { get; set; }
#nullable restore
#else
        public WorkbookChartDataLabels DataLabels { get; set; }
#endif
        /// <summary>Encapsulates the format properties for the chart area. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartAreaFormat? Format { get; set; }
#nullable restore
#else
        public WorkbookChartAreaFormat Format { get; set; }
#endif
        /// <summary>Represents the height, in points, of the chart object.</summary>
        public double? Height { get; set; }
        /// <summary>The distance, in points, from the left side of the chart to the worksheet origin.</summary>
        public double? Left { get; set; }
        /// <summary>Represents the legend for the chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartLegend? Legend { get; set; }
#nullable restore
#else
        public WorkbookChartLegend Legend { get; set; }
#endif
        /// <summary>Represents the name of a chart object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Represents either a single series or collection of series in the chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookChartSeries>? Series { get; set; }
#nullable restore
#else
        public List<WorkbookChartSeries> Series { get; set; }
#endif
        /// <summary>Represents the title of the specified chart, including the text, visibility, position and formating of the title. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartTitle? Title { get; set; }
#nullable restore
#else
        public WorkbookChartTitle Title { get; set; }
#endif
        /// <summary>Represents the distance, in points, from the top edge of the object to the top of row 1 (on a worksheet) or the top of the chart area (on a chart).</summary>
        public double? Top { get; set; }
        /// <summary>Represents the width, in points, of the chart object.</summary>
        public double? Width { get; set; }
        /// <summary>The worksheet containing the current chart. Read-only.</summary>
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
        public static new WorkbookChart CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"axes", n => { Axes = n.GetObjectValue<WorkbookChartAxes>(WorkbookChartAxes.CreateFromDiscriminatorValue); } },
                {"dataLabels", n => { DataLabels = n.GetObjectValue<WorkbookChartDataLabels>(WorkbookChartDataLabels.CreateFromDiscriminatorValue); } },
                {"format", n => { Format = n.GetObjectValue<WorkbookChartAreaFormat>(WorkbookChartAreaFormat.CreateFromDiscriminatorValue); } },
                {"height", n => { Height = n.GetDoubleValue(); } },
                {"left", n => { Left = n.GetDoubleValue(); } },
                {"legend", n => { Legend = n.GetObjectValue<WorkbookChartLegend>(WorkbookChartLegend.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"series", n => { Series = n.GetCollectionOfObjectValues<WorkbookChartSeries>(WorkbookChartSeries.CreateFromDiscriminatorValue)?.ToList(); } },
                {"title", n => { Title = n.GetObjectValue<WorkbookChartTitle>(WorkbookChartTitle.CreateFromDiscriminatorValue); } },
                {"top", n => { Top = n.GetDoubleValue(); } },
                {"width", n => { Width = n.GetDoubleValue(); } },
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
            writer.WriteObjectValue<WorkbookChartAxes>("axes", Axes);
            writer.WriteObjectValue<WorkbookChartDataLabels>("dataLabels", DataLabels);
            writer.WriteObjectValue<WorkbookChartAreaFormat>("format", Format);
            writer.WriteDoubleValue("height", Height);
            writer.WriteDoubleValue("left", Left);
            writer.WriteObjectValue<WorkbookChartLegend>("legend", Legend);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<WorkbookChartSeries>("series", Series);
            writer.WriteObjectValue<WorkbookChartTitle>("title", Title);
            writer.WriteDoubleValue("top", Top);
            writer.WriteDoubleValue("width", Width);
            writer.WriteObjectValue<WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
