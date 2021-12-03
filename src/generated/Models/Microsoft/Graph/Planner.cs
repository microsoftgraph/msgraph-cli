using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Planner : Entity, IParsable {
        /// <summary>Read-only. Nullable. Returns a collection of the specified buckets</summary>
        public List<PlannerBucket> Buckets { get; set; }
        /// <summary>Read-only. Nullable. Returns a collection of the specified plans</summary>
        public List<PlannerPlan> Plans { get; set; }
        /// <summary>Read-only. Nullable. Returns a collection of the specified tasks</summary>
        public List<PlannerTask> Tasks { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"buckets", (o,n) => { (o as Planner).Buckets = n.GetCollectionOfObjectValues<PlannerBucket>().ToList(); } },
                {"plans", (o,n) => { (o as Planner).Plans = n.GetCollectionOfObjectValues<PlannerPlan>().ToList(); } },
                {"tasks", (o,n) => { (o as Planner).Tasks = n.GetCollectionOfObjectValues<PlannerTask>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PlannerBucket>("buckets", Buckets);
            writer.WriteCollectionOfObjectValues<PlannerPlan>("plans", Plans);
            writer.WriteCollectionOfObjectValues<PlannerTask>("tasks", Tasks);
        }
    }
}
