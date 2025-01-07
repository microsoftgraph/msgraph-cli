// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.CallRecords;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Identity : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The display name of the identity.For drive items, the display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user don&apos;t show up as changed when using delta.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Unique identifier for the identity or actor. For example, in the access reviews decisions API, this property might record the id of the principal, that is, the group, user, or application that&apos;s subject to review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
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
        /// Instantiates a new <see cref="global::ApiSdk.Models.Identity"/> and sets the default values.
        /// </summary>
        public Identity()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Identity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.Identity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.azureCommunicationServicesUserIdentity" => new global::ApiSdk.Models.AzureCommunicationServicesUserIdentity(),
                "#microsoft.graph.callRecords.userIdentity" => new global::ApiSdk.Models.CallRecords.UserIdentity(),
                "#microsoft.graph.communicationsApplicationIdentity" => new global::ApiSdk.Models.CommunicationsApplicationIdentity(),
                "#microsoft.graph.communicationsApplicationInstanceIdentity" => new global::ApiSdk.Models.CommunicationsApplicationInstanceIdentity(),
                "#microsoft.graph.communicationsEncryptedIdentity" => new global::ApiSdk.Models.CommunicationsEncryptedIdentity(),
                "#microsoft.graph.communicationsGuestIdentity" => new global::ApiSdk.Models.CommunicationsGuestIdentity(),
                "#microsoft.graph.communicationsPhoneIdentity" => new global::ApiSdk.Models.CommunicationsPhoneIdentity(),
                "#microsoft.graph.communicationsUserIdentity" => new global::ApiSdk.Models.CommunicationsUserIdentity(),
                "#microsoft.graph.emailIdentity" => new global::ApiSdk.Models.EmailIdentity(),
                "#microsoft.graph.initiator" => new global::ApiSdk.Models.Initiator(),
                "#microsoft.graph.provisionedIdentity" => new global::ApiSdk.Models.ProvisionedIdentity(),
                "#microsoft.graph.provisioningServicePrincipal" => new global::ApiSdk.Models.ProvisioningServicePrincipal(),
                "#microsoft.graph.provisioningSystem" => new global::ApiSdk.Models.ProvisioningSystem(),
                "#microsoft.graph.servicePrincipalIdentity" => new global::ApiSdk.Models.ServicePrincipalIdentity(),
                "#microsoft.graph.sharePointIdentity" => new global::ApiSdk.Models.SharePointIdentity(),
                "#microsoft.graph.teamworkApplicationIdentity" => new global::ApiSdk.Models.TeamworkApplicationIdentity(),
                "#microsoft.graph.teamworkConversationIdentity" => new global::ApiSdk.Models.TeamworkConversationIdentity(),
                "#microsoft.graph.teamworkTagIdentity" => new global::ApiSdk.Models.TeamworkTagIdentity(),
                "#microsoft.graph.teamworkUserIdentity" => new global::ApiSdk.Models.TeamworkUserIdentity(),
                "#microsoft.graph.userIdentity" => new global::ApiSdk.Models.UserIdentity(),
                _ => new global::ApiSdk.Models.Identity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
