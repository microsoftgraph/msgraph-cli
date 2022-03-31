using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookTableSort : Entity, IParsable {
        /// <summary>Represents the current conditions used to last sort the table. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookSortField> Fields { get; set; }
        /// <summary>Represents whether the casing impacted the last sort of the table. Read-only.</summary>
        public bool? MatchCase { get; set; }
        /// <summary>Represents Chinese character ordering method last used to sort the table. The possible values are: PinYin, StrokeCount. Read-only.</summary>
        public string Method { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.WorkbookTableSort CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookTableSort();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"fields", (o,n) => { (o as WorkbookTableSort).Fields = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookSortField>(ApiSdk.Models.Microsoft.Graph.WorkbookSortField.CreateFromDiscriminatorValue).ToList(); } },
                {"matchCase", (o,n) => { (o as WorkbookTableSort).MatchCase = n.GetBoolValue(); } },
                {"method", (o,n) => { (o as WorkbookTableSort).Method = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookSortField>("fields", Fields);
            writer.WriteBoolValue("matchCase", MatchCase);
            writer.WriteStringValue("method", Method);
        }
    }
}
