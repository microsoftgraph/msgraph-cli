using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceCompliancePolicy : Entity, IParsable {
        /// <summary>The collection of assignments for this compliance policy.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicyAssignment> Assignments { get; set; }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description { get; set; }
        /// <summary>Compliance Setting State Device Summary</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SettingStateDeviceSummary> DeviceSettingStateSummaries { get; set; }
        /// <summary>List of DeviceComplianceDeviceStatus.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceComplianceDeviceStatus> DeviceStatuses { get; set; }
        /// <summary>Device compliance devices status overview</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceComplianceDeviceOverview DeviceStatusOverview { get; set; }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceComplianceScheduledActionForRule> ScheduledActionsForRule { get; set; }
        /// <summary>List of DeviceComplianceUserStatus.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceComplianceUserStatus> UserStatuses { get; set; }
        /// <summary>Device compliance users status overview</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceComplianceUserOverview UserStatusOverview { get; set; }
        /// <summary>Version of the device configuration.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceCompliancePolicy).Assignments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicyAssignment>(ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceCompliancePolicy).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceCompliancePolicy).Description = n.GetStringValue(); } },
                {"deviceSettingStateSummaries", (o,n) => { (o as DeviceCompliancePolicy).DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SettingStateDeviceSummary>(ApiSdk.Models.Microsoft.Graph.SettingStateDeviceSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatuses", (o,n) => { (o as DeviceCompliancePolicy).DeviceStatuses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceComplianceDeviceStatus>(ApiSdk.Models.Microsoft.Graph.DeviceComplianceDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatusOverview", (o,n) => { (o as DeviceCompliancePolicy).DeviceStatusOverview = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceComplianceDeviceOverview>(ApiSdk.Models.Microsoft.Graph.DeviceComplianceDeviceOverview.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as DeviceCompliancePolicy).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceCompliancePolicy).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"scheduledActionsForRule", (o,n) => { (o as DeviceCompliancePolicy).ScheduledActionsForRule = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceComplianceScheduledActionForRule>(ApiSdk.Models.Microsoft.Graph.DeviceComplianceScheduledActionForRule.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatuses", (o,n) => { (o as DeviceCompliancePolicy).UserStatuses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceComplianceUserStatus>(ApiSdk.Models.Microsoft.Graph.DeviceComplianceUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatusOverview", (o,n) => { (o as DeviceCompliancePolicy).UserStatusOverview = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceComplianceUserOverview>(ApiSdk.Models.Microsoft.Graph.DeviceComplianceUserOverview.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceCompliancePolicyAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SettingStateDeviceSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceComplianceDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceComplianceDeviceOverview>("deviceStatusOverview", DeviceStatusOverview);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceComplianceScheduledActionForRule>("scheduledActionsForRule", ScheduledActionsForRule);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceComplianceUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceComplianceUserOverview>("userStatusOverview", UserStatusOverview);
            writer.WriteIntValue("version", Version);
        }
    }
}
