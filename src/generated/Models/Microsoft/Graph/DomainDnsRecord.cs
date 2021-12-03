using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DomainDnsRecord : Entity, IParsable {
        /// <summary>If false, this record must be configured by the customer at the DNS host for Microsoft Online Services to operate correctly with the domain.</summary>
        public bool? IsOptional { get; set; }
        /// <summary>Value used when configuring the name of the DNS record at the DNS host.</summary>
        public string Label { get; set; }
        /// <summary>Indicates what type of DNS record this entity represents.The value can be one of the following: CName, Mx, Srv, TxtKey</summary>
        public string RecordType { get; set; }
        /// <summary>Microsoft Online Service or feature that has a dependency on this DNS record.Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune</summary>
        public string SupportedService { get; set; }
        /// <summary>Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host. Not nullable</summary>
        public int? Ttl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isOptional", (o,n) => { (o as DomainDnsRecord).IsOptional = n.GetBoolValue(); } },
                {"label", (o,n) => { (o as DomainDnsRecord).Label = n.GetStringValue(); } },
                {"recordType", (o,n) => { (o as DomainDnsRecord).RecordType = n.GetStringValue(); } },
                {"supportedService", (o,n) => { (o as DomainDnsRecord).SupportedService = n.GetStringValue(); } },
                {"ttl", (o,n) => { (o as DomainDnsRecord).Ttl = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isOptional", IsOptional);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("recordType", RecordType);
            writer.WriteStringValue("supportedService", SupportedService);
            writer.WriteIntValue("ttl", Ttl);
        }
    }
}
