using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SchemaExtension : Entity, IParsable {
        /// <summary>Description for the schema extension. Supports $filter (eq).</summary>
        public string Description { get; set; }
        /// <summary>The appId of the application that is the owner of the schema extension. This property can be supplied on creation, to set the owner.  If not supplied, then the calling application's appId will be set as the owner. In either case, the signed-in user must be the owner of the application. So, for example, if creating a new schema extension definition using Graph Explorer, you must supply the owner property. Once set, this property is read-only and cannot be changed. Supports $filter (eq).</summary>
        public string Owner { get; set; }
        /// <summary>The collection of property names and types that make up the schema extension definition.</summary>
        public List<ExtensionSchemaProperty> Properties { get; set; }
        /// <summary>The lifecycle state of the schema extension. Possible states are InDevelopment, Available, and Deprecated. Automatically set to InDevelopment on creation. Schema extensions provides more information on the possible state transitions and behaviors. Supports $filter (eq).</summary>
        public string Status { get; set; }
        /// <summary>Set of Microsoft Graph types (that can support extensions) that the schema extension can be applied to. Select from administrativeUnit, contact, device, event, group, message, organization, post, or user.</summary>
        public List<string> TargetTypes { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as SchemaExtension).Description = n.GetStringValue(); } },
                {"owner", (o,n) => { (o as SchemaExtension).Owner = n.GetStringValue(); } },
                {"properties", (o,n) => { (o as SchemaExtension).Properties = n.GetCollectionOfObjectValues<ExtensionSchemaProperty>().ToList(); } },
                {"status", (o,n) => { (o as SchemaExtension).Status = n.GetStringValue(); } },
                {"targetTypes", (o,n) => { (o as SchemaExtension).TargetTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("owner", Owner);
            writer.WriteCollectionOfObjectValues<ExtensionSchemaProperty>("properties", Properties);
            writer.WriteStringValue("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("targetTypes", TargetTypes);
        }
    }
}
