using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to call the instantiate method.</summary>
    public class Endpoint : DirectoryObject, IParsable {
        /// <summary>The capability property</summary>
        public string Capability { get; set; }
        /// <summary>The providerId property</summary>
        public string ProviderId { get; set; }
        /// <summary>The providerName property</summary>
        public string ProviderName { get; set; }
        /// <summary>The providerResourceId property</summary>
        public string ProviderResourceId { get; set; }
        /// <summary>The uri property</summary>
        public string Uri { get; set; }
        /// <summary>
        /// Instantiates a new endpoint and sets the default values.
        /// </summary>
        public Endpoint() : base() {
            OdataType = "#microsoft.graph.endpoint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Endpoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Endpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"capability", n => { Capability = n.GetStringValue(); } },
                {"providerId", n => { ProviderId = n.GetStringValue(); } },
                {"providerName", n => { ProviderName = n.GetStringValue(); } },
                {"providerResourceId", n => { ProviderResourceId = n.GetStringValue(); } },
                {"uri", n => { Uri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("capability", Capability);
            writer.WriteStringValue("providerId", ProviderId);
            writer.WriteStringValue("providerName", ProviderName);
            writer.WriteStringValue("providerResourceId", ProviderResourceId);
            writer.WriteStringValue("uri", Uri);
        }
    }
}
