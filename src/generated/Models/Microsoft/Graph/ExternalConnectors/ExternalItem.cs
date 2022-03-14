using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class ExternalItem : Entity, IParsable {
        /// <summary>An array of access control entries. Each entry specifies the access granted to a user or group. Required.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Acl> Acl { get; set; }
        /// <summary>A plain-text  representation of the contents of the item. The text in this property is full-text indexed. Optional.</summary>
        public ExternalItemContent Content { get; set; }
        /// <summary>A property bag with the properties of the item. The properties MUST conform to the schema defined for the externalConnection. Required.</summary>
        public ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Properties Properties { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExternalItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acl", (o,n) => { (o as ExternalItem).Acl = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Acl>(ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Acl.CreateFromDiscriminatorValue).ToList(); } },
                {"content", (o,n) => { (o as ExternalItem).Content = n.GetObjectValue<ExternalItemContent>(ExternalItemContent.CreateFromDiscriminatorValue); } },
                {"properties", (o,n) => { (o as ExternalItem).Properties = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Properties>(ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Properties.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Acl>("acl", Acl);
            writer.WriteObjectValue<ExternalItemContent>("content", Content);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ExternalConnectors.Properties>("properties", Properties);
        }
    }
}
