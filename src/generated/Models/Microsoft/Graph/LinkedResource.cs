using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class LinkedResource : Entity, IParsable {
        /// <summary>Field indicating the app name of the source that is sending the linkedResource.</summary>
        public string ApplicationName { get; set; }
        /// <summary>Field indicating the title of the linkedResource.</summary>
        public string DisplayName { get; set; }
        /// <summary>Id of the object that is associated with this task on the third-party/partner system.</summary>
        public string ExternalId { get; set; }
        /// <summary>Deep link to the linkedResource.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationName", (o,n) => { (o as LinkedResource).ApplicationName = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as LinkedResource).DisplayName = n.GetStringValue(); } },
                {"externalId", (o,n) => { (o as LinkedResource).ExternalId = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as LinkedResource).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationName", ApplicationName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
