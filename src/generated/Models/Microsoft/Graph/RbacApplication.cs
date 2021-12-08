using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RbacApplication : Entity, IParsable {
        /// <summary>Resource to grant access to users or groups.</summary>
        public List<UnifiedRoleAssignment> RoleAssignments { get; set; }
        /// <summary>Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.</summary>
        public List<UnifiedRoleDefinition> RoleDefinitions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"roleAssignments", (o,n) => { (o as RbacApplication).RoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>().ToList(); } },
                {"roleDefinitions", (o,n) => { (o as RbacApplication).RoleDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<UnifiedRoleDefinition>("roleDefinitions", RoleDefinitions);
        }
    }
}
