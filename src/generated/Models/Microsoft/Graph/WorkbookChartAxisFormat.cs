using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartAxisFormat : Entity, IParsable {
        /// <summary>Represents the font attributes (font name, font size, color, etc.) for a chart axis element. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartFont Font { get; set; }
        /// <summary>Represents chart line formatting. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookChartLineFormat Line { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.WorkbookChartAxisFormat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartAxisFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"font", (o,n) => { (o as WorkbookChartAxisFormat).Font = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartFont>(ApiSdk.Models.Microsoft.Graph.WorkbookChartFont.CreateFromDiscriminatorValue); } },
                {"line", (o,n) => { (o as WorkbookChartAxisFormat).Line = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartLineFormat>(ApiSdk.Models.Microsoft.Graph.WorkbookChartLineFormat.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartFont>("font", Font);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookChartLineFormat>("line", Line);
        }
    }
}
