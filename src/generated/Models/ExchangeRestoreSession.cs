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
    public partial class ExchangeRestoreSession : global::ApiSdk.Models.RestoreSessionBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The granularMailboxRestoreArtifacts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.GranularMailboxRestoreArtifact>? GranularMailboxRestoreArtifacts { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.GranularMailboxRestoreArtifact> GranularMailboxRestoreArtifacts { get; set; }
#endif
        /// <summary>A collection of restore points and destination details that can be used to restore Exchange mailboxes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.MailboxRestoreArtifact>? MailboxRestoreArtifacts { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.MailboxRestoreArtifact> MailboxRestoreArtifacts { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ExchangeRestoreSession"/> and sets the default values.
        /// </summary>
        public ExchangeRestoreSession() : base()
        {
            OdataType = "#microsoft.graph.exchangeRestoreSession";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ExchangeRestoreSession"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ExchangeRestoreSession CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ExchangeRestoreSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "granularMailboxRestoreArtifacts", n => { GranularMailboxRestoreArtifacts = n.GetCollectionOfObjectValues<global::ApiSdk.Models.GranularMailboxRestoreArtifact>(global::ApiSdk.Models.GranularMailboxRestoreArtifact.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mailboxRestoreArtifacts", n => { MailboxRestoreArtifacts = n.GetCollectionOfObjectValues<global::ApiSdk.Models.MailboxRestoreArtifact>(global::ApiSdk.Models.MailboxRestoreArtifact.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.GranularMailboxRestoreArtifact>("granularMailboxRestoreArtifacts", GranularMailboxRestoreArtifacts);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.MailboxRestoreArtifact>("mailboxRestoreArtifacts", MailboxRestoreArtifacts);
        }
    }
}
#pragma warning restore CS0618
