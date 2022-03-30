using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class Schema : Entity, IParsable {
        /// <summary>Must be set to microsoft.graph.externalConnector.externalItem. Required.</summary>
        public string BaseType { get; set; }
        /// <summary>The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Property> Properties { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Schema CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Schema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"baseType", (o,n) => { (o as Schema).BaseType = n.GetStringValue(); } },
                {"properties", (o,n) => { (o as Schema).Properties = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Property>(ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Property.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Property>("properties", Properties);
        }
    }
}
