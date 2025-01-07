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
    public partial class ConnectedOrganization : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the connected organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of the connected organization. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The externalSponsors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DirectoryObject>? ExternalSponsors { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DirectoryObject> ExternalSponsors { get; set; }
#endif
        /// <summary>The identity sources in this connected organization, one of azureActiveDirectoryTenant, crossCloudAzureActiveDirectoryTenant, domainIdentitySource, externalDomainFederation, or socialIdentitySource. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IdentitySource>? IdentitySources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IdentitySource> IdentitySources { get; set; }
#endif
        /// <summary>The internalSponsors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DirectoryObject>? InternalSponsors { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DirectoryObject> InternalSponsors { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>The state of a connected organization defines whether assignment policies with requestor scope type AllConfiguredConnectedOrganizationSubjects are applicable or not.  The possible values are: configured, proposed, unknownFutureValue.</summary>
        public global::ApiSdk.Models.ConnectedOrganizationState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ConnectedOrganization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ConnectedOrganization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ConnectedOrganization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "externalSponsors", n => { ExternalSponsors = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DirectoryObject>(global::ApiSdk.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "identitySources", n => { IdentitySources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IdentitySource>(global::ApiSdk.Models.IdentitySource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "internalSponsors", n => { InternalSponsors = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DirectoryObject>(global::ApiSdk.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.ConnectedOrganizationState>(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DirectoryObject>("externalSponsors", ExternalSponsors);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IdentitySource>("identitySources", IdentitySources);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DirectoryObject>("internalSponsors", InternalSponsors);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.ConnectedOrganizationState>("state", State);
        }
    }
}
#pragma warning restore CS0618
