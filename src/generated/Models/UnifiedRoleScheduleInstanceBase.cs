// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UnifiedRoleScheduleInstanceBase : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AppScope? AppScope { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AppScope AppScope { get; set; }
#endif
        /// <summary>Identifier of the app-specific scope when the assignment or role eligibility is scoped to an app. The scope of an assignment or role eligibility determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppScopeId { get; set; }
#nullable restore
#else
        public string AppScopeId { get; set; }
#endif
        /// <summary>The directory object that is the scope of the assignment or role eligibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DirectoryObject? DirectoryScope { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DirectoryObject DirectoryScope { get; set; }
#endif
        /// <summary>Identifier of the directory object representing the scope of the assignment or role eligibility. The scope of an assignment or role eligibility determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectoryScopeId { get; set; }
#nullable restore
#else
        public string DirectoryScopeId { get; set; }
#endif
        /// <summary>The principal that&apos;s getting a role assignment or role eligibility through the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DirectoryObject? Principal { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DirectoryObject Principal { get; set; }
#endif
        /// <summary>Identifier of the principal that has been granted the role assignment or that&apos;s eligible for a role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId { get; set; }
#nullable restore
#else
        public string PrincipalId { get; set; }
#endif
        /// <summary>Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.UnifiedRoleDefinition? RoleDefinition { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.UnifiedRoleDefinition RoleDefinition { get; set; }
#endif
        /// <summary>Identifier of the unifiedRoleDefinition object that is being assigned to the principal or that the principal is eligible for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId { get; set; }
#nullable restore
#else
        public string RoleDefinitionId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.UnifiedRoleScheduleInstanceBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.UnifiedRoleScheduleInstanceBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.unifiedRoleAssignmentScheduleInstance" => new global::ApiSdk.Models.UnifiedRoleAssignmentScheduleInstance(),
                "#microsoft.graph.unifiedRoleEligibilityScheduleInstance" => new global::ApiSdk.Models.UnifiedRoleEligibilityScheduleInstance(),
                _ => new global::ApiSdk.Models.UnifiedRoleScheduleInstanceBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appScope", n => { AppScope = n.GetObjectValue<global::ApiSdk.Models.AppScope>(global::ApiSdk.Models.AppScope.CreateFromDiscriminatorValue); } },
                { "appScopeId", n => { AppScopeId = n.GetStringValue(); } },
                { "directoryScope", n => { DirectoryScope = n.GetObjectValue<global::ApiSdk.Models.DirectoryObject>(global::ApiSdk.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "directoryScopeId", n => { DirectoryScopeId = n.GetStringValue(); } },
                { "principal", n => { Principal = n.GetObjectValue<global::ApiSdk.Models.DirectoryObject>(global::ApiSdk.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "principalId", n => { PrincipalId = n.GetStringValue(); } },
                { "roleDefinition", n => { RoleDefinition = n.GetObjectValue<global::ApiSdk.Models.UnifiedRoleDefinition>(global::ApiSdk.Models.UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                { "roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::ApiSdk.Models.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteObjectValue<global::ApiSdk.Models.DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteObjectValue<global::ApiSdk.Models.DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<global::ApiSdk.Models.UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
        }
    }
}
#pragma warning restore CS0618
