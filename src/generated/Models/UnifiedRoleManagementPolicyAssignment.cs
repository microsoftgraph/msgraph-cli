using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the policyRoot singleton.</summary>
    public class UnifiedRoleManagementPolicyAssignment : Entity, IParsable {
        /// <summary>The policy for the assignment.</summary>
        public UnifiedRoleManagementPolicy Policy { get; set; }
        /// <summary>The id of the policy.</summary>
        public string PolicyId { get; set; }
        /// <summary>The id of the role definition where the policy applies. If not specified, the policy applies to all roles.</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>The id of the scope where the policy is assigned. E.g. &apos;/&apos;, groupId, etc.</summary>
        public string ScopeId { get; set; }
        /// <summary>The type of the scope where the policy is assigned. One of Directory, DirectoryRole, Group.</summary>
        public string ScopeType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleManagementPolicyAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"policy", n => { Policy = n.GetObjectValue<UnifiedRoleManagementPolicy>(UnifiedRoleManagementPolicy.CreateFromDiscriminatorValue); } },
                {"policyId", n => { PolicyId = n.GetStringValue(); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"scopeId", n => { ScopeId = n.GetStringValue(); } },
                {"scopeType", n => { ScopeType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UnifiedRoleManagementPolicy>("policy", Policy);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}
