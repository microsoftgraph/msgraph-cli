using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerPlan : Entity, IParsable {
        /// <summary>Read-only. Nullable. Collection of buckets in the plan.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PlannerBucket> Buckets { get; set; }
        /// <summary>Read-only. The user who created the plan.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySet CreatedBy { get; set; }
        /// <summary>Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read-only. Nullable. Additional details about the plan.</summary>
        public ApiSdk.Models.Microsoft.Graph.PlannerPlanDetails Details { get; set; }
        /// <summary>ID of the Group that owns the plan. A valid group must exist before this field can be set. After it is set, this property can’t be updated.</summary>
        public string Owner { get; set; }
        /// <summary>Read-only. Nullable. Collection of tasks in the plan.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PlannerTask> Tasks { get; set; }
        /// <summary>Required. Title of the plan.</summary>
        public string Title { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.PlannerPlan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerPlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"buckets", (o,n) => { (o as PlannerPlan).Buckets = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerBucket>(ApiSdk.Models.Microsoft.Graph.PlannerBucket.CreateFromDiscriminatorValue).ToList(); } },
                {"createdBy", (o,n) => { (o as PlannerPlan).CreatedBy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as PlannerPlan).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"details", (o,n) => { (o as PlannerPlan).Details = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerPlanDetails>(ApiSdk.Models.Microsoft.Graph.PlannerPlanDetails.CreateFromDiscriminatorValue); } },
                {"owner", (o,n) => { (o as PlannerPlan).Owner = n.GetStringValue(); } },
                {"tasks", (o,n) => { (o as PlannerPlan).Tasks = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerTask>(ApiSdk.Models.Microsoft.Graph.PlannerTask.CreateFromDiscriminatorValue).ToList(); } },
                {"title", (o,n) => { (o as PlannerPlan).Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerBucket>("buckets", Buckets);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerPlanDetails>("details", Details);
            writer.WriteStringValue("owner", Owner);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PlannerTask>("tasks", Tasks);
            writer.WriteStringValue("title", Title);
        }
    }
}
