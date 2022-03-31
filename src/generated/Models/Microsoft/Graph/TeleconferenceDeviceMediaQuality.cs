using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeleconferenceDeviceMediaQuality : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The average inbound stream network jitter.</summary>
        public TimeSpan? AverageInboundJitter { get; set; }
        /// <summary>The average inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? AverageInboundPacketLossRateInPercentage { get; set; }
        /// <summary>The average inbound stream network round trip delay.</summary>
        public TimeSpan? AverageInboundRoundTripDelay { get; set; }
        /// <summary>The average outbound stream network jitter.</summary>
        public TimeSpan? AverageOutboundJitter { get; set; }
        /// <summary>The average outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? AverageOutboundPacketLossRateInPercentage { get; set; }
        /// <summary>The average outbound stream network round trip delay.</summary>
        public TimeSpan? AverageOutboundRoundTripDelay { get; set; }
        /// <summary>The channel index of media. Indexing begins with 1.  If a media session contains 3 video modalities, channel indexes will be 1, 2, and 3.</summary>
        public int? ChannelIndex { get; set; }
        /// <summary>The total number of the inbound packets.</summary>
        public long? InboundPackets { get; set; }
        /// <summary>the local IP address for the media session.</summary>
        public string LocalIPAddress { get; set; }
        /// <summary>The local media port.</summary>
        public int? LocalPort { get; set; }
        /// <summary>The maximum inbound stream network jitter.</summary>
        public TimeSpan? MaximumInboundJitter { get; set; }
        /// <summary>The maximum inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? MaximumInboundPacketLossRateInPercentage { get; set; }
        /// <summary>The maximum inbound stream network round trip delay.</summary>
        public TimeSpan? MaximumInboundRoundTripDelay { get; set; }
        /// <summary>The maximum outbound stream network jitter.</summary>
        public TimeSpan? MaximumOutboundJitter { get; set; }
        /// <summary>The maximum outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? MaximumOutboundPacketLossRateInPercentage { get; set; }
        /// <summary>The maximum outbound stream network round trip delay.</summary>
        public TimeSpan? MaximumOutboundRoundTripDelay { get; set; }
        /// <summary>The total modality duration. If the media enabled and disabled multiple times, MediaDuration will the summation of all of the durations.</summary>
        public TimeSpan? MediaDuration { get; set; }
        /// <summary>The network link speed in bytes</summary>
        public long? NetworkLinkSpeedInBytes { get; set; }
        /// <summary>The total number of the outbound packets.</summary>
        public long? OutboundPackets { get; set; }
        /// <summary>The remote IP address for the media session.</summary>
        public string RemoteIPAddress { get; set; }
        /// <summary>The remote media port.</summary>
        public int? RemotePort { get; set; }
        /// <summary>
        /// Instantiates a new teleconferenceDeviceMediaQuality and sets the default values.
        /// </summary>
        public TeleconferenceDeviceMediaQuality() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.TeleconferenceDeviceMediaQuality CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeleconferenceDeviceMediaQuality();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"averageInboundJitter", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageInboundJitter = n.GetTimeSpanValue(); } },
                {"averageInboundPacketLossRateInPercentage", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageInboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"averageInboundRoundTripDelay", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageInboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"averageOutboundJitter", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageOutboundJitter = n.GetTimeSpanValue(); } },
                {"averageOutboundPacketLossRateInPercentage", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageOutboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"averageOutboundRoundTripDelay", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageOutboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"channelIndex", (o,n) => { (o as TeleconferenceDeviceMediaQuality).ChannelIndex = n.GetIntValue(); } },
                {"inboundPackets", (o,n) => { (o as TeleconferenceDeviceMediaQuality).InboundPackets = n.GetLongValue(); } },
                {"localIPAddress", (o,n) => { (o as TeleconferenceDeviceMediaQuality).LocalIPAddress = n.GetStringValue(); } },
                {"localPort", (o,n) => { (o as TeleconferenceDeviceMediaQuality).LocalPort = n.GetIntValue(); } },
                {"maximumInboundJitter", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumInboundJitter = n.GetTimeSpanValue(); } },
                {"maximumInboundPacketLossRateInPercentage", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumInboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"maximumInboundRoundTripDelay", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumInboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"maximumOutboundJitter", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumOutboundJitter = n.GetTimeSpanValue(); } },
                {"maximumOutboundPacketLossRateInPercentage", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumOutboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"maximumOutboundRoundTripDelay", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumOutboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"mediaDuration", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MediaDuration = n.GetTimeSpanValue(); } },
                {"networkLinkSpeedInBytes", (o,n) => { (o as TeleconferenceDeviceMediaQuality).NetworkLinkSpeedInBytes = n.GetLongValue(); } },
                {"outboundPackets", (o,n) => { (o as TeleconferenceDeviceMediaQuality).OutboundPackets = n.GetLongValue(); } },
                {"remoteIPAddress", (o,n) => { (o as TeleconferenceDeviceMediaQuality).RemoteIPAddress = n.GetStringValue(); } },
                {"remotePort", (o,n) => { (o as TeleconferenceDeviceMediaQuality).RemotePort = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("averageInboundJitter", AverageInboundJitter);
            writer.WriteDoubleValue("averageInboundPacketLossRateInPercentage", AverageInboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("averageInboundRoundTripDelay", AverageInboundRoundTripDelay);
            writer.WriteTimeSpanValue("averageOutboundJitter", AverageOutboundJitter);
            writer.WriteDoubleValue("averageOutboundPacketLossRateInPercentage", AverageOutboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("averageOutboundRoundTripDelay", AverageOutboundRoundTripDelay);
            writer.WriteIntValue("channelIndex", ChannelIndex);
            writer.WriteLongValue("inboundPackets", InboundPackets);
            writer.WriteStringValue("localIPAddress", LocalIPAddress);
            writer.WriteIntValue("localPort", LocalPort);
            writer.WriteTimeSpanValue("maximumInboundJitter", MaximumInboundJitter);
            writer.WriteDoubleValue("maximumInboundPacketLossRateInPercentage", MaximumInboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("maximumInboundRoundTripDelay", MaximumInboundRoundTripDelay);
            writer.WriteTimeSpanValue("maximumOutboundJitter", MaximumOutboundJitter);
            writer.WriteDoubleValue("maximumOutboundPacketLossRateInPercentage", MaximumOutboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("maximumOutboundRoundTripDelay", MaximumOutboundRoundTripDelay);
            writer.WriteTimeSpanValue("mediaDuration", MediaDuration);
            writer.WriteLongValue("networkLinkSpeedInBytes", NetworkLinkSpeedInBytes);
            writer.WriteLongValue("outboundPackets", OutboundPackets);
            writer.WriteStringValue("remoteIPAddress", RemoteIPAddress);
            writer.WriteIntValue("remotePort", RemotePort);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
