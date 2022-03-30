using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessReviewHistoryDefinition : Entity, IParsable {
        public ApiSdk.Models.Microsoft.Graph.UserIdentity CreatedBy { get; set; }
        /// <summary>Timestamp when the access review definition was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Determines which review decisions will be included in the fetched review history data if specified. Optional on create. All decisions will be included by default if no decisions are provided on create. Possible values are: approve, deny, dontKnow, notReviewed, and notNotified.</summary>
        public List<AccessReviewHistoryDecisionFilter?> Decisions { get; set; }
        /// <summary>Name for the access review history data collection. Required.</summary>
        public string DisplayName { get; set; }
        /// <summary>If the accessReviewHistoryDefinition is a recurring definition, instances represent each recurrence. A definition that does not recur will have exactly one instance.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryInstance> Instances { get; set; }
        /// <summary>A timestamp. Reviews ending on or before this date will be included in the fetched history data. Only required if scheduleSettings is not defined.</summary>
        public DateTimeOffset? ReviewHistoryPeriodEndDateTime { get; set; }
        /// <summary>A timestamp. Reviews starting on or before this date will be included in the fetched history data. Only required if scheduleSettings is not defined.</summary>
        public DateTimeOffset? ReviewHistoryPeriodStartDateTime { get; set; }
        /// <summary>The settings for a recurring access review history definition series. Only required if reviewHistoryPeriodStartDateTime or reviewHistoryPeriodEndDateTime are not defined.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryScheduleSettings ScheduleSettings { get; set; }
        /// <summary>Used to scope what reviews are included in the fetched history data. Fetches reviews whose scope matches with this provided scope. Required.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AccessReviewScope> Scopes { get; set; }
        /// <summary>Represents the status of the review history data collection. The possible values are: done, inProgress, error, requested, unknownFutureValue.</summary>
        public AccessReviewHistoryStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewHistoryDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as AccessReviewHistoryDefinition).CreatedBy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.UserIdentity>(ApiSdk.Models.Microsoft.Graph.UserIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as AccessReviewHistoryDefinition).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"decisions", (o,n) => { (o as AccessReviewHistoryDefinition).Decisions = n.GetCollectionOfEnumValues<AccessReviewHistoryDecisionFilter>().ToList(); } },
                {"displayName", (o,n) => { (o as AccessReviewHistoryDefinition).DisplayName = n.GetStringValue(); } },
                {"instances", (o,n) => { (o as AccessReviewHistoryDefinition).Instances = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryInstance>(ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryInstance.CreateFromDiscriminatorValue).ToList(); } },
                {"reviewHistoryPeriodEndDateTime", (o,n) => { (o as AccessReviewHistoryDefinition).ReviewHistoryPeriodEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewHistoryPeriodStartDateTime", (o,n) => { (o as AccessReviewHistoryDefinition).ReviewHistoryPeriodStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"scheduleSettings", (o,n) => { (o as AccessReviewHistoryDefinition).ScheduleSettings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryScheduleSettings>(ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryScheduleSettings.CreateFromDiscriminatorValue); } },
                {"scopes", (o,n) => { (o as AccessReviewHistoryDefinition).Scopes = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewScope>(ApiSdk.Models.Microsoft.Graph.AccessReviewScope.CreateFromDiscriminatorValue).ToList(); } },
                {"status", (o,n) => { (o as AccessReviewHistoryDefinition).Status = n.GetEnumValue<AccessReviewHistoryStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.UserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfEnumValues<AccessReviewHistoryDecisionFilter>("decisions", Decisions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryInstance>("instances", Instances);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodEndDateTime", ReviewHistoryPeriodEndDateTime);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodStartDateTime", ReviewHistoryPeriodStartDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryScheduleSettings>("scheduleSettings", ScheduleSettings);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewScope>("scopes", Scopes);
            writer.WriteEnumValue<AccessReviewHistoryStatus>("status", Status);
        }
    }
}
