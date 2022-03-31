using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ServiceAnnouncement : Entity, IParsable {
        /// <summary>A collection of service health information for tenant. This property is a contained navigation property, it is nullable and readonly.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ServiceHealth> HealthOverviews { get; set; }
        /// <summary>A collection of service issues for tenant. This property is a contained navigation property, it is nullable and readonly.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ServiceHealthIssue> Issues { get; set; }
        /// <summary>A collection of service messages for tenant. This property is a contained navigation property, it is nullable and readonly.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ServiceUpdateMessage> Messages { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ServiceAnnouncement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceAnnouncement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"healthOverviews", (o,n) => { (o as ServiceAnnouncement).HealthOverviews = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ServiceHealth>(ApiSdk.Models.Microsoft.Graph.ServiceHealth.CreateFromDiscriminatorValue).ToList(); } },
                {"issues", (o,n) => { (o as ServiceAnnouncement).Issues = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ServiceHealthIssue>(ApiSdk.Models.Microsoft.Graph.ServiceHealthIssue.CreateFromDiscriminatorValue).ToList(); } },
                {"messages", (o,n) => { (o as ServiceAnnouncement).Messages = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ServiceUpdateMessage>(ApiSdk.Models.Microsoft.Graph.ServiceUpdateMessage.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ServiceHealth>("healthOverviews", HealthOverviews);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ServiceHealthIssue>("issues", Issues);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ServiceUpdateMessage>("messages", Messages);
        }
    }
}
