using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class HostSecurityState : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Host FQDN (Fully Qualified Domain Name) (for example, machine.company.com).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fqdn { get; set; }
#nullable restore
#else
        public string Fqdn { get; set; }
#endif
        public bool? IsAzureAdJoined { get; set; }
        public bool? IsAzureAdRegistered { get; set; }
        /// <summary>True if the host is domain joined to an on-premises Active Directory domain.</summary>
        public bool? IsHybridAzureDomainJoined { get; set; }
        /// <summary>The local host name, without the DNS domain name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetBiosName { get; set; }
#nullable restore
#else
        public string NetBiosName { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Host Operating System. (For example, Windows10, MacOS, RHEL, etc.).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Os { get; set; }
#nullable restore
#else
        public string Os { get; set; }
#endif
        /// <summary>Private (not routable) IPv4 or IPv6 address (see RFC 1918) at the time of the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivateIpAddress { get; set; }
#nullable restore
#else
        public string PrivateIpAddress { get; set; }
#endif
        /// <summary>Publicly routable IPv4 or IPv6 address (see RFC 1918) at time of the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicIpAddress { get; set; }
#nullable restore
#else
        public string PublicIpAddress { get; set; }
#endif
        /// <summary>Provider-generated/calculated risk score of the host.  Recommended value range of 0-1, which equates to a percentage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RiskScore { get; set; }
#nullable restore
#else
        public string RiskScore { get; set; }
#endif
        /// <summary>
        /// Instantiates a new hostSecurityState and sets the default values.
        /// </summary>
        public HostSecurityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static HostSecurityState CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static HostSecurityState CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HostSecurityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"fqdn", n => { Fqdn = n.GetStringValue(); } },
                {"isAzureAdJoined", n => { IsAzureAdJoined = n.GetBoolValue(); } },
                {"isAzureAdRegistered", n => { IsAzureAdRegistered = n.GetBoolValue(); } },
                {"isHybridAzureDomainJoined", n => { IsHybridAzureDomainJoined = n.GetBoolValue(); } },
                {"netBiosName", n => { NetBiosName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"os", n => { Os = n.GetStringValue(); } },
                {"privateIpAddress", n => { PrivateIpAddress = n.GetStringValue(); } },
                {"publicIpAddress", n => { PublicIpAddress = n.GetStringValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fqdn", Fqdn);
            writer.WriteBoolValue("isAzureAdJoined", IsAzureAdJoined);
            writer.WriteBoolValue("isAzureAdRegistered", IsAzureAdRegistered);
            writer.WriteBoolValue("isHybridAzureDomainJoined", IsHybridAzureDomainJoined);
            writer.WriteStringValue("netBiosName", NetBiosName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("os", Os);
            writer.WriteStringValue("privateIpAddress", PrivateIpAddress);
            writer.WriteStringValue("publicIpAddress", PublicIpAddress);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
