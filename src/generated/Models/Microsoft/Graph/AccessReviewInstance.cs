using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessReviewInstance : Entity, IParsable {
        /// <summary>Returns the collection of reviewers who were contacted to complete this review. While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities. Supports $select. Read-only.</summary>
        public List<AccessReviewReviewer> ContactedReviewers { get; set; }
        /// <summary>Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.</summary>
        public List<AccessReviewInstanceDecisionItem> Decisions { get; set; }
        /// <summary>DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. Supports $select.</summary>
        public List<AccessReviewReviewerScope> FallbackReviewers { get; set; }
        /// <summary>This collection of access review scopes is used to define who the reviewers are. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.</summary>
        public List<AccessReviewReviewerScope> Reviewers { get; set; }
        /// <summary>Created based on scope and instanceEnumerationScope at the accessReviewScheduleDefinition level. Defines the scope of users reviewed in a group. Supports $select and $filter (contains only). Read-only.</summary>
        public AccessReviewScope Scope { get; set; }
        /// <summary>DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contactedReviewers", (o,n) => { (o as AccessReviewInstance).ContactedReviewers = n.GetCollectionOfObjectValues<AccessReviewReviewer>().ToList(); } },
                {"decisions", (o,n) => { (o as AccessReviewInstance).Decisions = n.GetCollectionOfObjectValues<AccessReviewInstanceDecisionItem>().ToList(); } },
                {"endDateTime", (o,n) => { (o as AccessReviewInstance).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"fallbackReviewers", (o,n) => { (o as AccessReviewInstance).FallbackReviewers = n.GetCollectionOfObjectValues<AccessReviewReviewerScope>().ToList(); } },
                {"reviewers", (o,n) => { (o as AccessReviewInstance).Reviewers = n.GetCollectionOfObjectValues<AccessReviewReviewerScope>().ToList(); } },
                {"scope", (o,n) => { (o as AccessReviewInstance).Scope = n.GetObjectValue<AccessReviewScope>(); } },
                {"startDateTime", (o,n) => { (o as AccessReviewInstance).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as AccessReviewInstance).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewer>("contactedReviewers", ContactedReviewers);
            writer.WriteCollectionOfObjectValues<AccessReviewInstanceDecisionItem>("decisions", Decisions);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewerScope>("fallbackReviewers", FallbackReviewers);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteObjectValue<AccessReviewScope>("scope", Scope);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
        }
    }
}
