using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookChartPoint : Entity, IParsable {
        /// <summary>Encapsulates the format properties chart point. Read-only.</summary>
        public WorkbookChartPointFormat Format { get; set; }
        /// <summary>Returns the value of a chart point. Read-only.</summary>
        public Json Value { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookChartPoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartPoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as WorkbookChartPoint).Format = n.GetObjectValue<WorkbookChartPointFormat>(WorkbookChartPointFormat.CreateFromDiscriminatorValue); } },
                {"value", (o,n) => { (o as WorkbookChartPoint).Value = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartPointFormat>("format", Format);
            writer.WriteObjectValue<Json>("value", Value);
        }
    }
}
