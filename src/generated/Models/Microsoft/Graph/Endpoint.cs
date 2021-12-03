using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Endpoint : DirectoryObject, IParsable {
        /// <summary>Describes the capability that is associated with this resource. (e.g. Messages, Conversations, etc.)  Not nullable. Read-only.</summary>
        public string Capability { get; set; }
        /// <summary>Application id of the publishing underlying service. Not nullable. Read-only.</summary>
        public string ProviderId { get; set; }
        /// <summary>Name of the publishing underlying service. Read-only.</summary>
        public string ProviderName { get; set; }
        /// <summary>For Microsoft 365 groups, this is set to a well-known name for the resource (e.g. Yammer.FeedURL etc.). Not nullable. Read-only.</summary>
        public string ProviderResourceId { get; set; }
        /// <summary>URL of the published resource. Not nullable. Read-only.</summary>
        public string Uri { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"capability", (o,n) => { (o as Endpoint).Capability = n.GetStringValue(); } },
                {"providerId", (o,n) => { (o as Endpoint).ProviderId = n.GetStringValue(); } },
                {"providerName", (o,n) => { (o as Endpoint).ProviderName = n.GetStringValue(); } },
                {"providerResourceId", (o,n) => { (o as Endpoint).ProviderResourceId = n.GetStringValue(); } },
                {"uri", (o,n) => { (o as Endpoint).Uri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("capability", Capability);
            writer.WriteStringValue("providerId", ProviderId);
            writer.WriteStringValue("providerName", ProviderName);
            writer.WriteStringValue("providerResourceId", ProviderResourceId);
            writer.WriteStringValue("uri", Uri);
        }
    }
}
