using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ImportedWindowsAutopilotDeviceIdentity : Entity, IParsable {
        /// <summary>UPN of the user the device will be assigned</summary>
        public string AssignedUserPrincipalName { get; set; }
        /// <summary>Group Tag of the Windows autopilot device.</summary>
        public string GroupTag { get; set; }
        /// <summary>Hardware Blob of the Windows autopilot device.</summary>
        public byte[] HardwareIdentifier { get; set; }
        /// <summary>The Import Id of the Windows autopilot device.</summary>
        public string ImportId { get; set; }
        /// <summary>Product Key of the Windows autopilot device.</summary>
        public string ProductKey { get; set; }
        /// <summary>Serial number of the Windows autopilot device.</summary>
        public string SerialNumber { get; set; }
        /// <summary>Current state of the imported device.</summary>
        public ImportedWindowsAutopilotDeviceIdentityState State { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignedUserPrincipalName", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentity).AssignedUserPrincipalName = n.GetStringValue(); } },
                {"groupTag", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentity).GroupTag = n.GetStringValue(); } },
                {"hardwareIdentifier", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentity).HardwareIdentifier = n.GetByteArrayValue(); } },
                {"importId", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentity).ImportId = n.GetStringValue(); } },
                {"productKey", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentity).ProductKey = n.GetStringValue(); } },
                {"serialNumber", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentity).SerialNumber = n.GetStringValue(); } },
                {"state", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentity).State = n.GetObjectValue<ImportedWindowsAutopilotDeviceIdentityState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignedUserPrincipalName", AssignedUserPrincipalName);
            writer.WriteStringValue("groupTag", GroupTag);
            writer.WriteByteArrayValue("hardwareIdentifier", HardwareIdentifier);
            writer.WriteStringValue("importId", ImportId);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteObjectValue<ImportedWindowsAutopilotDeviceIdentityState>("state", State);
        }
    }
}
