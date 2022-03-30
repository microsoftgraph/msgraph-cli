using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookTableRow : Entity, IParsable {
        /// <summary>Returns the index number of the row within the rows collection of the table. Zero-indexed. Read-only.</summary>
        public int? Index { get; set; }
        /// <summary>Represents the raw values of the specified range. The data returned could be of type string, number, or a boolean. Cell that contain an error will return the error string.</summary>
        public ApiSdk.Models.Microsoft.Graph.Json Values { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.WorkbookTableRow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookTableRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"index", (o,n) => { (o as WorkbookTableRow).Index = n.GetIntValue(); } },
                {"values", (o,n) => { (o as WorkbookTableRow).Values = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Json>(ApiSdk.Models.Microsoft.Graph.Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("index", Index);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Json>("values", Values);
        }
    }
}
