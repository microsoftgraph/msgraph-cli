using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerBucket : Entity, IParsable {
        /// <summary>Name of the bucket.</summary>
        public string Name { get; set; }
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
        public string OrderHint { get; set; }
        /// <summary>Plan ID to which the bucket belongs.</summary>
        public string PlanId { get; set; }
        /// <summary>Read-only. Nullable. The collection of tasks in the bucket.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PlannerTask> Tasks { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.PlannerBucket CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerBucket();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"name", (o,n) => { (o as PlannerBucket).Name = n.GetStringValue(); } },
                {"orderHint", (o,n) => { (o as PlannerBucket).OrderHint = n.GetStringValue(); } },
                {"planId", (o,n) => { (o as PlannerBucket).PlanId = n.GetStringValue(); } },
                {"tasks", (o,n) => { (o as PlannerBucket).Tasks = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerTask>(ApiSdk.Models.Microsoft.Graph.PlannerTask.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("orderHint", OrderHint);
            writer.WriteStringValue("planId", PlanId);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerTask>("tasks", Tasks);
        }
    }
}
