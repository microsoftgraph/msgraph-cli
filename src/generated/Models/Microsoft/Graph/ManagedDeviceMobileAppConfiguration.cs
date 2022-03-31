using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedDeviceMobileAppConfiguration : Entity, IParsable {
        /// <summary>The list of group assignemenets for app configration.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationAssignment> Assignments { get; set; }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description { get; set; }
        /// <summary>List of ManagedDeviceMobileAppConfigurationDeviceStatus.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationDeviceStatus> DeviceStatuses { get; set; }
        /// <summary>App configuration device status summary.</summary>
        public ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationDeviceSummary DeviceStatusSummary { get; set; }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>the associated app.</summary>
        public List<string> TargetedMobileApps { get; set; }
        /// <summary>List of ManagedDeviceMobileAppConfigurationUserStatus.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationUserStatus> UserStatuses { get; set; }
        /// <summary>App configuration user status summary.</summary>
        public ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationUserSummary UserStatusSummary { get; set; }
        /// <summary>Version of the device configuration.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceMobileAppConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).Assignments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationAssignment>(ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).Description = n.GetStringValue(); } },
                {"deviceStatuses", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).DeviceStatuses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationDeviceStatus>(ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatusSummary", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).DeviceStatusSummary = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationDeviceSummary>(ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationDeviceSummary.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"targetedMobileApps", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).TargetedMobileApps = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userStatuses", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).UserStatuses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationUserStatus>(ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatusSummary", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).UserStatusSummary = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationUserSummary>(ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationUserSummary.CreateFromDiscriminatorValue); } },
                {"version", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationDeviceSummary>("deviceStatusSummary", DeviceStatusSummary);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("targetedMobileApps", TargetedMobileApps);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfigurationUserSummary>("userStatusSummary", UserStatusSummary);
            writer.WriteIntValue("version", Version);
        }
    }
}
