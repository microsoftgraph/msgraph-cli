using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceConfigurationState : Entity, IParsable {
        /// <summary>The name of the policy for this policyBase</summary>
        public string DisplayName { get; set; }
        /// <summary>Platform type that the policy applies to</summary>
        public PolicyPlatformType? PlatformType { get; set; }
        /// <summary>Count of how many setting a policy holds</summary>
        public int? SettingCount { get; set; }
        public List<DeviceConfigurationSettingState> SettingStates { get; set; }
        /// <summary>The compliance state of the policy</summary>
        public ComplianceStatus? State { get; set; }
        /// <summary>The version of the policy</summary>
        public int? Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as DeviceConfigurationState).DisplayName = n.GetStringValue(); } },
                {"platformType", (o,n) => { (o as DeviceConfigurationState).PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"settingCount", (o,n) => { (o as DeviceConfigurationState).SettingCount = n.GetIntValue(); } },
                {"settingStates", (o,n) => { (o as DeviceConfigurationState).SettingStates = n.GetCollectionOfObjectValues<DeviceConfigurationSettingState>().ToList(); } },
                {"state", (o,n) => { (o as DeviceConfigurationState).State = n.GetEnumValue<ComplianceStatus>(); } },
                {"version", (o,n) => { (o as DeviceConfigurationState).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteIntValue("settingCount", SettingCount);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationSettingState>("settingStates", SettingStates);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteIntValue("version", Version);
        }
    }
}
