using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConfigurationManagerClientEnabledFeatures : IParsable {
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
        /// <summary>Whether resource access is managed by Intune</summary>
        public bool? ResourceAccess { get; set; }
        /// <summary>Whether Windows Update for Business is managed by Intune</summary>
        public bool? WindowsUpdateForBusiness { get; set; }
        /// <summary>
        /// Instantiates a new configurationManagerClientEnabledFeatures and sets the default values.
        /// </summary>
        public ConfigurationManagerClientEnabledFeatures() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"compliancePolicy", (o,n) => { (o as ConfigurationManagerClientEnabledFeatures).CompliancePolicy = n.GetBoolValue(); } },
                {"deviceConfiguration", (o,n) => { (o as ConfigurationManagerClientEnabledFeatures).DeviceConfiguration = n.GetBoolValue(); } },
                {"inventory", (o,n) => { (o as ConfigurationManagerClientEnabledFeatures).Inventory = n.GetBoolValue(); } },
                {"modernApps", (o,n) => { (o as ConfigurationManagerClientEnabledFeatures).ModernApps = n.GetBoolValue(); } },
                {"resourceAccess", (o,n) => { (o as ConfigurationManagerClientEnabledFeatures).ResourceAccess = n.GetBoolValue(); } },
                {"windowsUpdateForBusiness", (o,n) => { (o as ConfigurationManagerClientEnabledFeatures).WindowsUpdateForBusiness = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("resourceAccess", ResourceAccess);
            writer.WriteBoolValue("windowsUpdateForBusiness", WindowsUpdateForBusiness);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
