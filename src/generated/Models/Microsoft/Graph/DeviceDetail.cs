using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceDetail : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the browser information of the used for signing-in.</summary>
        public string Browser { get; set; }
        /// <summary>Refers to the UniqueID of the device used for signing-in.</summary>
        public string DeviceId { get; set; }
        /// <summary>Refers to the name of the device used for signing-in.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates whether the device is compliant or not.</summary>
        public bool? IsCompliant { get; set; }
        /// <summary>Indicates if the device is managed or not.</summary>
        public bool? IsManaged { get; set; }
        /// <summary>Indicates the OS name and version used for signing-in.</summary>
        public string OperatingSystem { get; set; }
        /// <summary>Indicates information on whether the signed-in device is Workplace Joined, AzureAD Joined, Domain Joined.</summary>
        public string TrustType { get; set; }
        /// <summary>
        /// Instantiates a new deviceDetail and sets the default values.
        /// </summary>
        public DeviceDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"browser", (o,n) => { (o as DeviceDetail).Browser = n.GetStringValue(); } },
                {"deviceId", (o,n) => { (o as DeviceDetail).DeviceId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DeviceDetail).DisplayName = n.GetStringValue(); } },
                {"isCompliant", (o,n) => { (o as DeviceDetail).IsCompliant = n.GetBoolValue(); } },
                {"isManaged", (o,n) => { (o as DeviceDetail).IsManaged = n.GetBoolValue(); } },
                {"operatingSystem", (o,n) => { (o as DeviceDetail).OperatingSystem = n.GetStringValue(); } },
                {"trustType", (o,n) => { (o as DeviceDetail).TrustType = n.GetStringValue(); } },
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
