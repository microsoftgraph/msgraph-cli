using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamsTabConfiguration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Url used for rendering tab contents in Teams. Required.</summary>
        public string ContentUrl { get; set; }
        /// <summary>Identifier for the entity hosted by the tab provider.</summary>
        public string EntityId { get; set; }
        /// <summary>Url called by Teams client when a Tab is removed using the Teams Client.</summary>
        public string RemoveUrl { get; set; }
        /// <summary>Url for showing tab contents outside of Teams.</summary>
        public string WebsiteUrl { get; set; }
        /// <summary>
        /// Instantiates a new teamsTabConfiguration and sets the default values.
        /// </summary>
        public TeamsTabConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentUrl", (o,n) => { (o as TeamsTabConfiguration).ContentUrl = n.GetStringValue(); } },
                {"entityId", (o,n) => { (o as TeamsTabConfiguration).EntityId = n.GetStringValue(); } },
                {"removeUrl", (o,n) => { (o as TeamsTabConfiguration).RemoveUrl = n.GetStringValue(); } },
                {"websiteUrl", (o,n) => { (o as TeamsTabConfiguration).WebsiteUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contentUrl", ContentUrl);
            writer.WriteStringValue("entityId", EntityId);
            writer.WriteStringValue("removeUrl", RemoveUrl);
            writer.WriteStringValue("websiteUrl", WebsiteUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
