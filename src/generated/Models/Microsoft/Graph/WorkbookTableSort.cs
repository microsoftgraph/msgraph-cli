using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookTableSort : Entity, IParsable {
        /// <summary>Represents the current conditions used to last sort the table. Read-only.</summary>
        public List<WorkbookSortField> Fields { get; set; }
        /// <summary>Represents whether the casing impacted the last sort of the table. Read-only.</summary>
        public bool? MatchCase { get; set; }
        /// <summary>Represents Chinese character ordering method last used to sort the table. Possible values are: PinYin, StrokeCount. Read-only.</summary>
        public string Method { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"fields", (o,n) => { (o as WorkbookTableSort).Fields = n.GetCollectionOfObjectValues<WorkbookSortField>().ToList(); } },
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
            writer.WriteCollectionOfObjectValues<WorkbookSortField>("fields", Fields);
            writer.WriteBoolValue("matchCase", MatchCase);
            writer.WriteStringValue("method", Method);
        }
    }
}
