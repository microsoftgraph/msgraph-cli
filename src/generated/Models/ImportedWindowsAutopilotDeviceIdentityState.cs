using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ImportedWindowsAutopilotDeviceIdentityState : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ImportedWindowsAutopilotDeviceIdentityState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportedWindowsAutopilotDeviceIdentityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceErrorCode", n => { DeviceErrorCode = n.GetIntValue(); } },
                {"deviceErrorName", n => { DeviceErrorName = n.GetStringValue(); } },
                {"deviceImportStatus", n => { DeviceImportStatus = n.GetEnumValue<ImportedWindowsAutopilotDeviceIdentityImportStatus>(); } },
                {"deviceRegistrationId", n => { DeviceRegistrationId = n.GetStringValue(); } },
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
