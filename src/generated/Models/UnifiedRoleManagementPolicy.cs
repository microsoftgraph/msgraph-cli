using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the policyRoot singleton.</summary>
    public class UnifiedRoleManagementPolicy : Entity, IParsable {
        /// <summary>Description for the policy.</summary>
        public string Description { get; set; }
        /// <summary>Display name for the policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>The list of effective rules like approval rules and expiration rules evaluated based on inherited referenced rules. For example, if there is a tenant-wide policy to enforce enabling an approval rule, the effective rule will be to enable approval even if the policy has a rule to disable approval. Supports $expand.</summary>
        public List<UnifiedRoleManagementPolicyRule> EffectiveRules { get; set; }
        /// <summary>This can only be set to true for a single tenant-wide policy which will apply to all scopes and roles. Set the scopeId to / and scopeType to Directory. Supports $filter (eq, ne).</summary>
        public bool? IsOrganizationDefault { get; set; }
        /// <summary>The identity who last modified the role setting.</summary>
        public Identity LastModifiedBy { get; set; }
        /// <summary>The time when the role setting was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The collection of rules like approval rules and expiration rules. Supports $expand.</summary>
        public List<UnifiedRoleManagementPolicyRule> Rules { get; set; }
        /// <summary>The identifier of the scope where the policy is created. Can be / for the tenant or a group ID. Required.</summary>
        public string ScopeId { get; set; }
        /// <summary>The type of the scope where the policy is created. One of Directory, DirectoryRole. Required.</summary>
        public string ScopeType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"effectiveRules", n => { EffectiveRules = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>(UnifiedRoleManagementPolicyRule.CreateFromDiscriminatorValue).ToList(); } },
                {"isOrganizationDefault", n => { IsOrganizationDefault = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"rules", n => { Rules = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>(UnifiedRoleManagementPolicyRule.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>("effectiveRules", EffectiveRules);
            writer.WriteBoolValue("isOrganizationDefault", IsOrganizationDefault);
            writer.WriteObjectValue<Identity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>("rules", Rules);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}
