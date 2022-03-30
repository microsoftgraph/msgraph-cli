using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerPlanDetails : Entity, IParsable {
        /// <summary>An object that specifies the descriptions of the six categories that can be associated with tasks in the plan</summary>
        public ApiSdk.Models.Microsoft.Graph.PlannerCategoryDescriptions CategoryDescriptions { get; set; }
        /// <summary>Set of user ids that this plan is shared with. If you are leveraging Microsoft 365 groups, use the Groups API to manage group membership to share the group's plan. You can also add existing members of the group to this collection though it is not required for them to access the plan owned by the group.</summary>
        public ApiSdk.Models.Microsoft.Graph.PlannerUserIds SharedWith { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.PlannerPlanDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerPlanDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categoryDescriptions", (o,n) => { (o as PlannerPlanDetails).CategoryDescriptions = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerCategoryDescriptions>(ApiSdk.Models.Microsoft.Graph.PlannerCategoryDescriptions.CreateFromDiscriminatorValue); } },
                {"sharedWith", (o,n) => { (o as PlannerPlanDetails).SharedWith = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerUserIds>(ApiSdk.Models.Microsoft.Graph.PlannerUserIds.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerCategoryDescriptions>("categoryDescriptions", CategoryDescriptions);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerUserIds>("sharedWith", SharedWith);
        }
    }
}
