using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class HostSecurityState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Host FQDN (Fully Qualified Domain Name) (for example, machine.company.com).</summary>
        public string Fqdn { get; set; }
        public bool? IsAzureAdJoined { get; set; }
        public bool? IsAzureAdRegistered { get; set; }
        /// <summary>True if the host is domain joined to an on-premises Active Directory domain.</summary>
        public bool? IsHybridAzureDomainJoined { get; set; }
        /// <summary>The local host name, without the DNS domain name.</summary>
        public string NetBiosName { get; set; }
        /// <summary>Host Operating System. (For example, Windows10, MacOS, RHEL, etc.).</summary>
        public string Os { get; set; }
        /// <summary>Private (not routable) IPv4 or IPv6 address (see RFC 1918) at the time of the alert.</summary>
        public string PrivateIpAddress { get; set; }
        /// <summary>Publicly routable IPv4 or IPv6 address (see RFC 1918) at time of the alert.</summary>
        public string PublicIpAddress { get; set; }
        /// <summary>Provider-generated/calculated risk score of the host.  Recommended value range of 0-1, which equates to a percentage.</summary>
        public string RiskScore { get; set; }
        /// <summary>
        /// Instantiates a new hostSecurityState and sets the default values.
        /// </summary>
        public HostSecurityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fqdn", (o,n) => { (o as HostSecurityState).Fqdn = n.GetStringValue(); } },
                {"isAzureAdJoined", (o,n) => { (o as HostSecurityState).IsAzureAdJoined = n.GetBoolValue(); } },
                {"isAzureAdRegistered", (o,n) => { (o as HostSecurityState).IsAzureAdRegistered = n.GetBoolValue(); } },
                {"isHybridAzureDomainJoined", (o,n) => { (o as HostSecurityState).IsHybridAzureDomainJoined = n.GetBoolValue(); } },
                {"netBiosName", (o,n) => { (o as HostSecurityState).NetBiosName = n.GetStringValue(); } },
                {"os", (o,n) => { (o as HostSecurityState).Os = n.GetStringValue(); } },
                {"privateIpAddress", (o,n) => { (o as HostSecurityState).PrivateIpAddress = n.GetStringValue(); } },
                {"publicIpAddress", (o,n) => { (o as HostSecurityState).PublicIpAddress = n.GetStringValue(); } },
                {"riskScore", (o,n) => { (o as HostSecurityState).RiskScore = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fqdn", Fqdn);
            writer.WriteBoolValue("isAzureAdJoined", IsAzureAdJoined);
            writer.WriteBoolValue("isAzureAdRegistered", IsAzureAdRegistered);
            writer.WriteBoolValue("isHybridAzureDomainJoined", IsHybridAzureDomainJoined);
            writer.WriteStringValue("netBiosName", NetBiosName);
            writer.WriteStringValue("os", Os);
            writer.WriteStringValue("privateIpAddress", PrivateIpAddress);
            writer.WriteStringValue("publicIpAddress", PublicIpAddress);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
