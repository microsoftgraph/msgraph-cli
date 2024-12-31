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
    public partial class PolicyTemplate : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines an optional cross-tenant access policy template with user synchronization settings for a multitenant organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate? MultiTenantOrganizationIdentitySynchronization { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate MultiTenantOrganizationIdentitySynchronization { get; set; }
#endif
        /// <summary>Defines an optional cross-tenant access policy template with inbound and outbound partner configuration settings for a multitenant organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MultiTenantOrganizationPartnerConfigurationTemplate? MultiTenantOrganizationPartnerConfiguration { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MultiTenantOrganizationPartnerConfigurationTemplate MultiTenantOrganizationPartnerConfiguration { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PolicyTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PolicyTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PolicyTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "multiTenantOrganizationIdentitySynchronization", n => { MultiTenantOrganizationIdentitySynchronization = n.GetObjectValue<global::ApiSdk.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate>(global::ApiSdk.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate.CreateFromDiscriminatorValue); } },
                { "multiTenantOrganizationPartnerConfiguration", n => { MultiTenantOrganizationPartnerConfiguration = n.GetObjectValue<global::ApiSdk.Models.MultiTenantOrganizationPartnerConfigurationTemplate>(global::ApiSdk.Models.MultiTenantOrganizationPartnerConfigurationTemplate.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate>("multiTenantOrganizationIdentitySynchronization", MultiTenantOrganizationIdentitySynchronization);
            writer.WriteObjectValue<global::ApiSdk.Models.MultiTenantOrganizationPartnerConfigurationTemplate>("multiTenantOrganizationPartnerConfiguration", MultiTenantOrganizationPartnerConfiguration);
        }
    }
}
#pragma warning restore CS0618
