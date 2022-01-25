using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerTask : Entity, IParsable {
        /// <summary>Number of checklist items with value set to false, representing incomplete items.</summary>
        public int? ActiveChecklistItemCount { get; set; }
        /// <summary>The categories to which the task has been applied. See applied Categories for possible values.</summary>
        public PlannerAppliedCategories AppliedCategories { get; set; }
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.</summary>
        public PlannerAssignedToTaskBoardTaskFormat AssignedToTaskBoardFormat { get; set; }
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
        public string AssigneePriority { get; set; }
        /// <summary>The set of assignees the task is assigned to.</summary>
        public PlannerAssignments Assignments { get; set; }
        /// <summary>Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.</summary>
        public string BucketId { get; set; }
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by bucket.</summary>
        public PlannerBucketTaskBoardTaskFormat BucketTaskBoardFormat { get; set; }
        /// <summary>Number of checklist items that are present on the task.</summary>
        public int? ChecklistItemCount { get; set; }
        /// <summary>Identity of the user that completed the task.</summary>
        public IdentitySet CompletedBy { get; set; }
        /// <summary>Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.</summary>
        public string ConversationThreadId { get; set; }
        /// <summary>Identity of the user that created the task.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read-only. Nullable. Additional details about the task.</summary>
        public PlannerTaskDetails Details { get; set; }
        /// <summary>Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DueDateTime { get; set; }
        /// <summary>Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.</summary>
        public bool? HasDescription { get; set; }
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
        public string OrderHint { get; set; }
        /// <summary>Percentage of task completion. When set to 100, the task is considered completed.</summary>
        public int? PercentComplete { get; set; }
        /// <summary>Plan ID to which the task belongs.</summary>
        public string PlanId { get; set; }
        /// <summary>This sets the type of preview that shows up on the task. Possible values are: automatic, noPreview, checklist, description, reference.</summary>
        public PlannerPreviewType? PreviewType { get; set; }
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by progress.</summary>
        public PlannerProgressTaskBoardTaskFormat ProgressTaskBoardFormat { get; set; }
        /// <summary>Number of external references that exist on the task.</summary>
        public int? ReferenceCount { get; set; }
        /// <summary>Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Title of the task.</summary>
        public string Title { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeChecklistItemCount", (o,n) => { (o as PlannerTask).ActiveChecklistItemCount = n.GetIntValue(); } },
                {"appliedCategories", (o,n) => { (o as PlannerTask).AppliedCategories = n.GetObjectValue<PlannerAppliedCategories>(); } },
                {"assignedToTaskBoardFormat", (o,n) => { (o as PlannerTask).AssignedToTaskBoardFormat = n.GetObjectValue<PlannerAssignedToTaskBoardTaskFormat>(); } },
                {"assigneePriority", (o,n) => { (o as PlannerTask).AssigneePriority = n.GetStringValue(); } },
                {"assignments", (o,n) => { (o as PlannerTask).Assignments = n.GetObjectValue<PlannerAssignments>(); } },
                {"bucketId", (o,n) => { (o as PlannerTask).BucketId = n.GetStringValue(); } },
                {"bucketTaskBoardFormat", (o,n) => { (o as PlannerTask).BucketTaskBoardFormat = n.GetObjectValue<PlannerBucketTaskBoardTaskFormat>(); } },
                {"checklistItemCount", (o,n) => { (o as PlannerTask).ChecklistItemCount = n.GetIntValue(); } },
                {"completedBy", (o,n) => { (o as PlannerTask).CompletedBy = n.GetObjectValue<IdentitySet>(); } },
                {"completedDateTime", (o,n) => { (o as PlannerTask).CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"conversationThreadId", (o,n) => { (o as PlannerTask).ConversationThreadId = n.GetStringValue(); } },
                {"createdBy", (o,n) => { (o as PlannerTask).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as PlannerTask).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"details", (o,n) => { (o as PlannerTask).Details = n.GetObjectValue<PlannerTaskDetails>(); } },
                {"dueDateTime", (o,n) => { (o as PlannerTask).DueDateTime = n.GetDateTimeOffsetValue(); } },
                {"hasDescription", (o,n) => { (o as PlannerTask).HasDescription = n.GetBoolValue(); } },
                {"orderHint", (o,n) => { (o as PlannerTask).OrderHint = n.GetStringValue(); } },
                {"percentComplete", (o,n) => { (o as PlannerTask).PercentComplete = n.GetIntValue(); } },
                {"planId", (o,n) => { (o as PlannerTask).PlanId = n.GetStringValue(); } },
                {"previewType", (o,n) => { (o as PlannerTask).PreviewType = n.GetEnumValue<PlannerPreviewType>(); } },
                {"progressTaskBoardFormat", (o,n) => { (o as PlannerTask).ProgressTaskBoardFormat = n.GetObjectValue<PlannerProgressTaskBoardTaskFormat>(); } },
                {"referenceCount", (o,n) => { (o as PlannerTask).ReferenceCount = n.GetIntValue(); } },
                {"startDateTime", (o,n) => { (o as PlannerTask).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"title", (o,n) => { (o as PlannerTask).Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeChecklistItemCount", ActiveChecklistItemCount);
            writer.WriteObjectValue<PlannerAppliedCategories>("appliedCategories", AppliedCategories);
            writer.WriteObjectValue<PlannerAssignedToTaskBoardTaskFormat>("assignedToTaskBoardFormat", AssignedToTaskBoardFormat);
            writer.WriteStringValue("assigneePriority", AssigneePriority);
            writer.WriteObjectValue<PlannerAssignments>("assignments", Assignments);
            writer.WriteStringValue("bucketId", BucketId);
            writer.WriteObjectValue<PlannerBucketTaskBoardTaskFormat>("bucketTaskBoardFormat", BucketTaskBoardFormat);
            writer.WriteIntValue("checklistItemCount", ChecklistItemCount);
            writer.WriteObjectValue<IdentitySet>("completedBy", CompletedBy);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<PlannerTaskDetails>("details", Details);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteBoolValue("hasDescription", HasDescription);
            writer.WriteStringValue("orderHint", OrderHint);
            writer.WriteIntValue("percentComplete", PercentComplete);
            writer.WriteStringValue("planId", PlanId);
            writer.WriteEnumValue<PlannerPreviewType>("previewType", PreviewType);
            writer.WriteObjectValue<PlannerProgressTaskBoardTaskFormat>("progressTaskBoardFormat", ProgressTaskBoardFormat);
            writer.WriteIntValue("referenceCount", ReferenceCount);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("title", Title);
        }
    }
}
