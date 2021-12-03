using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedDeviceMobileAppConfiguration : Entity, IParsable {
        /// <summary>The list of group assignemenets for app configration.</summary>
        public List<ManagedDeviceMobileAppConfigurationAssignment> Assignments { get; set; }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description { get; set; }
        /// <summary>List of ManagedDeviceMobileAppConfigurationDeviceStatus.</summary>
        public List<ManagedDeviceMobileAppConfigurationDeviceStatus> DeviceStatuses { get; set; }
        /// <summary>App configuration device status summary.</summary>
        public ManagedDeviceMobileAppConfigurationDeviceSummary DeviceStatusSummary { get; set; }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>the associated app.</summary>
        public List<string> TargetedMobileApps { get; set; }
        /// <summary>List of ManagedDeviceMobileAppConfigurationUserStatus.</summary>
        public List<ManagedDeviceMobileAppConfigurationUserStatus> UserStatuses { get; set; }
        /// <summary>App configuration user status summary.</summary>
        public ManagedDeviceMobileAppConfigurationUserSummary UserStatusSummary { get; set; }
        /// <summary>Version of the device configuration.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).Assignments = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationAssignment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).Description = n.GetStringValue(); } },
                {"deviceStatuses", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).DeviceStatuses = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationDeviceStatus>().ToList(); } },
                {"deviceStatusSummary", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).DeviceStatusSummary = n.GetObjectValue<ManagedDeviceMobileAppConfigurationDeviceSummary>(); } },
                {"displayName", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"targetedMobileApps", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).TargetedMobileApps = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userStatuses", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).UserStatuses = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationUserStatus>().ToList(); } },
                {"userStatusSummary", (o,n) => { (o as ManagedDeviceMobileAppConfiguration).UserStatusSummary = n.GetObjectValue<ManagedDeviceMobileAppConfigurationUserSummary>(); } },
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
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<ManagedDeviceMobileAppConfigurationDeviceSummary>("deviceStatusSummary", DeviceStatusSummary);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("targetedMobileApps", TargetedMobileApps);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<ManagedDeviceMobileAppConfigurationUserSummary>("userStatusSummary", UserStatusSummary);
            writer.WriteIntValue("version", Version);
        }
    }
}
