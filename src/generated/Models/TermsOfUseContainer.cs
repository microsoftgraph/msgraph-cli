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
    public partial class TermsOfUseContainer : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the current status of a user&apos;s response to a company&apos;s customizable terms of use agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AgreementAcceptance>? AgreementAcceptances { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AgreementAcceptance> AgreementAcceptances { get; set; }
#endif
        /// <summary>Represents a tenant&apos;s customizable terms of use agreement that&apos;s created and managed with Microsoft Entra ID Governance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Agreement>? Agreements { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Agreement> Agreements { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TermsOfUseContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.TermsOfUseContainer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TermsOfUseContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "agreementAcceptances", n => { AgreementAcceptances = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AgreementAcceptance>(global::ApiSdk.Models.AgreementAcceptance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "agreements", n => { Agreements = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Agreement>(global::ApiSdk.Models.Agreement.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AgreementAcceptance>("agreementAcceptances", AgreementAcceptances);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Agreement>("agreements", Agreements);
        }
    }
}
#pragma warning restore CS0618
