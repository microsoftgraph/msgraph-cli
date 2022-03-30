using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerUser : Entity, IParsable {
        /// <summary>Read-only. Nullable. Returns the plannerTasks assigned to the user.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PlannerPlan> Plans { get; set; }
        /// <summary>Read-only. Nullable. Returns the plannerPlans shared with the user.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PlannerTask> Tasks { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.PlannerUser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"plans", (o,n) => { (o as PlannerUser).Plans = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerPlan>(ApiSdk.Models.Microsoft.Graph.PlannerPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"tasks", (o,n) => { (o as PlannerUser).Tasks = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerTask>(ApiSdk.Models.Microsoft.Graph.PlannerTask.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerPlan>("plans", Plans);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerTask>("tasks", Tasks);
        }
    }
}
