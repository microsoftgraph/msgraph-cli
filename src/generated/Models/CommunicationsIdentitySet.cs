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
    public partial class CommunicationsIdentitySet : global::ApiSdk.Models.IdentitySet, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The application instance associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Identity? ApplicationInstance { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Identity ApplicationInstance { get; set; }
#endif
        /// <summary>An identity the participant would like to present itself as to the other participants in the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Identity? AssertedIdentity { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Identity AssertedIdentity { get; set; }
#endif
        /// <summary>The Azure Communication Services user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Identity? AzureCommunicationServicesUser { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Identity AzureCommunicationServicesUser { get; set; }
#endif
        /// <summary>The encrypted user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Identity? Encrypted { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Identity Encrypted { get; set; }
#endif
        /// <summary>Type of endpoint that the participant uses. Possible values are: default, voicemail, skypeForBusiness, skypeForBusinessVoipPhone, unknownFutureValue.</summary>
        public global::ApiSdk.Models.EndpointType? EndpointType { get; set; }
        /// <summary>The guest user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Identity? Guest { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Identity Guest { get; set; }
#endif
        /// <summary>The Skype for Business on-premises user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Identity? OnPremises { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Identity OnPremises { get; set; }
#endif
        /// <summary>The phone user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Identity? Phone { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Identity Phone { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CommunicationsIdentitySet"/> and sets the default values.
        /// </summary>
        public CommunicationsIdentitySet() : base()
        {
            OdataType = "#microsoft.graph.communicationsIdentitySet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CommunicationsIdentitySet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.CommunicationsIdentitySet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CommunicationsIdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicationInstance", n => { ApplicationInstance = n.GetObjectValue<global::ApiSdk.Models.Identity>(global::ApiSdk.Models.Identity.CreateFromDiscriminatorValue); } },
                { "assertedIdentity", n => { AssertedIdentity = n.GetObjectValue<global::ApiSdk.Models.Identity>(global::ApiSdk.Models.Identity.CreateFromDiscriminatorValue); } },
                { "azureCommunicationServicesUser", n => { AzureCommunicationServicesUser = n.GetObjectValue<global::ApiSdk.Models.Identity>(global::ApiSdk.Models.Identity.CreateFromDiscriminatorValue); } },
                { "encrypted", n => { Encrypted = n.GetObjectValue<global::ApiSdk.Models.Identity>(global::ApiSdk.Models.Identity.CreateFromDiscriminatorValue); } },
                { "endpointType", n => { EndpointType = n.GetEnumValue<global::ApiSdk.Models.EndpointType>(); } },
                { "guest", n => { Guest = n.GetObjectValue<global::ApiSdk.Models.Identity>(global::ApiSdk.Models.Identity.CreateFromDiscriminatorValue); } },
                { "onPremises", n => { OnPremises = n.GetObjectValue<global::ApiSdk.Models.Identity>(global::ApiSdk.Models.Identity.CreateFromDiscriminatorValue); } },
                { "phone", n => { Phone = n.GetObjectValue<global::ApiSdk.Models.Identity>(global::ApiSdk.Models.Identity.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.Identity>("applicationInstance", ApplicationInstance);
            writer.WriteObjectValue<global::ApiSdk.Models.Identity>("assertedIdentity", AssertedIdentity);
            writer.WriteObjectValue<global::ApiSdk.Models.Identity>("azureCommunicationServicesUser", AzureCommunicationServicesUser);
            writer.WriteObjectValue<global::ApiSdk.Models.Identity>("encrypted", Encrypted);
            writer.WriteEnumValue<global::ApiSdk.Models.EndpointType>("endpointType", EndpointType);
            writer.WriteObjectValue<global::ApiSdk.Models.Identity>("guest", Guest);
            writer.WriteObjectValue<global::ApiSdk.Models.Identity>("onPremises", OnPremises);
            writer.WriteObjectValue<global::ApiSdk.Models.Identity>("phone", Phone);
        }
    }
}
#pragma warning restore CS0618
