using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.CallRecords {
    public class Media : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Device information associated with the callee endpoint of this media.</summary>
        public ApiSdk.Models.Microsoft.Graph.CallRecords.DeviceInfo CalleeDevice { get; set; }
        /// <summary>Network information associated with the callee endpoint of this media.</summary>
        public ApiSdk.Models.Microsoft.Graph.CallRecords.NetworkInfo CalleeNetwork { get; set; }
        /// <summary>Device information associated with the caller endpoint of this media.</summary>
        public ApiSdk.Models.Microsoft.Graph.CallRecords.DeviceInfo CallerDevice { get; set; }
        /// <summary>Network information associated with the caller endpoint of this media.</summary>
        public ApiSdk.Models.Microsoft.Graph.CallRecords.NetworkInfo CallerNetwork { get; set; }
        /// <summary>How the media was identified during media negotiation stage.</summary>
        public string Label { get; set; }
        /// <summary>Network streams associated with this media.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.CallRecords.MediaStream> Streams { get; set; }
        /// <summary>
        /// Instantiates a new media and sets the default values.
        /// </summary>
        public Media() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.CallRecords.Media CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Media();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"calleeDevice", (o,n) => { (o as Media).CalleeDevice = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CallRecords.DeviceInfo>(ApiSdk.Models.Microsoft.Graph.CallRecords.DeviceInfo.CreateFromDiscriminatorValue); } },
                {"calleeNetwork", (o,n) => { (o as Media).CalleeNetwork = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CallRecords.NetworkInfo>(ApiSdk.Models.Microsoft.Graph.CallRecords.NetworkInfo.CreateFromDiscriminatorValue); } },
                {"callerDevice", (o,n) => { (o as Media).CallerDevice = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CallRecords.DeviceInfo>(ApiSdk.Models.Microsoft.Graph.CallRecords.DeviceInfo.CreateFromDiscriminatorValue); } },
                {"callerNetwork", (o,n) => { (o as Media).CallerNetwork = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CallRecords.NetworkInfo>(ApiSdk.Models.Microsoft.Graph.CallRecords.NetworkInfo.CreateFromDiscriminatorValue); } },
                {"label", (o,n) => { (o as Media).Label = n.GetStringValue(); } },
                {"streams", (o,n) => { (o as Media).Streams = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.CallRecords.MediaStream>(ApiSdk.Models.Microsoft.Graph.CallRecords.MediaStream.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CallRecords.DeviceInfo>("calleeDevice", CalleeDevice);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CallRecords.NetworkInfo>("calleeNetwork", CalleeNetwork);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CallRecords.DeviceInfo>("callerDevice", CallerDevice);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CallRecords.NetworkInfo>("callerNetwork", CallerNetwork);
            writer.WriteStringValue("label", Label);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.CallRecords.MediaStream>("streams", Streams);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
