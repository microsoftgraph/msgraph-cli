using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookPivotTable : Entity, IParsable {
        /// <summary>Name of the PivotTable.</summary>
        public string Name { get; set; }
        /// <summary>The worksheet containing the current PivotTable. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet Worksheet { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.WorkbookPivotTable CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookPivotTable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"name", (o,n) => { (o as WorkbookPivotTable).Name = n.GetStringValue(); } },
                {"worksheet", (o,n) => { (o as WorkbookPivotTable).Worksheet = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet>(ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
