using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class RoleDefinition : Entity, IParsable {
        /// <summary>Description of the Role definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Display Name of the Role definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>List of Role assignments for this role definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RoleAssignment>? RoleAssignments { get; set; }
#nullable restore
#else
        public List<RoleAssignment> RoleAssignments { get; set; }
#endif
        /// <summary>List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RolePermission>? RolePermissions { get; set; }
#nullable restore
#else
        public List<RolePermission> RolePermissions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new RoleDefinition CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new RoleDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceAndAppManagementRoleDefinition" => new DeviceAndAppManagementRoleDefinition(),
                _ => new RoleDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<RoleAssignment>(RoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"rolePermissions", n => { RolePermissions = n.GetCollectionOfObjectValues<RolePermission>(RolePermission.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
