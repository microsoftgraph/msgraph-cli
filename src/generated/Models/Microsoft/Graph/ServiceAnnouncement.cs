using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ServiceAnnouncement : Entity, IParsable {
        /// <summary>A collection of service health information for tenant. This property is a contained navigation property, it is nullable and readonly.</summary>
        public List<ServiceHealth> HealthOverviews { get; set; }
        /// <summary>A collection of service issues for tenant. This property is a contained navigation property, it is nullable and readonly.</summary>
        public List<ServiceHealthIssue> Issues { get; set; }
        /// <summary>A collection of service messages for tenant. This property is a contained navigation property, it is nullable and readonly.</summary>
        public List<ServiceUpdateMessage> Messages { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"healthOverviews", (o,n) => { (o as ServiceAnnouncement).HealthOverviews = n.GetCollectionOfObjectValues<ServiceHealth>().ToList(); } },
                {"issues", (o,n) => { (o as ServiceAnnouncement).Issues = n.GetCollectionOfObjectValues<ServiceHealthIssue>().ToList(); } },
                {"messages", (o,n) => { (o as ServiceAnnouncement).Messages = n.GetCollectionOfObjectValues<ServiceUpdateMessage>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ServiceHealth>("healthOverviews", HealthOverviews);
            writer.WriteCollectionOfObjectValues<ServiceHealthIssue>("issues", Issues);
            writer.WriteCollectionOfObjectValues<ServiceUpdateMessage>("messages", Messages);
        }
    }
}
