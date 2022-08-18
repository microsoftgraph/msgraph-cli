using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Entity which represents a connection to device management partner.</summary>
    public class DeviceManagementPartner : Entity, IParsable {
        /// <summary>Partner display name</summary>
        public string DisplayName { get; set; }
        /// <summary>Whether device management partner is configured or not</summary>
        public bool? IsConfigured { get; set; }
        /// <summary>Timestamp of last heartbeat after admin enabled option Connect to Device management Partner</summary>
        public DateTimeOffset? LastHeartbeatDateTime { get; set; }
        /// <summary>Partner App Type.</summary>
        public DeviceManagementPartnerAppType? PartnerAppType { get; set; }
        /// <summary>Partner state of this tenant.</summary>
        public DeviceManagementPartnerTenantState? PartnerState { get; set; }
        /// <summary>Partner Single tenant App id</summary>
        public string SingleTenantAppId { get; set; }
        /// <summary>DateTime in UTC when PartnerDevices will be marked as NonCompliant</summary>
        public DateTimeOffset? WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime { get; set; }
        /// <summary>DateTime in UTC when PartnerDevices will be removed</summary>
        public DateTimeOffset? WhenPartnerDevicesWillBeRemovedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementPartner and sets the default values.
        /// </summary>
        public DeviceManagementPartner() : base() {
            OdataType = "#microsoft.graph.deviceManagementPartner";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementPartner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementPartner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isConfigured", n => { IsConfigured = n.GetBoolValue(); } },
                {"lastHeartbeatDateTime", n => { LastHeartbeatDateTime = n.GetDateTimeOffsetValue(); } },
                {"partnerAppType", n => { PartnerAppType = n.GetEnumValue<DeviceManagementPartnerAppType>(); } },
                {"partnerState", n => { PartnerState = n.GetEnumValue<DeviceManagementPartnerTenantState>(); } },
                {"singleTenantAppId", n => { SingleTenantAppId = n.GetStringValue(); } },
                {"whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime", n => { WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime = n.GetDateTimeOffsetValue(); } },
                {"whenPartnerDevicesWillBeRemovedDateTime", n => { WhenPartnerDevicesWillBeRemovedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteBoolValue("isConfigured", IsConfigured);
            writer.WriteDateTimeOffsetValue("lastHeartbeatDateTime", LastHeartbeatDateTime);
            writer.WriteEnumValue<DeviceManagementPartnerAppType>("partnerAppType", PartnerAppType);
            writer.WriteEnumValue<DeviceManagementPartnerTenantState>("partnerState", PartnerState);
            writer.WriteStringValue("singleTenantAppId", SingleTenantAppId);
            writer.WriteDateTimeOffsetValue("whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime", WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime);
            writer.WriteDateTimeOffsetValue("whenPartnerDevicesWillBeRemovedDateTime", WhenPartnerDevicesWillBeRemovedDateTime);
        }
    }
}
