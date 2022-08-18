using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>configuration Manager client enabled features</summary>
    public class ConfigurationManagerClientEnabledFeatures : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether compliance policy is managed by Intune</summary>
        public bool? CompliancePolicy { get; set; }
        /// <summary>Whether device configuration is managed by Intune</summary>
        public bool? DeviceConfiguration { get; set; }
        /// <summary>Whether inventory is managed by Intune</summary>
        public bool? Inventory { get; set; }
        /// <summary>Whether modern application is managed by Intune</summary>
        public bool? ModernApps { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Whether resource access is managed by Intune</summary>
        public bool? ResourceAccess { get; set; }
        /// <summary>Whether Windows Update for Business is managed by Intune</summary>
        public bool? WindowsUpdateForBusiness { get; set; }
        /// <summary>
        /// Instantiates a new configurationManagerClientEnabledFeatures and sets the default values.
        /// </summary>
        public ConfigurationManagerClientEnabledFeatures() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.configurationManagerClientEnabledFeatures";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConfigurationManagerClientEnabledFeatures CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigurationManagerClientEnabledFeatures();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"compliancePolicy", n => { CompliancePolicy = n.GetBoolValue(); } },
                {"deviceConfiguration", n => { DeviceConfiguration = n.GetBoolValue(); } },
                {"inventory", n => { Inventory = n.GetBoolValue(); } },
                {"modernApps", n => { ModernApps = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"resourceAccess", n => { ResourceAccess = n.GetBoolValue(); } },
                {"windowsUpdateForBusiness", n => { WindowsUpdateForBusiness = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("compliancePolicy", CompliancePolicy);
            writer.WriteBoolValue("deviceConfiguration", DeviceConfiguration);
            writer.WriteBoolValue("inventory", Inventory);
            writer.WriteBoolValue("modernApps", ModernApps);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("resourceAccess", ResourceAccess);
            writer.WriteBoolValue("windowsUpdateForBusiness", WindowsUpdateForBusiness);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
