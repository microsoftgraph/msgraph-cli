using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartTitleFormat : Entity, IParsable {
        /// <summary>Represents the fill format of an object, which includes background formatting information. Read-only.</summary>
        public WorkbookChartFill Fill { get; set; }
        /// <summary>Represents the font attributes (font name, font size, color, etc.) for the current object. Read-only.</summary>
        public WorkbookChartFont Font { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookChartTitleFormat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartTitleFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"fill", (o,n) => { (o as WorkbookChartTitleFormat).Fill = n.GetObjectValue<WorkbookChartFill>(WorkbookChartFill.CreateFromDiscriminatorValue); } },
                {"font", (o,n) => { (o as WorkbookChartTitleFormat).Font = n.GetObjectValue<WorkbookChartFont>(WorkbookChartFont.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<WorkbookChartFont>("font", Font);
        }
    }
}
