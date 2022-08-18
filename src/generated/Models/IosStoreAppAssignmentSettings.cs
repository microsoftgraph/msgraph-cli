using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class IosStoreAppAssignmentSettings : MobileAppAssignmentSettings, IParsable {
        /// <summary>The VPN Configuration Id to apply for this app.</summary>
        public string VpnConfigurationId { get; set; }
        /// <summary>
        /// Instantiates a new IosStoreAppAssignmentSettings and sets the default values.
        /// </summary>
        public IosStoreAppAssignmentSettings() : base() {
            OdataType = "#microsoft.graph.iosStoreAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosStoreAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosStoreAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"vpnConfigurationId", n => { VpnConfigurationId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("vpnConfigurationId", VpnConfigurationId);
        }
    }
}
