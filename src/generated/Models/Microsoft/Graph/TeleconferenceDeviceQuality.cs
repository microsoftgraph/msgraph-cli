using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeleconferenceDeviceQuality : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A unique identifier for all  the participant calls in a conference or a unique identifier for two participant calls in P2P call. This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
        public string CallChainId { get; set; }
        /// <summary>A geo-region where the service is deployed, such as ProdNoam.</summary>
        public string CloudServiceDeploymentEnvironment { get; set; }
        /// <summary>A unique deployment identifier assigned by Azure.</summary>
        public string CloudServiceDeploymentId { get; set; }
        /// <summary>The Azure deployed cloud service instance name, such as FrontEnd_IN_3.</summary>
        public string CloudServiceInstanceName { get; set; }
        /// <summary>The Azure deployed cloud service name, such as contoso.cloudapp.net.</summary>
        public string CloudServiceName { get; set; }
        /// <summary>Any additional description, such as VTC Bldg 30/21.</summary>
        public string DeviceDescription { get; set; }
        /// <summary>The user media agent name, such as Cisco SX80.</summary>
        public string DeviceName { get; set; }
        /// <summary>A unique identifier for a specific media leg of a participant in a conference.  One participant can have multiple media leg identifiers if retargeting happens. CVI partner assigns this value.</summary>
        public string MediaLegId { get; set; }
        /// <summary>The list of media qualities in a media session (call), such as audio quality, video quality, and/or screen sharing quality.</summary>
        public List<TeleconferenceDeviceMediaQuality> MediaQualityList { get; set; }
        /// <summary>A unique identifier for a specific participant in a conference. The CVI partner needs to copy over Call.MyParticipantId to this property.</summary>
        public string ParticipantId { get; set; }
        /// <summary>
        /// Instantiates a new teleconferenceDeviceQuality and sets the default values.
        /// </summary>
        public TeleconferenceDeviceQuality() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"callChainId", (o,n) => { (o as TeleconferenceDeviceQuality).CallChainId = n.GetStringValue(); } },
                {"cloudServiceDeploymentEnvironment", (o,n) => { (o as TeleconferenceDeviceQuality).CloudServiceDeploymentEnvironment = n.GetStringValue(); } },
                {"cloudServiceDeploymentId", (o,n) => { (o as TeleconferenceDeviceQuality).CloudServiceDeploymentId = n.GetStringValue(); } },
                {"cloudServiceInstanceName", (o,n) => { (o as TeleconferenceDeviceQuality).CloudServiceInstanceName = n.GetStringValue(); } },
                {"cloudServiceName", (o,n) => { (o as TeleconferenceDeviceQuality).CloudServiceName = n.GetStringValue(); } },
                {"deviceDescription", (o,n) => { (o as TeleconferenceDeviceQuality).DeviceDescription = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as TeleconferenceDeviceQuality).DeviceName = n.GetStringValue(); } },
                {"mediaLegId", (o,n) => { (o as TeleconferenceDeviceQuality).MediaLegId = n.GetStringValue(); } },
                {"mediaQualityList", (o,n) => { (o as TeleconferenceDeviceQuality).MediaQualityList = n.GetCollectionOfObjectValues<TeleconferenceDeviceMediaQuality>().ToList(); } },
                {"participantId", (o,n) => { (o as TeleconferenceDeviceQuality).ParticipantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("callChainId", CallChainId);
            writer.WriteStringValue("cloudServiceDeploymentEnvironment", CloudServiceDeploymentEnvironment);
            writer.WriteStringValue("cloudServiceDeploymentId", CloudServiceDeploymentId);
            writer.WriteStringValue("cloudServiceInstanceName", CloudServiceInstanceName);
            writer.WriteStringValue("cloudServiceName", CloudServiceName);
            writer.WriteStringValue("deviceDescription", DeviceDescription);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("mediaLegId", MediaLegId);
            writer.WriteCollectionOfObjectValues<TeleconferenceDeviceMediaQuality>("mediaQualityList", MediaQualityList);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
