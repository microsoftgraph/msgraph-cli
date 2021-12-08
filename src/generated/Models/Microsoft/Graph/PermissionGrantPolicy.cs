using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PermissionGrantPolicy : PolicyBase, IParsable {
        /// <summary>Condition sets which are excluded in this permission grant policy. Automatically expanded on GET.</summary>
        public List<PermissionGrantConditionSet> Excludes { get; set; }
        /// <summary>Condition sets which are included in this permission grant policy. Automatically expanded on GET.</summary>
        public List<PermissionGrantConditionSet> Includes { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"excludes", (o,n) => { (o as PermissionGrantPolicy).Excludes = n.GetCollectionOfObjectValues<PermissionGrantConditionSet>().ToList(); } },
                {"includes", (o,n) => { (o as PermissionGrantPolicy).Includes = n.GetCollectionOfObjectValues<PermissionGrantConditionSet>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PermissionGrantConditionSet>("excludes", Excludes);
            writer.WriteCollectionOfObjectValues<PermissionGrantConditionSet>("includes", Includes);
        }
    }
}
