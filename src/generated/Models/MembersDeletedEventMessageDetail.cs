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
    public partial class MembersDeletedEventMessageDetail : global::ApiSdk.Models.EventMessageDetail, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? Initiator { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet Initiator { get; set; }
#endif
        /// <summary>List of members deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TeamworkUserIdentity>? Members { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TeamworkUserIdentity> Members { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.MembersDeletedEventMessageDetail"/> and sets the default values.
        /// </summary>
        public MembersDeletedEventMessageDetail() : base()
        {
            OdataType = "#microsoft.graph.membersDeletedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.MembersDeletedEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.MembersDeletedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.MembersDeletedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "initiator", n => { Initiator = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TeamworkUserIdentity>(global::ApiSdk.Models.TeamworkUserIdentity.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("initiator", Initiator);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TeamworkUserIdentity>("members", Members);
        }
    }
}
#pragma warning restore CS0618
