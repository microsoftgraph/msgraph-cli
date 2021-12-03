using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ProxiedDomain : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The IP address or FQDN</summary>
        public string IpAddressOrFQDN { get; set; }
        /// <summary>Proxy IP or FQDN</summary>
        public string Proxy { get; set; }
        /// <summary>
        /// Instantiates a new proxiedDomain and sets the default values.
        /// </summary>
        public ProxiedDomain() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ipAddressOrFQDN", (o,n) => { (o as ProxiedDomain).IpAddressOrFQDN = n.GetStringValue(); } },
                {"proxy", (o,n) => { (o as ProxiedDomain).Proxy = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ipAddressOrFQDN", IpAddressOrFQDN);
            writer.WriteStringValue("proxy", Proxy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
