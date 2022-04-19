using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DeviceDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the browser information of the used for signing in.</summary>
        public string Browser { get; set; }
        /// <summary>Refers to the UniqueID of the device used for signing in.</summary>
        public string DeviceId { get; set; }
        /// <summary>Refers to the name of the device used for signing in.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates whether the device is compliant.</summary>
        public bool? IsCompliant { get; set; }
        /// <summary>Indicates whether the device is managed.</summary>
        public bool? IsManaged { get; set; }
        /// <summary>Indicates the operating system name and version used for signing in.</summary>
        public string OperatingSystem { get; set; }
        /// <summary>Provides information about whether the signed-in device is Workplace Joined, AzureAD Joined, Domain Joined.</summary>
        public string TrustType { get; set; }
        /// <summary>
        /// Instantiates a new deviceDetail and sets the default values.
        /// </summary>
        public DeviceDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"browser", n => { Browser = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isCompliant", n => { IsCompliant = n.GetBoolValue(); } },
                {"isManaged", n => { IsManaged = n.GetBoolValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"trustType", n => { TrustType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("browser", Browser);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isCompliant", IsCompliant);
            writer.WriteBoolValue("isManaged", IsManaged);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("trustType", TrustType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
