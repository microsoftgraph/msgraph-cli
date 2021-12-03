using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.CallRecords {
    public class Media : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Device information associated with the callee endpoint of this media.</summary>
        public DeviceInfo CalleeDevice { get; set; }
        /// <summary>Network information associated with the callee endpoint of this media.</summary>
        public NetworkInfo CalleeNetwork { get; set; }
        /// <summary>Device information associated with the caller endpoint of this media.</summary>
        public DeviceInfo CallerDevice { get; set; }
        /// <summary>Network information associated with the caller endpoint of this media.</summary>
        public NetworkInfo CallerNetwork { get; set; }
        /// <summary>How the media was identified during media negotiation stage.</summary>
        public string Label { get; set; }
        /// <summary>Network streams associated with this media.</summary>
        public List<MediaStream> Streams { get; set; }
        /// <summary>
        /// Instantiates a new media and sets the default values.
        /// </summary>
        public Media() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"calleeDevice", (o,n) => { (o as Media).CalleeDevice = n.GetObjectValue<DeviceInfo>(); } },
                {"calleeNetwork", (o,n) => { (o as Media).CalleeNetwork = n.GetObjectValue<NetworkInfo>(); } },
                {"callerDevice", (o,n) => { (o as Media).CallerDevice = n.GetObjectValue<DeviceInfo>(); } },
                {"callerNetwork", (o,n) => { (o as Media).CallerNetwork = n.GetObjectValue<NetworkInfo>(); } },
                {"label", (o,n) => { (o as Media).Label = n.GetStringValue(); } },
                {"streams", (o,n) => { (o as Media).Streams = n.GetCollectionOfObjectValues<MediaStream>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceInfo>("calleeDevice", CalleeDevice);
            writer.WriteObjectValue<NetworkInfo>("calleeNetwork", CalleeNetwork);
            writer.WriteObjectValue<DeviceInfo>("callerDevice", CallerDevice);
            writer.WriteObjectValue<NetworkInfo>("callerNetwork", CallerNetwork);
            writer.WriteStringValue("label", Label);
            writer.WriteCollectionOfObjectValues<MediaStream>("streams", Streams);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
