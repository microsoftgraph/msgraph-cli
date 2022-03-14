using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UnifiedRoleDefinition : Entity, IParsable {
        /// <summary>The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq and startsWith operators only).</summary>
        public string DisplayName { get; set; }
        /// <summary>Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute.</summary>
        public List<UnifiedRoleDefinition> InheritsPermissionsFrom { get; set; }
        /// <summary>Flag indicating if the unifiedRoleDefinition is part of the default set included with the product or custom. Read-only.  Supports $filter (eq operator only).</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>List of scopes permissions granted by the role definition apply to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment</summary>
        public List<string> ResourceScopes { get; set; }
        /// <summary>List of permissions included in the role. Read-only when isBuiltIn is true. Required.</summary>
        public List<UnifiedRolePermission> RolePermissions { get; set; }
        /// <summary>Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true.</summary>
        public string TemplateId { get; set; }
        /// <summary>Indicates version of the unifiedRoleDefinition. Read-only when isBuiltIn is true.</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as UnifiedRoleDefinition).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as UnifiedRoleDefinition).DisplayName = n.GetStringValue(); } },
                {"inheritsPermissionsFrom", (o,n) => { (o as UnifiedRoleDefinition).InheritsPermissionsFrom = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"isBuiltIn", (o,n) => { (o as UnifiedRoleDefinition).IsBuiltIn = n.GetBoolValue(); } },
                {"isEnabled", (o,n) => { (o as UnifiedRoleDefinition).IsEnabled = n.GetBoolValue(); } },
                {"resourceScopes", (o,n) => { (o as UnifiedRoleDefinition).ResourceScopes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"rolePermissions", (o,n) => { (o as UnifiedRoleDefinition).RolePermissions = n.GetCollectionOfObjectValues<UnifiedRolePermission>(UnifiedRolePermission.CreateFromDiscriminatorValue).ToList(); } },
                {"templateId", (o,n) => { (o as UnifiedRoleDefinition).TemplateId = n.GetStringValue(); } },
                {"version", (o,n) => { (o as UnifiedRoleDefinition).Version = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<UnifiedRoleDefinition>("inheritsPermissionsFrom", InheritsPermissionsFrom);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("resourceScopes", ResourceScopes);
            writer.WriteCollectionOfObjectValues<UnifiedRolePermission>("rolePermissions", RolePermissions);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteStringValue("version", Version);
        }
    }
}
