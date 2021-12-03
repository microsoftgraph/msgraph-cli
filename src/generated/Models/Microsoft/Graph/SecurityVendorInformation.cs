using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SecurityVendorInformation : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.</summary>
        public string Provider { get; set; }
        /// <summary>Version of the provider or subprovider, if it exists, that generated the alert. Required</summary>
        public string ProviderVersion { get; set; }
        /// <summary>Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.</summary>
        public string SubProvider { get; set; }
        /// <summary>Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required</summary>
        public string Vendor { get; set; }
        /// <summary>
        /// Instantiates a new securityVendorInformation and sets the default values.
        /// </summary>
        public SecurityVendorInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"provider", (o,n) => { (o as SecurityVendorInformation).Provider = n.GetStringValue(); } },
                {"providerVersion", (o,n) => { (o as SecurityVendorInformation).ProviderVersion = n.GetStringValue(); } },
                {"subProvider", (o,n) => { (o as SecurityVendorInformation).SubProvider = n.GetStringValue(); } },
                {"vendor", (o,n) => { (o as SecurityVendorInformation).Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("providerVersion", ProviderVersion);
            writer.WriteStringValue("subProvider", SubProvider);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
