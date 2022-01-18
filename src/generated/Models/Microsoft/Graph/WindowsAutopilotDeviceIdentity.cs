using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WindowsAutopilotDeviceIdentity : Entity, IParsable {
        /// <summary>Addressable user name.</summary>
        public string AddressableUserName { get; set; }
        /// <summary>AAD Device ID - to be deprecated</summary>
        public string AzureActiveDirectoryDeviceId { get; set; }
        /// <summary>Display Name</summary>
        public string DisplayName { get; set; }
        /// <summary>Intune enrollment state of the Windows autopilot device. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.</summary>
        public EnrollmentState? EnrollmentState { get; set; }
        /// <summary>Group Tag of the Windows autopilot device.</summary>
        public string GroupTag { get; set; }
        /// <summary>Intune Last Contacted Date Time of the Windows autopilot device.</summary>
        public DateTimeOffset? LastContactedDateTime { get; set; }
        /// <summary>Managed Device ID</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>Oem manufacturer of the Windows autopilot device.</summary>
        public string Manufacturer { get; set; }
        /// <summary>Model name of the Windows autopilot device.</summary>
        public string Model { get; set; }
        /// <summary>Product Key of the Windows autopilot device.</summary>
        public string ProductKey { get; set; }
        /// <summary>Purchase Order Identifier of the Windows autopilot device.</summary>
        public string PurchaseOrderIdentifier { get; set; }
        /// <summary>Resource Name.</summary>
        public string ResourceName { get; set; }
        /// <summary>Serial number of the Windows autopilot device.</summary>
        public string SerialNumber { get; set; }
        /// <summary>SKU Number</summary>
        public string SkuNumber { get; set; }
        /// <summary>System Family</summary>
        public string SystemFamily { get; set; }
        /// <summary>User Principal Name.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addressableUserName", (o,n) => { (o as WindowsAutopilotDeviceIdentity).AddressableUserName = n.GetStringValue(); } },
                {"azureActiveDirectoryDeviceId", (o,n) => { (o as WindowsAutopilotDeviceIdentity).AzureActiveDirectoryDeviceId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as WindowsAutopilotDeviceIdentity).DisplayName = n.GetStringValue(); } },
                {"enrollmentState", (o,n) => { (o as WindowsAutopilotDeviceIdentity).EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"groupTag", (o,n) => { (o as WindowsAutopilotDeviceIdentity).GroupTag = n.GetStringValue(); } },
                {"lastContactedDateTime", (o,n) => { (o as WindowsAutopilotDeviceIdentity).LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", (o,n) => { (o as WindowsAutopilotDeviceIdentity).ManagedDeviceId = n.GetStringValue(); } },
                {"manufacturer", (o,n) => { (o as WindowsAutopilotDeviceIdentity).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as WindowsAutopilotDeviceIdentity).Model = n.GetStringValue(); } },
                {"productKey", (o,n) => { (o as WindowsAutopilotDeviceIdentity).ProductKey = n.GetStringValue(); } },
                {"purchaseOrderIdentifier", (o,n) => { (o as WindowsAutopilotDeviceIdentity).PurchaseOrderIdentifier = n.GetStringValue(); } },
                {"resourceName", (o,n) => { (o as WindowsAutopilotDeviceIdentity).ResourceName = n.GetStringValue(); } },
                {"serialNumber", (o,n) => { (o as WindowsAutopilotDeviceIdentity).SerialNumber = n.GetStringValue(); } },
                {"skuNumber", (o,n) => { (o as WindowsAutopilotDeviceIdentity).SkuNumber = n.GetStringValue(); } },
                {"systemFamily", (o,n) => { (o as WindowsAutopilotDeviceIdentity).SystemFamily = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as WindowsAutopilotDeviceIdentity).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("azureActiveDirectoryDeviceId", AzureActiveDirectoryDeviceId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteStringValue("groupTag", GroupTag);
            writer.WriteDateTimeOffsetValue("lastContactedDateTime", LastContactedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteStringValue("purchaseOrderIdentifier", PurchaseOrderIdentifier);
            writer.WriteStringValue("resourceName", ResourceName);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("skuNumber", SkuNumber);
            writer.WriteStringValue("systemFamily", SystemFamily);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
