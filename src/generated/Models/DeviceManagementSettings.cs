using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DeviceManagementSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of days a device is allowed to go without checking in to remain compliant.</summary>
        public int? DeviceComplianceCheckinThresholdDays { get; set; }
        /// <summary>Is feature enabled or not for scheduled action for rule.</summary>
        public bool? IsScheduledActionEnabled { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Device should be noncompliant when there is no compliance policy targeted when this is true</summary>
        public bool? SecureByDefault { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementSettings and sets the default values.
        /// </summary>
        public DeviceManagementSettings() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.deviceManagementSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceComplianceCheckinThresholdDays", n => { DeviceComplianceCheckinThresholdDays = n.GetIntValue(); } },
                {"isScheduledActionEnabled", n => { IsScheduledActionEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"secureByDefault", n => { SecureByDefault = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceComplianceCheckinThresholdDays", DeviceComplianceCheckinThresholdDays);
            writer.WriteBoolValue("isScheduledActionEnabled", IsScheduledActionEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("secureByDefault", SecureByDefault);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
