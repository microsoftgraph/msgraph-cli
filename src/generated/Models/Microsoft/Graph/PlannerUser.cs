using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerUser : Entity, IParsable {
        /// <summary>Read-only. Nullable. Returns the plannerTasks assigned to the user.</summary>
        public List<PlannerPlan> Plans { get; set; }
        /// <summary>Read-only. Nullable. Returns the plannerTasks assigned to the user.</summary>
        public List<PlannerTask> Tasks { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"plans", (o,n) => { (o as PlannerUser).Plans = n.GetCollectionOfObjectValues<PlannerPlan>().ToList(); } },
                {"tasks", (o,n) => { (o as PlannerUser).Tasks = n.GetCollectionOfObjectValues<PlannerTask>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PlannerPlan>("plans", Plans);
            writer.WriteCollectionOfObjectValues<PlannerTask>("tasks", Tasks);
        }
    }
}
