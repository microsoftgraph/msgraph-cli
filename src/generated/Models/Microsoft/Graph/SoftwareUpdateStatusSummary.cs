using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SoftwareUpdateStatusSummary : Entity, IParsable {
        /// <summary>Number of compliant devices.</summary>
        public int? CompliantDeviceCount { get; set; }
        /// <summary>Number of compliant users.</summary>
        public int? CompliantUserCount { get; set; }
        /// <summary>Number of conflict devices.</summary>
        public int? ConflictDeviceCount { get; set; }
        /// <summary>Number of conflict users.</summary>
        public int? ConflictUserCount { get; set; }
        /// <summary>The name of the policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>Number of devices had error.</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Number of users had error.</summary>
        public int? ErrorUserCount { get; set; }
        /// <summary>Number of non compliant devices.</summary>
        public int? NonCompliantDeviceCount { get; set; }
        /// <summary>Number of non compliant users.</summary>
        public int? NonCompliantUserCount { get; set; }
        /// <summary>Number of not applicable devices.</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>Number of not applicable users.</summary>
        public int? NotApplicableUserCount { get; set; }
        /// <summary>Number of remediated devices.</summary>
        public int? RemediatedDeviceCount { get; set; }
        /// <summary>Number of remediated users.</summary>
        public int? RemediatedUserCount { get; set; }
        /// <summary>Number of unknown devices.</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>Number of unknown users.</summary>
        public int? UnknownUserCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"compliantDeviceCount", (o,n) => { (o as SoftwareUpdateStatusSummary).CompliantDeviceCount = n.GetIntValue(); } },
                {"compliantUserCount", (o,n) => { (o as SoftwareUpdateStatusSummary).CompliantUserCount = n.GetIntValue(); } },
                {"conflictDeviceCount", (o,n) => { (o as SoftwareUpdateStatusSummary).ConflictDeviceCount = n.GetIntValue(); } },
                {"conflictUserCount", (o,n) => { (o as SoftwareUpdateStatusSummary).ConflictUserCount = n.GetIntValue(); } },
                {"displayName", (o,n) => { (o as SoftwareUpdateStatusSummary).DisplayName = n.GetStringValue(); } },
                {"errorDeviceCount", (o,n) => { (o as SoftwareUpdateStatusSummary).ErrorDeviceCount = n.GetIntValue(); } },
                {"errorUserCount", (o,n) => { (o as SoftwareUpdateStatusSummary).ErrorUserCount = n.GetIntValue(); } },
                {"nonCompliantDeviceCount", (o,n) => { (o as SoftwareUpdateStatusSummary).NonCompliantDeviceCount = n.GetIntValue(); } },
                {"nonCompliantUserCount", (o,n) => { (o as SoftwareUpdateStatusSummary).NonCompliantUserCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", (o,n) => { (o as SoftwareUpdateStatusSummary).NotApplicableDeviceCount = n.GetIntValue(); } },
                {"notApplicableUserCount", (o,n) => { (o as SoftwareUpdateStatusSummary).NotApplicableUserCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", (o,n) => { (o as SoftwareUpdateStatusSummary).RemediatedDeviceCount = n.GetIntValue(); } },
                {"remediatedUserCount", (o,n) => { (o as SoftwareUpdateStatusSummary).RemediatedUserCount = n.GetIntValue(); } },
                {"unknownDeviceCount", (o,n) => { (o as SoftwareUpdateStatusSummary).UnknownDeviceCount = n.GetIntValue(); } },
                {"unknownUserCount", (o,n) => { (o as SoftwareUpdateStatusSummary).UnknownUserCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("compliantUserCount", CompliantUserCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("conflictUserCount", ConflictUserCount);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("errorUserCount", ErrorUserCount);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("nonCompliantUserCount", NonCompliantUserCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("notApplicableUserCount", NotApplicableUserCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteIntValue("remediatedUserCount", RemediatedUserCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
            writer.WriteIntValue("unknownUserCount", UnknownUserCount);
        }
    }
}
