using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SettingStateDeviceSummary : Entity, IParsable {
        /// <summary>Device Compliant count for the setting</summary>
        public int? CompliantDeviceCount { get; set; }
        /// <summary>Device conflict error count for the setting</summary>
        public int? ConflictDeviceCount { get; set; }
        /// <summary>Device error count for the setting</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Name of the InstancePath for the setting</summary>
        public string InstancePath { get; set; }
        /// <summary>Device NonCompliant count for the setting</summary>
        public int? NonCompliantDeviceCount { get; set; }
        /// <summary>Device Not Applicable count for the setting</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>Device Compliant count for the setting</summary>
        public int? RemediatedDeviceCount { get; set; }
        /// <summary>Name of the setting</summary>
        public string SettingName { get; set; }
        /// <summary>Device Unkown count for the setting</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"compliantDeviceCount", (o,n) => { (o as SettingStateDeviceSummary).CompliantDeviceCount = n.GetIntValue(); } },
                {"conflictDeviceCount", (o,n) => { (o as SettingStateDeviceSummary).ConflictDeviceCount = n.GetIntValue(); } },
                {"errorDeviceCount", (o,n) => { (o as SettingStateDeviceSummary).ErrorDeviceCount = n.GetIntValue(); } },
                {"instancePath", (o,n) => { (o as SettingStateDeviceSummary).InstancePath = n.GetStringValue(); } },
                {"nonCompliantDeviceCount", (o,n) => { (o as SettingStateDeviceSummary).NonCompliantDeviceCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", (o,n) => { (o as SettingStateDeviceSummary).NotApplicableDeviceCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", (o,n) => { (o as SettingStateDeviceSummary).RemediatedDeviceCount = n.GetIntValue(); } },
                {"settingName", (o,n) => { (o as SettingStateDeviceSummary).SettingName = n.GetStringValue(); } },
                {"unknownDeviceCount", (o,n) => { (o as SettingStateDeviceSummary).UnknownDeviceCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteStringValue("instancePath", InstancePath);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
