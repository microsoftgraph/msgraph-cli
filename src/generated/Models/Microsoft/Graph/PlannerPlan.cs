using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerPlan : Entity, IParsable {
        /// <summary>Collection of buckets in the plan. Read-only. Nullable.</summary>
        public List<PlannerBucket> Buckets { get; set; }
        /// <summary>Read-only. The user who created the plan.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Additional details about the plan. Read-only. Nullable.</summary>
        public PlannerPlanDetails Details { get; set; }
        /// <summary>ID of the Group that owns the plan. A valid group must exist before this field can be set. After it is set, this property can’t be updated.</summary>
        public string Owner { get; set; }
        /// <summary>Collection of tasks in the plan. Read-only. Nullable.</summary>
        public List<PlannerTask> Tasks { get; set; }
        /// <summary>Required. Title of the plan.</summary>
        public string Title { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"buckets", (o,n) => { (o as PlannerPlan).Buckets = n.GetCollectionOfObjectValues<PlannerBucket>().ToList(); } },
                {"createdBy", (o,n) => { (o as PlannerPlan).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as PlannerPlan).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"details", (o,n) => { (o as PlannerPlan).Details = n.GetObjectValue<PlannerPlanDetails>(); } },
                {"owner", (o,n) => { (o as PlannerPlan).Owner = n.GetStringValue(); } },
                {"tasks", (o,n) => { (o as PlannerPlan).Tasks = n.GetCollectionOfObjectValues<PlannerTask>().ToList(); } },
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
            writer.WriteCollectionOfObjectValues<PlannerBucket>("buckets", Buckets);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<PlannerPlanDetails>("details", Details);
            writer.WriteStringValue("owner", Owner);
            writer.WriteCollectionOfObjectValues<PlannerTask>("tasks", Tasks);
            writer.WriteStringValue("title", Title);
        }
    }
}
