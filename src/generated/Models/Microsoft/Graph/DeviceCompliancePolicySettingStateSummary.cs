using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceCompliancePolicySettingStateSummary : Entity, IParsable {
        /// <summary>Number of compliant devices</summary>
        public int? CompliantDeviceCount { get; set; }
        /// <summary>Number of conflict devices</summary>
        public int? ConflictDeviceCount { get; set; }
        /// <summary>Not yet documented</summary>
        public List<DeviceComplianceSettingState> DeviceComplianceSettingStates { get; set; }
        /// <summary>Number of error devices</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Number of NonCompliant devices</summary>
        public int? NonCompliantDeviceCount { get; set; }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>Setting platform. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, windows10XProfile, androidAOSP, all.</summary>
        public PolicyPlatformType? PlatformType { get; set; }
        /// <summary>Number of remediated devices</summary>
        public int? RemediatedDeviceCount { get; set; }
        /// <summary>The setting class name and property name.</summary>
        public string Setting { get; set; }
        /// <summary>Name of the setting.</summary>
        public string SettingName { get; set; }
        /// <summary>Number of unknown devices</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"compliantDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).CompliantDeviceCount = n.GetIntValue(); } },
                {"conflictDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).ConflictDeviceCount = n.GetIntValue(); } },
                {"deviceComplianceSettingStates", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).DeviceComplianceSettingStates = n.GetCollectionOfObjectValues<DeviceComplianceSettingState>().ToList(); } },
                {"errorDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).ErrorDeviceCount = n.GetIntValue(); } },
                {"nonCompliantDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).NonCompliantDeviceCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).NotApplicableDeviceCount = n.GetIntValue(); } },
                {"platformType", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"remediatedDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).RemediatedDeviceCount = n.GetIntValue(); } },
                {"setting", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).Setting = n.GetStringValue(); } },
                {"settingName", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).SettingName = n.GetStringValue(); } },
                {"unknownDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteCollectionOfObjectValues<DeviceComplianceSettingState>("deviceComplianceSettingStates", DeviceComplianceSettingStates);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
