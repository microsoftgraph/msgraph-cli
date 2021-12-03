using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceExchangeAccessStateSummary : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total count of devices with Exchange Access State: Allowed.</summary>
        public int? AllowedDeviceCount { get; set; }
        /// <summary>Total count of devices with Exchange Access State: Blocked.</summary>
        public int? BlockedDeviceCount { get; set; }
        /// <summary>Total count of devices with Exchange Access State: Quarantined.</summary>
        public int? QuarantinedDeviceCount { get; set; }
        /// <summary>Total count of devices for which no Exchange Access State could be found.</summary>
        public int? UnavailableDeviceCount { get; set; }
        /// <summary>Total count of devices with Exchange Access State: Unknown.</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>
        /// Instantiates a new deviceExchangeAccessStateSummary and sets the default values.
        /// </summary>
        public DeviceExchangeAccessStateSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowedDeviceCount", (o,n) => { (o as DeviceExchangeAccessStateSummary).AllowedDeviceCount = n.GetIntValue(); } },
                {"blockedDeviceCount", (o,n) => { (o as DeviceExchangeAccessStateSummary).BlockedDeviceCount = n.GetIntValue(); } },
                {"quarantinedDeviceCount", (o,n) => { (o as DeviceExchangeAccessStateSummary).QuarantinedDeviceCount = n.GetIntValue(); } },
                {"unavailableDeviceCount", (o,n) => { (o as DeviceExchangeAccessStateSummary).UnavailableDeviceCount = n.GetIntValue(); } },
                {"unknownDeviceCount", (o,n) => { (o as DeviceExchangeAccessStateSummary).UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("allowedDeviceCount", AllowedDeviceCount);
            writer.WriteIntValue("blockedDeviceCount", BlockedDeviceCount);
            writer.WriteIntValue("quarantinedDeviceCount", QuarantinedDeviceCount);
            writer.WriteIntValue("unavailableDeviceCount", UnavailableDeviceCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
