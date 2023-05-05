using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.CallRecords {
    public class ClientUserAgent : UserAgent, IParsable {
        /// <summary>The unique identifier of the Azure AD application used by this endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureADAppId { get; set; }
#nullable restore
#else
        public string AzureADAppId { get; set; }
#endif
        /// <summary>Immutable resource identifier of the Azure Communication Service associated with this endpoint based on Communication Services APIs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommunicationServiceId { get; set; }
#nullable restore
#else
        public string CommunicationServiceId { get; set; }
#endif
        /// <summary>The platform property</summary>
        public ClientPlatform? Platform { get; set; }
        /// <summary>The productFamily property</summary>
        public ApiSdk.Models.CallRecords.ProductFamily? ProductFamily { get; set; }
        /// <summary>
        /// Instantiates a new ClientUserAgent and sets the default values.
        /// </summary>
        public ClientUserAgent() : base() {
            OdataType = "#microsoft.graph.callRecords.clientUserAgent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ClientUserAgent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClientUserAgent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureADAppId", n => { AzureADAppId = n.GetStringValue(); } },
                {"communicationServiceId", n => { CommunicationServiceId = n.GetStringValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<ClientPlatform>(); } },
                {"productFamily", n => { ProductFamily = n.GetEnumValue<ProductFamily>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureADAppId", AzureADAppId);
            writer.WriteStringValue("communicationServiceId", CommunicationServiceId);
            writer.WriteEnumValue<ClientPlatform>("platform", Platform);
            writer.WriteEnumValue<ProductFamily>("productFamily", ProductFamily);
        }
    }
}
