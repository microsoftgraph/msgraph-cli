using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SecurityVendorInformation : IAdditionalDataHolder, IParsable {
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
        /// <summary>Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider { get; set; }
#nullable restore
#else
        public string Provider { get; set; }
#endif
        /// <summary>Version of the provider or subprovider, if it exists, that generated the alert. Required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderVersion { get; set; }
#nullable restore
#else
        public string ProviderVersion { get; set; }
#endif
        /// <summary>Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubProvider { get; set; }
#nullable restore
#else
        public string SubProvider { get; set; }
#endif
        /// <summary>Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Vendor { get; set; }
#nullable restore
#else
        public string Vendor { get; set; }
#endif
        /// <summary>
        /// Instantiates a new securityVendorInformation and sets the default values.
        /// </summary>
        public SecurityVendorInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SecurityVendorInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityVendorInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"provider", n => { Provider = n.GetStringValue(); } },
                {"providerVersion", n => { ProviderVersion = n.GetStringValue(); } },
                {"subProvider", n => { SubProvider = n.GetStringValue(); } },
                {"vendor", n => { Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("providerVersion", ProviderVersion);
            writer.WriteStringValue("subProvider", SubProvider);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
