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
    public partial class TenantRelationship : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The customer who has a delegated admin relationship with a Microsoft partner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DelegatedAdminCustomer>? DelegatedAdminCustomers { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DelegatedAdminCustomer> DelegatedAdminCustomers { get; set; }
#endif
        /// <summary>The details of the delegated administrative privileges that a Microsoft partner has in a customer tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DelegatedAdminRelationship>? DelegatedAdminRelationships { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DelegatedAdminRelationship> DelegatedAdminRelationships { get; set; }
#endif
        /// <summary>Defines an organization with more than one instance of Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MultiTenantOrganization? MultiTenantOrganization { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MultiTenantOrganization MultiTenantOrganization { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.TenantRelationship"/> and sets the default values.
        /// </summary>
        public TenantRelationship()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TenantRelationship"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.TenantRelationship CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TenantRelationship();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "delegatedAdminCustomers", n => { DelegatedAdminCustomers = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DelegatedAdminCustomer>(global::ApiSdk.Models.DelegatedAdminCustomer.CreateFromDiscriminatorValue)?.AsList(); } },
                { "delegatedAdminRelationships", n => { DelegatedAdminRelationships = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DelegatedAdminRelationship>(global::ApiSdk.Models.DelegatedAdminRelationship.CreateFromDiscriminatorValue)?.AsList(); } },
                { "multiTenantOrganization", n => { MultiTenantOrganization = n.GetObjectValue<global::ApiSdk.Models.MultiTenantOrganization>(global::ApiSdk.Models.MultiTenantOrganization.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DelegatedAdminCustomer>("delegatedAdminCustomers", DelegatedAdminCustomers);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DelegatedAdminRelationship>("delegatedAdminRelationships", DelegatedAdminRelationships);
            writer.WriteObjectValue<global::ApiSdk.Models.MultiTenantOrganization>("multiTenantOrganization", MultiTenantOrganization);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
