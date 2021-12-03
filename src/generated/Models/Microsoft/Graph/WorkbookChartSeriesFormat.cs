using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartSeriesFormat : Entity, IParsable {
        /// <summary>Represents the fill format of a chart series, which includes background formating information. Read-only.</summary>
        public WorkbookChartFill Fill { get; set; }
        /// <summary>Represents line formatting. Read-only.</summary>
        public WorkbookChartLineFormat Line { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"fill", (o,n) => { (o as WorkbookChartSeriesFormat).Fill = n.GetObjectValue<WorkbookChartFill>(); } },
                {"line", (o,n) => { (o as WorkbookChartSeriesFormat).Line = n.GetObjectValue<WorkbookChartLineFormat>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartFill>("fill", Fill);
            writer.WriteObjectValue<WorkbookChartLineFormat>("line", Line);
        }
    }
}
