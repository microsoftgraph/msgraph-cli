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
    public partial class AccessPackageCatalog : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The access packages in this catalog. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AccessPackage>? AccessPackages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AccessPackage> AccessPackages { get; set; }
#endif
        /// <summary>Whether the catalog is created by a user or entitlement management. The possible values are: userManaged, serviceDefault, serviceManaged, unknownFutureValue.</summary>
        public global::ApiSdk.Models.AccessPackageCatalogType? CatalogType { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The customWorkflowExtensions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CustomCalloutExtension>? CustomWorkflowExtensions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CustomCalloutExtension> CustomWorkflowExtensions { get; set; }
#endif
        /// <summary>The description of the access package catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of the access package catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Whether the access packages in this catalog can be requested by users outside of the tenant.</summary>
        public bool? IsExternallyVisible { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>The resourceRoles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AccessPackageResourceRole>? ResourceRoles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AccessPackageResourceRole> ResourceRoles { get; set; }
#endif
        /// <summary>Access package resources in this catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AccessPackageResource>? Resources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AccessPackageResource> Resources { get; set; }
#endif
        /// <summary>The resourceScopes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AccessPackageResourceScope>? ResourceScopes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AccessPackageResourceScope> ResourceScopes { get; set; }
#endif
        /// <summary>Has the value published if the access packages are available for management. The possible values are: unpublished, published, unknownFutureValue.</summary>
        public global::ApiSdk.Models.AccessPackageCatalogState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AccessPackageCatalog"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.AccessPackageCatalog CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AccessPackageCatalog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackages", n => { AccessPackages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AccessPackage>(global::ApiSdk.Models.AccessPackage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "catalogType", n => { CatalogType = n.GetEnumValue<global::ApiSdk.Models.AccessPackageCatalogType>(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customWorkflowExtensions", n => { CustomWorkflowExtensions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CustomCalloutExtension>(global::ApiSdk.Models.CustomCalloutExtension.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isExternallyVisible", n => { IsExternallyVisible = n.GetBoolValue(); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "resourceRoles", n => { ResourceRoles = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceRole>(global::ApiSdk.Models.AccessPackageResourceRole.CreateFromDiscriminatorValue)?.AsList(); } },
                { "resourceScopes", n => { ResourceScopes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceScope>(global::ApiSdk.Models.AccessPackageResourceScope.CreateFromDiscriminatorValue)?.AsList(); } },
                { "resources", n => { Resources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResource>(global::ApiSdk.Models.AccessPackageResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.AccessPackageCatalogState>(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AccessPackage>("accessPackages", AccessPackages);
            writer.WriteEnumValue<global::ApiSdk.Models.AccessPackageCatalogType>("catalogType", CatalogType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CustomCalloutExtension>("customWorkflowExtensions", CustomWorkflowExtensions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isExternallyVisible", IsExternallyVisible);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceRole>("resourceRoles", ResourceRoles);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AccessPackageResourceScope>("resourceScopes", ResourceScopes);
            writer.WriteEnumValue<global::ApiSdk.Models.AccessPackageCatalogState>("state", State);
        }
    }
}
#pragma warning restore CS0618
