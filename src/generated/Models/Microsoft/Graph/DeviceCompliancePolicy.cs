using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceCompliancePolicy : Entity, IParsable {
        /// <summary>The collection of assignments for this compliance policy.</summary>
        public List<DeviceCompliancePolicyAssignment> Assignments { get; set; }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description { get; set; }
        /// <summary>Compliance Setting State Device Summary</summary>
        public List<SettingStateDeviceSummary> DeviceSettingStateSummaries { get; set; }
        /// <summary>List of DeviceComplianceDeviceStatus.</summary>
        public List<DeviceComplianceDeviceStatus> DeviceStatuses { get; set; }
        /// <summary>Device compliance devices status overview</summary>
        public DeviceComplianceDeviceOverview DeviceStatusOverview { get; set; }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The list of scheduled action for this rule</summary>
        public List<DeviceComplianceScheduledActionForRule> ScheduledActionsForRule { get; set; }
        /// <summary>List of DeviceComplianceUserStatus.</summary>
        public List<DeviceComplianceUserStatus> UserStatuses { get; set; }
        /// <summary>Device compliance users status overview</summary>
        public DeviceComplianceUserOverview UserStatusOverview { get; set; }
        /// <summary>Version of the device configuration.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceCompliancePolicy).Assignments = n.GetCollectionOfObjectValues<DeviceCompliancePolicyAssignment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceCompliancePolicy).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceCompliancePolicy).Description = n.GetStringValue(); } },
                {"deviceSettingStateSummaries", (o,n) => { (o as DeviceCompliancePolicy).DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<SettingStateDeviceSummary>().ToList(); } },
                {"deviceStatuses", (o,n) => { (o as DeviceCompliancePolicy).DeviceStatuses = n.GetCollectionOfObjectValues<DeviceComplianceDeviceStatus>().ToList(); } },
                {"deviceStatusOverview", (o,n) => { (o as DeviceCompliancePolicy).DeviceStatusOverview = n.GetObjectValue<DeviceComplianceDeviceOverview>(); } },
                {"displayName", (o,n) => { (o as DeviceCompliancePolicy).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceCompliancePolicy).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"scheduledActionsForRule", (o,n) => { (o as DeviceCompliancePolicy).ScheduledActionsForRule = n.GetCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>().ToList(); } },
                {"userStatuses", (o,n) => { (o as DeviceCompliancePolicy).UserStatuses = n.GetCollectionOfObjectValues<DeviceComplianceUserStatus>().ToList(); } },
                {"userStatusOverview", (o,n) => { (o as DeviceCompliancePolicy).UserStatusOverview = n.GetObjectValue<DeviceComplianceUserOverview>(); } },
                {"version", (o,n) => { (o as DeviceCompliancePolicy).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicyAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<SettingStateDeviceSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceComplianceDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<DeviceComplianceDeviceOverview>("deviceStatusOverview", DeviceStatusOverview);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>("scheduledActionsForRule", ScheduledActionsForRule);
            writer.WriteCollectionOfObjectValues<DeviceComplianceUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<DeviceComplianceUserOverview>("userStatusOverview", UserStatusOverview);
            writer.WriteIntValue("version", Version);
        }
    }
}
