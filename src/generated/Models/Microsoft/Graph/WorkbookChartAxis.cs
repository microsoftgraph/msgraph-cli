using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartAxis : Entity, IParsable {
        /// <summary>Represents the formatting of a chart object, which includes line and font formatting. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartAxisFormat Format { get; set; }
        /// <summary>Returns a gridlines object that represents the major gridlines for the specified axis. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartGridlines MajorGridlines { get; set; }
        /// <summary>Represents the interval between two major tick marks. Can be set to a numeric value or an empty string.  The returned value is always a number.</summary>
        public ApiSdk.Models.Microsoft.Graph.Json MajorUnit { get; set; }
        /// <summary>Represents the maximum value on the value axis.  Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.</summary>
        public ApiSdk.Models.Microsoft.Graph.Json Maximum { get; set; }
        /// <summary>Represents the minimum value on the value axis. Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.</summary>
        public ApiSdk.Models.Microsoft.Graph.Json Minimum { get; set; }
        /// <summary>Returns a Gridlines object that represents the minor gridlines for the specified axis. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartGridlines MinorGridlines { get; set; }
        /// <summary>Represents the interval between two minor tick marks. 'Can be set to a numeric value or an empty string (for automatic axis values). The returned value is always a number.</summary>
        public ApiSdk.Models.Microsoft.Graph.Json MinorUnit { get; set; }
        /// <summary>Represents the axis title. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartAxisTitle Title { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.WorkbookChartAxis CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartAxis();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as WorkbookChartAxis).Format = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartAxisFormat>(ApiSdk.Models.Microsoft.Graph.WorkbookChartAxisFormat.CreateFromDiscriminatorValue); } },
                {"majorGridlines", (o,n) => { (o as WorkbookChartAxis).MajorGridlines = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartGridlines>(ApiSdk.Models.Microsoft.Graph.WorkbookChartGridlines.CreateFromDiscriminatorValue); } },
                {"majorUnit", (o,n) => { (o as WorkbookChartAxis).MajorUnit = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Json>(ApiSdk.Models.Microsoft.Graph.Json.CreateFromDiscriminatorValue); } },
                {"maximum", (o,n) => { (o as WorkbookChartAxis).Maximum = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Json>(ApiSdk.Models.Microsoft.Graph.Json.CreateFromDiscriminatorValue); } },
                {"minimum", (o,n) => { (o as WorkbookChartAxis).Minimum = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Json>(ApiSdk.Models.Microsoft.Graph.Json.CreateFromDiscriminatorValue); } },
                {"minorGridlines", (o,n) => { (o as WorkbookChartAxis).MinorGridlines = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartGridlines>(ApiSdk.Models.Microsoft.Graph.WorkbookChartGridlines.CreateFromDiscriminatorValue); } },
                {"minorUnit", (o,n) => { (o as WorkbookChartAxis).MinorUnit = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Json>(ApiSdk.Models.Microsoft.Graph.Json.CreateFromDiscriminatorValue); } },
                {"title", (o,n) => { (o as WorkbookChartAxis).Title = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartAxisTitle>(ApiSdk.Models.Microsoft.Graph.WorkbookChartAxisTitle.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartAxisFormat>("format", Format);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartGridlines>("majorGridlines", MajorGridlines);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Json>("majorUnit", MajorUnit);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Json>("maximum", Maximum);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Json>("minimum", Minimum);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartGridlines>("minorGridlines", MinorGridlines);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Json>("minorUnit", MinorUnit);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartAxisTitle>("title", Title);
        }
    }
}
