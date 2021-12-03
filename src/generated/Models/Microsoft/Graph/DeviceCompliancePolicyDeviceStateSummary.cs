using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceCompliancePolicyDeviceStateSummary : Entity, IParsable {
        /// <summary>Number of compliant devices</summary>
        public int? CompliantDeviceCount { get; set; }
        /// <summary>Number of devices that have compliance managed by System Center Configuration Manager</summary>
        public int? ConfigManagerCount { get; set; }
        /// <summary>Number of conflict devices</summary>
        public int? ConflictDeviceCount { get; set; }
        /// <summary>Number of error devices</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Number of devices that are in grace period</summary>
        public int? InGracePeriodCount { get; set; }
        /// <summary>Number of NonCompliant devices</summary>
        public int? NonCompliantDeviceCount { get; set; }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>Number of remediated devices</summary>
        public int? RemediatedDeviceCount { get; set; }
        /// <summary>Number of unknown devices</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"compliantDeviceCount", (o,n) => { (o as DeviceCompliancePolicyDeviceStateSummary).CompliantDeviceCount = n.GetIntValue(); } },
                {"configManagerCount", (o,n) => { (o as DeviceCompliancePolicyDeviceStateSummary).ConfigManagerCount = n.GetIntValue(); } },
                {"conflictDeviceCount", (o,n) => { (o as DeviceCompliancePolicyDeviceStateSummary).ConflictDeviceCount = n.GetIntValue(); } },
                {"errorDeviceCount", (o,n) => { (o as DeviceCompliancePolicyDeviceStateSummary).ErrorDeviceCount = n.GetIntValue(); } },
                {"inGracePeriodCount", (o,n) => { (o as DeviceCompliancePolicyDeviceStateSummary).InGracePeriodCount = n.GetIntValue(); } },
                {"nonCompliantDeviceCount", (o,n) => { (o as DeviceCompliancePolicyDeviceStateSummary).NonCompliantDeviceCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", (o,n) => { (o as DeviceCompliancePolicyDeviceStateSummary).NotApplicableDeviceCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", (o,n) => { (o as DeviceCompliancePolicyDeviceStateSummary).RemediatedDeviceCount = n.GetIntValue(); } },
                {"unknownDeviceCount", (o,n) => { (o as DeviceCompliancePolicyDeviceStateSummary).UnknownDeviceCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("configManagerCount", ConfigManagerCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("inGracePeriodCount", InGracePeriodCount);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
