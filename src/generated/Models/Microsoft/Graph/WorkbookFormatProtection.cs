using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookFormatProtection : Entity, IParsable {
        /// <summary>Indicates if Excel hides the formula for the cells in the range. A null value indicates that the entire range doesn't have uniform formula hidden setting.</summary>
        public bool? FormulaHidden { get; set; }
        /// <summary>Indicates if Excel locks the cells in the object. A null value indicates that the entire range doesn't have uniform lock setting.</summary>
        public bool? Locked { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"formulaHidden", (o,n) => { (o as WorkbookFormatProtection).FormulaHidden = n.GetBoolValue(); } },
                {"locked", (o,n) => { (o as WorkbookFormatProtection).Locked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("formulaHidden", FormulaHidden);
            writer.WriteBoolValue("locked", Locked);
        }
    }
}
