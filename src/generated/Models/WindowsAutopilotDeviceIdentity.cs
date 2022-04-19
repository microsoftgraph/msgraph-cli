using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WindowsAutopilotDeviceIdentity : Entity, IParsable {
        /// <summary>Addressable user name.</summary>
        public string AddressableUserName { get; set; }
        /// <summary>AAD Device ID - to be deprecated</summary>
        public string AzureActiveDirectoryDeviceId { get; set; }
        /// <summary>Display Name</summary>
        public string DisplayName { get; set; }
        /// <summary>Intune enrollment state of the Windows autopilot device. Possible values are: unknown, enrolled, pendingReset, failed, notContacted.</summary>
        public ApiSdk.Models.EnrollmentState? EnrollmentState { get; set; }
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsAutopilotDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAutopilotDeviceIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addressableUserName", n => { AddressableUserName = n.GetStringValue(); } },
                {"azureActiveDirectoryDeviceId", n => { AzureActiveDirectoryDeviceId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrollmentState", n => { EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"groupTag", n => { GroupTag = n.GetStringValue(); } },
                {"lastContactedDateTime", n => { LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"productKey", n => { ProductKey = n.GetStringValue(); } },
                {"purchaseOrderIdentifier", n => { PurchaseOrderIdentifier = n.GetStringValue(); } },
                {"resourceName", n => { ResourceName = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"skuNumber", n => { SkuNumber = n.GetStringValue(); } },
                {"systemFamily", n => { SystemFamily = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
