using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ImportedWindowsAutopilotDeviceIdentityState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Device error code reported by Device Directory Service(DDS).</summary>
        public int? DeviceErrorCode { get; set; }
        /// <summary>Device error name reported by Device Directory Service(DDS).</summary>
        public string DeviceErrorName { get; set; }
        /// <summary>Device status reported by Device Directory Service(DDS). Possible values are: unknown, pending, partial, complete, error.</summary>
        public ImportedWindowsAutopilotDeviceIdentityImportStatus? DeviceImportStatus { get; set; }
        /// <summary>Device Registration ID for successfully added device reported by Device Directory Service(DDS).</summary>
        public string DeviceRegistrationId { get; set; }
        /// <summary>
        /// Instantiates a new importedWindowsAutopilotDeviceIdentityState and sets the default values.
        /// </summary>
        public ImportedWindowsAutopilotDeviceIdentityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceErrorCode", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentityState).DeviceErrorCode = n.GetIntValue(); } },
                {"deviceErrorName", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentityState).DeviceErrorName = n.GetStringValue(); } },
                {"deviceImportStatus", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentityState).DeviceImportStatus = n.GetEnumValue<ImportedWindowsAutopilotDeviceIdentityImportStatus>(); } },
                {"deviceRegistrationId", (o,n) => { (o as ImportedWindowsAutopilotDeviceIdentityState).DeviceRegistrationId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceErrorCode", DeviceErrorCode);
            writer.WriteStringValue("deviceErrorName", DeviceErrorName);
            writer.WriteEnumValue<ImportedWindowsAutopilotDeviceIdentityImportStatus>("deviceImportStatus", DeviceImportStatus);
            writer.WriteStringValue("deviceRegistrationId", DeviceRegistrationId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
