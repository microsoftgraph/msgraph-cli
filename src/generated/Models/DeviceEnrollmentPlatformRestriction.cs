using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Platform specific enrollment restrictions</summary>
    public class DeviceEnrollmentPlatformRestriction : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Max OS version supported</summary>
        public string OsMaximumVersion { get; set; }
        /// <summary>Min OS version supported</summary>
        public string OsMinimumVersion { get; set; }
        /// <summary>Block personally owned devices from enrolling</summary>
        public bool? PersonalDeviceEnrollmentBlocked { get; set; }
        /// <summary>Block the platform from enrolling</summary>
        public bool? PlatformBlocked { get; set; }
        /// <summary>
        /// Instantiates a new deviceEnrollmentPlatformRestriction and sets the default values.
        /// </summary>
        public DeviceEnrollmentPlatformRestriction() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.deviceEnrollmentPlatformRestriction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceEnrollmentPlatformRestriction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentPlatformRestriction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"personalDeviceEnrollmentBlocked", n => { PersonalDeviceEnrollmentBlocked = n.GetBoolValue(); } },
                {"platformBlocked", n => { PlatformBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("personalDeviceEnrollmentBlocked", PersonalDeviceEnrollmentBlocked);
            writer.WriteBoolValue("platformBlocked", PlatformBlocked);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
