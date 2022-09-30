using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Imported windows autopilot devices.</summary>
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
        /// Instantiates a new importedWindowsAutopilotDeviceIdentity and sets the default values.
        /// </summary>
        public ImportedWindowsAutopilotDeviceIdentity() : base() {
            OdataType = "#microsoft.graph.importedWindowsAutopilotDeviceIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ImportedWindowsAutopilotDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportedWindowsAutopilotDeviceIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedUserPrincipalName", n => { AssignedUserPrincipalName = n.GetStringValue(); } },
                {"groupTag", n => { GroupTag = n.GetStringValue(); } },
                {"hardwareIdentifier", n => { HardwareIdentifier = n.GetByteArrayValue(); } },
                {"importId", n => { ImportId = n.GetStringValue(); } },
                {"productKey", n => { ProductKey = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"state", n => { State = n.GetObjectValue<ImportedWindowsAutopilotDeviceIdentityState>(ImportedWindowsAutopilotDeviceIdentityState.CreateFromDiscriminatorValue); } },
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
