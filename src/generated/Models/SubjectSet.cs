// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.Models.IdentityGovernance;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SubjectSet : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.SubjectSet"/> and sets the default values.
        /// </summary>
        public SubjectSet()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.SubjectSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.SubjectSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.attributeRuleMembers" => new global::ApiSdk.Models.AttributeRuleMembers(),
                "#microsoft.graph.connectedOrganizationMembers" => new global::ApiSdk.Models.ConnectedOrganizationMembers(),
                "#microsoft.graph.externalSponsors" => new global::ApiSdk.Models.ExternalSponsors(),
                "#microsoft.graph.groupMembers" => new global::ApiSdk.Models.GroupMembers(),
                "#microsoft.graph.identityGovernance.groupBasedSubjectSet" => new global::ApiSdk.Models.IdentityGovernance.GroupBasedSubjectSet(),
                "#microsoft.graph.identityGovernance.ruleBasedSubjectSet" => new global::ApiSdk.Models.IdentityGovernance.RuleBasedSubjectSet(),
                "#microsoft.graph.internalSponsors" => new global::ApiSdk.Models.InternalSponsors(),
                "#microsoft.graph.requestorManager" => new global::ApiSdk.Models.RequestorManager(),
                "#microsoft.graph.singleServicePrincipal" => new global::ApiSdk.Models.SingleServicePrincipal(),
                "#microsoft.graph.singleUser" => new global::ApiSdk.Models.SingleUser(),
                "#microsoft.graph.targetApplicationOwners" => new global::ApiSdk.Models.TargetApplicationOwners(),
                "#microsoft.graph.targetManager" => new global::ApiSdk.Models.TargetManager(),
                "#microsoft.graph.targetUserSponsors" => new global::ApiSdk.Models.TargetUserSponsors(),
                _ => new global::ApiSdk.Models.SubjectSet(),
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
