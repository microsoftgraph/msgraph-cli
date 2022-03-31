using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessReviewScheduleSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AccessReviewApplyAction> ApplyActions { get; set; }
        /// <summary>Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.</summary>
        public bool? AutoApplyDecisionsEnabled { get; set; }
        /// <summary>Decision chosen if defaultDecisionEnabled is true. Can be one of Approve, Deny, or Recommendation.</summary>
        public string DefaultDecision { get; set; }
        /// <summary>Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.</summary>
        public bool? DefaultDecisionEnabled { get; set; }
        /// <summary>Duration of each recurrence of review (accessReviewInstance) in number of days.</summary>
        public int? InstanceDurationInDays { get; set; }
        /// <summary>Indicates whether reviewers are required to provide justification with their decision. Default value is false.</summary>
        public bool? JustificationRequiredOnApproval { get; set; }
        /// <summary>Indicates whether emails are enabled or disabled. Default value is false.</summary>
        public bool? MailNotificationsEnabled { get; set; }
        /// <summary>Indicates whether decision recommendations are enabled or disabled.</summary>
        public bool? RecommendationsEnabled { get; set; }
        /// <summary>Detailed settings for recurrence using the standard Outlook recurrence object.  Note: Only dayOfMonth, interval, and type (weekly, absoluteMonthly) properties are supported. Use the property startDate on recurrenceRange to determine the day the review starts.</summary>
        public ApiSdk.Models.Microsoft.Graph.PatternedRecurrence Recurrence { get; set; }
        /// <summary>Indicates whether reminders are enabled or disabled. Default value is false.</summary>
        public bool? ReminderNotificationsEnabled { get; set; }
        /// <summary>
        /// Instantiates a new accessReviewScheduleSettings and sets the default values.
        /// </summary>
        public AccessReviewScheduleSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AccessReviewScheduleSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewScheduleSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applyActions", (o,n) => { (o as AccessReviewScheduleSettings).ApplyActions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewApplyAction>(ApiSdk.Models.Microsoft.Graph.AccessReviewApplyAction.CreateFromDiscriminatorValue).ToList(); } },
                {"autoApplyDecisionsEnabled", (o,n) => { (o as AccessReviewScheduleSettings).AutoApplyDecisionsEnabled = n.GetBoolValue(); } },
                {"defaultDecision", (o,n) => { (o as AccessReviewScheduleSettings).DefaultDecision = n.GetStringValue(); } },
                {"defaultDecisionEnabled", (o,n) => { (o as AccessReviewScheduleSettings).DefaultDecisionEnabled = n.GetBoolValue(); } },
                {"instanceDurationInDays", (o,n) => { (o as AccessReviewScheduleSettings).InstanceDurationInDays = n.GetIntValue(); } },
                {"justificationRequiredOnApproval", (o,n) => { (o as AccessReviewScheduleSettings).JustificationRequiredOnApproval = n.GetBoolValue(); } },
                {"mailNotificationsEnabled", (o,n) => { (o as AccessReviewScheduleSettings).MailNotificationsEnabled = n.GetBoolValue(); } },
                {"recommendationsEnabled", (o,n) => { (o as AccessReviewScheduleSettings).RecommendationsEnabled = n.GetBoolValue(); } },
                {"recurrence", (o,n) => { (o as AccessReviewScheduleSettings).Recurrence = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PatternedRecurrence>(ApiSdk.Models.Microsoft.Graph.PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderNotificationsEnabled", (o,n) => { (o as AccessReviewScheduleSettings).ReminderNotificationsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessReviewApplyAction>("applyActions", ApplyActions);
            writer.WriteBoolValue("autoApplyDecisionsEnabled", AutoApplyDecisionsEnabled);
            writer.WriteStringValue("defaultDecision", DefaultDecision);
            writer.WriteBoolValue("defaultDecisionEnabled", DefaultDecisionEnabled);
            writer.WriteIntValue("instanceDurationInDays", InstanceDurationInDays);
            writer.WriteBoolValue("justificationRequiredOnApproval", JustificationRequiredOnApproval);
            writer.WriteBoolValue("mailNotificationsEnabled", MailNotificationsEnabled);
            writer.WriteBoolValue("recommendationsEnabled", RecommendationsEnabled);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteBoolValue("reminderNotificationsEnabled", ReminderNotificationsEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
