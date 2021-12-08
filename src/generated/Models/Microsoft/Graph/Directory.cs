using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Directory : Entity, IParsable {
        /// <summary>Conceptual container for user and group directory objects.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AdministrativeUnit> AdministrativeUnits { get; set; }
        /// <summary>Recently deleted items. Read-only. Nullable.</summary>
        public List<DirectoryObject> DeletedItems { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"administrativeUnits", (o,n) => { (o as Directory).AdministrativeUnits = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AdministrativeUnit>().ToList(); } },
                {"deletedItems", (o,n) => { (o as Directory).DeletedItems = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AdministrativeUnit>("administrativeUnits", AdministrativeUnits);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("deletedItems", DeletedItems);
        }
    }
}
