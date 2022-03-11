using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RoleAssignment : Entity, IParsable {
        /// <summary>Description of the Role Assignment.</summary>
        public string Description { get; set; }
        /// <summary>The display or friendly name of the role Assignment.</summary>
        public string DisplayName { get; set; }
        /// <summary>List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</summary>
        public List<string> ResourceScopes { get; set; }
        /// <summary>Role definition this assignment is part of.</summary>
        public ApiSdk.Models.Microsoft.Graph.RoleDefinition RoleDefinition { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as RoleAssignment).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as RoleAssignment).DisplayName = n.GetStringValue(); } },
                {"resourceScopes", (o,n) => { (o as RoleAssignment).ResourceScopes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"roleDefinition", (o,n) => { (o as RoleAssignment).RoleDefinition = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.RoleDefinition>(ApiSdk.Models.Microsoft.Graph.RoleDefinition.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("resourceScopes", ResourceScopes);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.RoleDefinition>("roleDefinition", RoleDefinition);
        }
    }
}
