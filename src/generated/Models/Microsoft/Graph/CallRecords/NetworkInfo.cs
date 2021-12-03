using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.CallRecords {
    public class NetworkInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected the available bandwidth or bandwidth policy was low enough to cause poor quality of the audio sent.</summary>
        public float? BandwidthLowEventRatio { get; set; }
        /// <summary>The wireless LAN basic service set identifier of the media endpoint used to connect to the network.</summary>
        public string BasicServiceSetIdentifier { get; set; }
        /// <summary>Type of network used by the media endpoint. Possible values are: unknown, wired, wifi, mobile, tunnel, unknownFutureValue.</summary>
        public NetworkConnectionType? ConnectionType { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected the network delay was significant enough to impact the ability to have real-time two-way communication.</summary>
        public float? DelayEventRatio { get; set; }
        /// <summary>DNS suffix associated with the network adapter of the media endpoint.</summary>
        public string DnsSuffix { get; set; }
        /// <summary>IP address of the media endpoint.</summary>
        public string IpAddress { get; set; }
        /// <summary>Link speed in bits per second reported by the network adapter used by the media endpoint.</summary>
        public long? LinkSpeed { get; set; }
        /// <summary>The media access control (MAC) address of the media endpoint's network device.</summary>
        public string MacAddress { get; set; }
        /// <summary>Network port number used by media endpoint.</summary>
        public int? Port { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected the network was causing poor quality of the audio received.</summary>
        public float? ReceivedQualityEventRatio { get; set; }
        /// <summary>IP address of the media endpoint as seen by the media relay server. This is typically the public internet IP address associated to the endpoint.</summary>
        public string ReflexiveIPAddress { get; set; }
        /// <summary>IP address of the media relay server allocated by the media endpoint.</summary>
        public string RelayIPAddress { get; set; }
        /// <summary>Network port number allocated on the media relay server by the media endpoint.</summary>
        public int? RelayPort { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected the network was causing poor quality of the audio sent.</summary>
        public float? SentQualityEventRatio { get; set; }
        /// <summary>Subnet used for media stream by the media endpoint.</summary>
        public string Subnet { get; set; }
        /// <summary>WiFi band used by the media endpoint. Possible values are: unknown, frequency24GHz, frequency50GHz, frequency60GHz, unknownFutureValue.</summary>
        public WifiBand? WifiBand { get; set; }
        /// <summary>Estimated remaining battery charge in percentage reported by the media endpoint.</summary>
        public int? WifiBatteryCharge { get; set; }
        /// <summary>WiFi channel used by the media endpoint.</summary>
        public int? WifiChannel { get; set; }
        /// <summary>Name of the Microsoft WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.</summary>
        public string WifiMicrosoftDriver { get; set; }
        /// <summary>Version of the Microsoft WiFi driver used by the media endpoint.</summary>
        public string WifiMicrosoftDriverVersion { get; set; }
        /// <summary>Type of WiFi radio used by the media endpoint. Possible values are: unknown, wifi80211a, wifi80211b, wifi80211g, wifi80211n, wifi80211ac, wifi80211ax, unknownFutureValue.</summary>
        public WifiRadioType? WifiRadioType { get; set; }
        /// <summary>WiFi signal strength in percentage reported by the media endpoint.</summary>
        public int? WifiSignalStrength { get; set; }
        /// <summary>Name of the WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.</summary>
        public string WifiVendorDriver { get; set; }
        /// <summary>Version of the WiFi driver used by the media endpoint.</summary>
        public string WifiVendorDriverVersion { get; set; }
        /// <summary>
        /// Instantiates a new networkInfo and sets the default values.
        /// </summary>
        public NetworkInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bandwidthLowEventRatio", (o,n) => { (o as NetworkInfo).BandwidthLowEventRatio = n.GetFloatValue(); } },
                {"basicServiceSetIdentifier", (o,n) => { (o as NetworkInfo).BasicServiceSetIdentifier = n.GetStringValue(); } },
                {"connectionType", (o,n) => { (o as NetworkInfo).ConnectionType = n.GetEnumValue<NetworkConnectionType>(); } },
                {"delayEventRatio", (o,n) => { (o as NetworkInfo).DelayEventRatio = n.GetFloatValue(); } },
                {"dnsSuffix", (o,n) => { (o as NetworkInfo).DnsSuffix = n.GetStringValue(); } },
                {"ipAddress", (o,n) => { (o as NetworkInfo).IpAddress = n.GetStringValue(); } },
                {"linkSpeed", (o,n) => { (o as NetworkInfo).LinkSpeed = n.GetLongValue(); } },
                {"macAddress", (o,n) => { (o as NetworkInfo).MacAddress = n.GetStringValue(); } },
                {"port", (o,n) => { (o as NetworkInfo).Port = n.GetIntValue(); } },
                {"receivedQualityEventRatio", (o,n) => { (o as NetworkInfo).ReceivedQualityEventRatio = n.GetFloatValue(); } },
                {"reflexiveIPAddress", (o,n) => { (o as NetworkInfo).ReflexiveIPAddress = n.GetStringValue(); } },
                {"relayIPAddress", (o,n) => { (o as NetworkInfo).RelayIPAddress = n.GetStringValue(); } },
                {"relayPort", (o,n) => { (o as NetworkInfo).RelayPort = n.GetIntValue(); } },
                {"sentQualityEventRatio", (o,n) => { (o as NetworkInfo).SentQualityEventRatio = n.GetFloatValue(); } },
                {"subnet", (o,n) => { (o as NetworkInfo).Subnet = n.GetStringValue(); } },
                {"wifiBand", (o,n) => { (o as NetworkInfo).WifiBand = n.GetEnumValue<WifiBand>(); } },
                {"wifiBatteryCharge", (o,n) => { (o as NetworkInfo).WifiBatteryCharge = n.GetIntValue(); } },
                {"wifiChannel", (o,n) => { (o as NetworkInfo).WifiChannel = n.GetIntValue(); } },
                {"wifiMicrosoftDriver", (o,n) => { (o as NetworkInfo).WifiMicrosoftDriver = n.GetStringValue(); } },
                {"wifiMicrosoftDriverVersion", (o,n) => { (o as NetworkInfo).WifiMicrosoftDriverVersion = n.GetStringValue(); } },
                {"wifiRadioType", (o,n) => { (o as NetworkInfo).WifiRadioType = n.GetEnumValue<WifiRadioType>(); } },
                {"wifiSignalStrength", (o,n) => { (o as NetworkInfo).WifiSignalStrength = n.GetIntValue(); } },
                {"wifiVendorDriver", (o,n) => { (o as NetworkInfo).WifiVendorDriver = n.GetStringValue(); } },
                {"wifiVendorDriverVersion", (o,n) => { (o as NetworkInfo).WifiVendorDriverVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("bandwidthLowEventRatio", BandwidthLowEventRatio);
            writer.WriteStringValue("basicServiceSetIdentifier", BasicServiceSetIdentifier);
            writer.WriteEnumValue<NetworkConnectionType>("connectionType", ConnectionType);
            writer.WriteFloatValue("delayEventRatio", DelayEventRatio);
            writer.WriteStringValue("dnsSuffix", DnsSuffix);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteLongValue("linkSpeed", LinkSpeed);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteIntValue("port", Port);
            writer.WriteFloatValue("receivedQualityEventRatio", ReceivedQualityEventRatio);
            writer.WriteStringValue("reflexiveIPAddress", ReflexiveIPAddress);
            writer.WriteStringValue("relayIPAddress", RelayIPAddress);
            writer.WriteIntValue("relayPort", RelayPort);
            writer.WriteFloatValue("sentQualityEventRatio", SentQualityEventRatio);
            writer.WriteStringValue("subnet", Subnet);
            writer.WriteEnumValue<WifiBand>("wifiBand", WifiBand);
            writer.WriteIntValue("wifiBatteryCharge", WifiBatteryCharge);
            writer.WriteIntValue("wifiChannel", WifiChannel);
            writer.WriteStringValue("wifiMicrosoftDriver", WifiMicrosoftDriver);
            writer.WriteStringValue("wifiMicrosoftDriverVersion", WifiMicrosoftDriverVersion);
            writer.WriteEnumValue<WifiRadioType>("wifiRadioType", WifiRadioType);
            writer.WriteIntValue("wifiSignalStrength", WifiSignalStrength);
            writer.WriteStringValue("wifiVendorDriver", WifiVendorDriver);
            writer.WriteStringValue("wifiVendorDriverVersion", WifiVendorDriverVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
