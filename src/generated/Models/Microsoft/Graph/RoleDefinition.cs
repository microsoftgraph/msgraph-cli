using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RoleDefinition : Entity, IParsable {
        /// <summary>Description of the Role definition.</summary>
        public string Description { get; set; }
        /// <summary>Display Name of the Role definition.</summary>
        public string DisplayName { get; set; }
        /// <summary>Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>List of Role assignments for this role definition.</summary>
        public List<RoleAssignment> RoleAssignments { get; set; }
        /// <summary>List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.</summary>
        public List<RolePermission> RolePermissions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as RoleDefinition).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as RoleDefinition).DisplayName = n.GetStringValue(); } },
                {"isBuiltIn", (o,n) => { (o as RoleDefinition).IsBuiltIn = n.GetBoolValue(); } },
                {"roleAssignments", (o,n) => { (o as RoleDefinition).RoleAssignments = n.GetCollectionOfObjectValues<RoleAssignment>().ToList(); } },
                {"rolePermissions", (o,n) => { (o as RoleDefinition).RolePermissions = n.GetCollectionOfObjectValues<RolePermission>().ToList(); } },
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
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteCollectionOfObjectValues<RoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<RolePermission>("rolePermissions", RolePermissions);
        }
    }
}
