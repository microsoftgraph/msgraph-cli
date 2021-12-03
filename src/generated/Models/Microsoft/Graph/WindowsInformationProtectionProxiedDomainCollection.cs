using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WindowsInformationProtectionProxiedDomainCollection : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name</summary>
        public string DisplayName { get; set; }
        /// <summary>Collection of proxied domains</summary>
        public List<ProxiedDomain> ProxiedDomains { get; set; }
        /// <summary>
        /// Instantiates a new windowsInformationProtectionProxiedDomainCollection and sets the default values.
        /// </summary>
        public WindowsInformationProtectionProxiedDomainCollection() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as WindowsInformationProtectionProxiedDomainCollection).DisplayName = n.GetStringValue(); } },
                {"proxiedDomains", (o,n) => { (o as WindowsInformationProtectionProxiedDomainCollection).ProxiedDomains = n.GetCollectionOfObjectValues<ProxiedDomain>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ProxiedDomain>("proxiedDomains", ProxiedDomains);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
