using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceConfiguration : Entity, IParsable {
        /// <summary>The list of assignments for the device configuration profile.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationAssignment> Assignments { get; set; }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description { get; set; }
        /// <summary>Device Configuration Setting State Device Summary</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SettingStateDeviceSummary> DeviceSettingStateSummaries { get; set; }
        /// <summary>Device configuration installation status by device.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceStatus> DeviceStatuses { get; set; }
        /// <summary>Device Configuration devices status overview</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceOverview DeviceStatusOverview { get; set; }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Device configuration installation status by user.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationUserStatus> UserStatuses { get; set; }
        /// <summary>Device Configuration users status overview</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceConfigurationUserOverview UserStatusOverview { get; set; }
        /// <summary>Version of the device configuration.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.DeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceConfiguration).Assignments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationAssignment>(ApiSdk.Models.Microsoft.Graph.DeviceConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceConfiguration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceConfiguration).Description = n.GetStringValue(); } },
                {"deviceSettingStateSummaries", (o,n) => { (o as DeviceConfiguration).DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SettingStateDeviceSummary>(ApiSdk.Models.Microsoft.Graph.SettingStateDeviceSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatuses", (o,n) => { (o as DeviceConfiguration).DeviceStatuses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceStatus>(ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatusOverview", (o,n) => { (o as DeviceConfiguration).DeviceStatusOverview = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceOverview>(ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceOverview.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as DeviceConfiguration).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceConfiguration).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"userStatuses", (o,n) => { (o as DeviceConfiguration).UserStatuses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationUserStatus>(ApiSdk.Models.Microsoft.Graph.DeviceConfigurationUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatusOverview", (o,n) => { (o as DeviceConfiguration).UserStatusOverview = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationUserOverview>(ApiSdk.Models.Microsoft.Graph.DeviceConfigurationUserOverview.CreateFromDiscriminatorValue); } },
                {"version", (o,n) => { (o as DeviceConfiguration).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SettingStateDeviceSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationDeviceOverview>("deviceStatusOverview", DeviceStatusOverview);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceConfigurationUserOverview>("userStatusOverview", UserStatusOverview);
            writer.WriteIntValue("version", Version);
        }
    }
}
