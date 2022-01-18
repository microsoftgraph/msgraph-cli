using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class NetworkConnection : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the application managing the network connection (for example, Facebook, SMTP, etc.).</summary>
        public string ApplicationName { get; set; }
        /// <summary>Destination IP address (of the network connection).</summary>
        public string DestinationAddress { get; set; }
        /// <summary>Destination domain portion of the destination URL. (for example 'www.contoso.com').</summary>
        public string DestinationDomain { get; set; }
        /// <summary>Location (by IP address mapping) associated with the destination of a network connection.</summary>
        public string DestinationLocation { get; set; }
        /// <summary>Destination port (of the network connection).</summary>
        public string DestinationPort { get; set; }
        /// <summary>Network connection URL/URI string - excluding parameters. (for example 'www.contoso.com/products/default.html')</summary>
        public string DestinationUrl { get; set; }
        /// <summary>Network connection direction. Possible values are: unknown, inbound, outbound.</summary>
        public ConnectionDirection? Direction { get; set; }
        /// <summary>Date when the destination domain was registered. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DomainRegisteredDateTime { get; set; }
        /// <summary>The local DNS name resolution as it appears in the host's local DNS cache (for example, in case the 'hosts' file was tampered with).</summary>
        public string LocalDnsName { get; set; }
        /// <summary>Network Address Translation destination IP address.</summary>
        public string NatDestinationAddress { get; set; }
        /// <summary>Network Address Translation destination port.</summary>
        public string NatDestinationPort { get; set; }
        /// <summary>Network Address Translation source IP address.</summary>
        public string NatSourceAddress { get; set; }
        /// <summary>Network Address Translation source port.</summary>
        public string NatSourcePort { get; set; }
        /// <summary>Network protocol. Possible values are: unknown, ip, icmp, igmp, ggp, ipv4, tcp, pup, udp, idp, ipv6, ipv6RoutingHeader, ipv6FragmentHeader, ipSecEncapsulatingSecurityPayload, ipSecAuthenticationHeader, icmpV6, ipv6NoNextHeader, ipv6DestinationOptions, nd, raw, ipx, spx, spxII.</summary>
        public SecurityNetworkProtocol? Protocol { get; set; }
        /// <summary>Provider generated/calculated risk score of the network connection. Recommended value range of 0-1, which equates to a percentage.</summary>
        public string RiskScore { get; set; }
        /// <summary>Source (i.e. origin) IP address (of the network connection).</summary>
        public string SourceAddress { get; set; }
        /// <summary>Location (by IP address mapping) associated with the source of a network connection.</summary>
        public string SourceLocation { get; set; }
        /// <summary>Source (i.e. origin) IP port (of the network connection).</summary>
        public string SourcePort { get; set; }
        /// <summary>Network connection status. Possible values are: unknown, attempted, succeeded, blocked, failed.</summary>
        public ConnectionStatus? Status { get; set; }
        /// <summary>Parameters (suffix) of the destination URL.</summary>
        public string UrlParameters { get; set; }
        /// <summary>
        /// Instantiates a new networkConnection and sets the default values.
        /// </summary>
        public NetworkConnection() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationName", (o,n) => { (o as NetworkConnection).ApplicationName = n.GetStringValue(); } },
                {"destinationAddress", (o,n) => { (o as NetworkConnection).DestinationAddress = n.GetStringValue(); } },
                {"destinationDomain", (o,n) => { (o as NetworkConnection).DestinationDomain = n.GetStringValue(); } },
                {"destinationLocation", (o,n) => { (o as NetworkConnection).DestinationLocation = n.GetStringValue(); } },
                {"destinationPort", (o,n) => { (o as NetworkConnection).DestinationPort = n.GetStringValue(); } },
                {"destinationUrl", (o,n) => { (o as NetworkConnection).DestinationUrl = n.GetStringValue(); } },
                {"direction", (o,n) => { (o as NetworkConnection).Direction = n.GetEnumValue<ConnectionDirection>(); } },
                {"domainRegisteredDateTime", (o,n) => { (o as NetworkConnection).DomainRegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"localDnsName", (o,n) => { (o as NetworkConnection).LocalDnsName = n.GetStringValue(); } },
                {"natDestinationAddress", (o,n) => { (o as NetworkConnection).NatDestinationAddress = n.GetStringValue(); } },
                {"natDestinationPort", (o,n) => { (o as NetworkConnection).NatDestinationPort = n.GetStringValue(); } },
                {"natSourceAddress", (o,n) => { (o as NetworkConnection).NatSourceAddress = n.GetStringValue(); } },
                {"natSourcePort", (o,n) => { (o as NetworkConnection).NatSourcePort = n.GetStringValue(); } },
                {"protocol", (o,n) => { (o as NetworkConnection).Protocol = n.GetEnumValue<SecurityNetworkProtocol>(); } },
                {"riskScore", (o,n) => { (o as NetworkConnection).RiskScore = n.GetStringValue(); } },
                {"sourceAddress", (o,n) => { (o as NetworkConnection).SourceAddress = n.GetStringValue(); } },
                {"sourceLocation", (o,n) => { (o as NetworkConnection).SourceLocation = n.GetStringValue(); } },
                {"sourcePort", (o,n) => { (o as NetworkConnection).SourcePort = n.GetStringValue(); } },
                {"status", (o,n) => { (o as NetworkConnection).Status = n.GetEnumValue<ConnectionStatus>(); } },
                {"urlParameters", (o,n) => { (o as NetworkConnection).UrlParameters = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationName", ApplicationName);
            writer.WriteStringValue("destinationAddress", DestinationAddress);
            writer.WriteStringValue("destinationDomain", DestinationDomain);
            writer.WriteStringValue("destinationLocation", DestinationLocation);
            writer.WriteStringValue("destinationPort", DestinationPort);
            writer.WriteStringValue("destinationUrl", DestinationUrl);
            writer.WriteEnumValue<ConnectionDirection>("direction", Direction);
            writer.WriteDateTimeOffsetValue("domainRegisteredDateTime", DomainRegisteredDateTime);
            writer.WriteStringValue("localDnsName", LocalDnsName);
            writer.WriteStringValue("natDestinationAddress", NatDestinationAddress);
            writer.WriteStringValue("natDestinationPort", NatDestinationPort);
            writer.WriteStringValue("natSourceAddress", NatSourceAddress);
            writer.WriteStringValue("natSourcePort", NatSourcePort);
            writer.WriteEnumValue<SecurityNetworkProtocol>("protocol", Protocol);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteStringValue("sourceAddress", SourceAddress);
            writer.WriteStringValue("sourceLocation", SourceLocation);
            writer.WriteStringValue("sourcePort", SourcePort);
            writer.WriteEnumValue<ConnectionStatus>("status", Status);
            writer.WriteStringValue("urlParameters", UrlParameters);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
