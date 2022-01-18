using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class Schema : Entity, IParsable {
        /// <summary>Must be set to microsoft.graph.externalItem. Required.</summary>
        public string BaseType { get; set; }
        /// <summary>The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.</summary>
        public List<Property> Properties { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"baseType", (o,n) => { (o as Schema).BaseType = n.GetStringValue(); } },
                {"properties", (o,n) => { (o as Schema).Properties = n.GetCollectionOfObjectValues<Property>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("baseType", BaseType);
            writer.WriteCollectionOfObjectValues<Property>("properties", Properties);
        }
    }
}
