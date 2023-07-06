using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public class Run : Entity, IParsable {
        /// <summary>The date time that the run completed. Value is null if the workflow hasn&apos;t completed.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>The number of tasks that failed in the run execution.</summary>
        public int? FailedTasksCount { get; set; }
        /// <summary>The number of users that failed in the run execution.</summary>
        public int? FailedUsersCount { get; set; }
        /// <summary>The datetime that the run was last updated.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The processingStatus property</summary>
        public LifecycleWorkflowProcessingStatus? ProcessingStatus { get; set; }
        /// <summary>The date time that the run is scheduled to be executed for a workflow.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? ScheduledDateTime { get; set; }
        /// <summary>The date time that the run execution started.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? StartedDateTime { get; set; }
        /// <summary>The number of successfully completed users in the run.</summary>
        public int? SuccessfulUsersCount { get; set; }
        /// <summary>The related taskProcessingResults.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TaskProcessingResult>? TaskProcessingResults { get; set; }
#nullable restore
#else
        public List<TaskProcessingResult> TaskProcessingResults { get; set; }
#endif
        /// <summary>The totalTasksCount property</summary>
        public int? TotalTasksCount { get; set; }
        /// <summary>The total number of unprocessed tasks in the run execution.</summary>
        public int? TotalUnprocessedTasksCount { get; set; }
        /// <summary>The total number of users in the workflow execution.</summary>
        public int? TotalUsersCount { get; set; }
        /// <summary>The associated individual user execution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserProcessingResult>? UserProcessingResults { get; set; }
#nullable restore
#else
        public List<UserProcessingResult> UserProcessingResults { get; set; }
#endif
        /// <summary>The workflowExecutionType property</summary>
        public ApiSdk.Models.IdentityGovernance.WorkflowExecutionType? WorkflowExecutionType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Run CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Run();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"failedTasksCount", n => { FailedTasksCount = n.GetIntValue(); } },
                {"failedUsersCount", n => { FailedUsersCount = n.GetIntValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"processingStatus", n => { ProcessingStatus = n.GetEnumValue<LifecycleWorkflowProcessingStatus>(); } },
                {"scheduledDateTime", n => { ScheduledDateTime = n.GetDateTimeOffsetValue(); } },
                {"startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"successfulUsersCount", n => { SuccessfulUsersCount = n.GetIntValue(); } },
                {"taskProcessingResults", n => { TaskProcessingResults = n.GetCollectionOfObjectValues<TaskProcessingResult>(TaskProcessingResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totalTasksCount", n => { TotalTasksCount = n.GetIntValue(); } },
                {"totalUnprocessedTasksCount", n => { TotalUnprocessedTasksCount = n.GetIntValue(); } },
                {"totalUsersCount", n => { TotalUsersCount = n.GetIntValue(); } },
                {"userProcessingResults", n => { UserProcessingResults = n.GetCollectionOfObjectValues<UserProcessingResult>(UserProcessingResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"workflowExecutionType", n => { WorkflowExecutionType = n.GetEnumValue<WorkflowExecutionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteIntValue("failedTasksCount", FailedTasksCount);
            writer.WriteIntValue("failedUsersCount", FailedUsersCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteEnumValue<LifecycleWorkflowProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteDateTimeOffsetValue("scheduledDateTime", ScheduledDateTime);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteIntValue("successfulUsersCount", SuccessfulUsersCount);
            writer.WriteCollectionOfObjectValues<TaskProcessingResult>("taskProcessingResults", TaskProcessingResults);
            writer.WriteIntValue("totalTasksCount", TotalTasksCount);
            writer.WriteIntValue("totalUnprocessedTasksCount", TotalUnprocessedTasksCount);
            writer.WriteIntValue("totalUsersCount", TotalUsersCount);
            writer.WriteCollectionOfObjectValues<UserProcessingResult>("userProcessingResults", UserProcessingResults);
            writer.WriteEnumValue<WorkflowExecutionType>("workflowExecutionType", WorkflowExecutionType);
        }
    }
}
