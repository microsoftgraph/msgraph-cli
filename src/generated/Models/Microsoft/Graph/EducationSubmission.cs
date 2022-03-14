using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationSubmission : Entity, IParsable {
        /// <summary>Read-Write. Nullable.</summary>
        public List<EducationOutcome> Outcomes { get; set; }
        /// <summary>User who moved the status of this submission to reassigned.</summary>
        public IdentitySet ReassignedBy { get; set; }
        /// <summary>Moment in time when the submission was reassigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReassignedDateTime { get; set; }
        /// <summary>Who this submission is assigned to.</summary>
        public EducationSubmissionRecipient Recipient { get; set; }
        /// <summary>Nullable.</summary>
        public List<EducationSubmissionResource> Resources { get; set; }
        /// <summary>Folder where all file resources for this submission need to be stored.</summary>
        public string ResourcesFolderUrl { get; set; }
        /// <summary>User who moved the status of this submission to returned.</summary>
        public IdentitySet ReturnedBy { get; set; }
        /// <summary>Moment in time when the submission was returned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReturnedDateTime { get; set; }
        /// <summary>Read-only. Possible values are: working, submitted, released, returned, unknownFutureValue and reassigned. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: reassigned.</summary>
        public EducationSubmissionStatus? Status { get; set; }
        /// <summary>User who moved the resource into the submitted state.</summary>
        public IdentitySet SubmittedBy { get; set; }
        /// <summary>Moment in time when the submission was moved into the submitted state. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? SubmittedDateTime { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<EducationSubmissionResource> SubmittedResources { get; set; }
        /// <summary>User who moved the resource from submitted into the working state.</summary>
        public IdentitySet UnsubmittedBy { get; set; }
        /// <summary>Moment in time when the submission was moved from submitted into the working state. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? UnsubmittedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationSubmission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSubmission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"outcomes", (o,n) => { (o as EducationSubmission).Outcomes = n.GetCollectionOfObjectValues<EducationOutcome>(EducationOutcome.CreateFromDiscriminatorValue).ToList(); } },
                {"reassignedBy", (o,n) => { (o as EducationSubmission).ReassignedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"reassignedDateTime", (o,n) => { (o as EducationSubmission).ReassignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipient", (o,n) => { (o as EducationSubmission).Recipient = n.GetObjectValue<EducationSubmissionRecipient>(EducationSubmissionRecipient.CreateFromDiscriminatorValue); } },
                {"resources", (o,n) => { (o as EducationSubmission).Resources = n.GetCollectionOfObjectValues<EducationSubmissionResource>(EducationSubmissionResource.CreateFromDiscriminatorValue).ToList(); } },
                {"resourcesFolderUrl", (o,n) => { (o as EducationSubmission).ResourcesFolderUrl = n.GetStringValue(); } },
                {"returnedBy", (o,n) => { (o as EducationSubmission).ReturnedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"returnedDateTime", (o,n) => { (o as EducationSubmission).ReturnedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as EducationSubmission).Status = n.GetEnumValue<EducationSubmissionStatus>(); } },
                {"submittedBy", (o,n) => { (o as EducationSubmission).SubmittedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"submittedDateTime", (o,n) => { (o as EducationSubmission).SubmittedDateTime = n.GetDateTimeOffsetValue(); } },
                {"submittedResources", (o,n) => { (o as EducationSubmission).SubmittedResources = n.GetCollectionOfObjectValues<EducationSubmissionResource>(EducationSubmissionResource.CreateFromDiscriminatorValue).ToList(); } },
                {"unsubmittedBy", (o,n) => { (o as EducationSubmission).UnsubmittedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"unsubmittedDateTime", (o,n) => { (o as EducationSubmission).UnsubmittedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EducationOutcome>("outcomes", Outcomes);
            writer.WriteObjectValue<IdentitySet>("reassignedBy", ReassignedBy);
            writer.WriteDateTimeOffsetValue("reassignedDateTime", ReassignedDateTime);
            writer.WriteObjectValue<EducationSubmissionRecipient>("recipient", Recipient);
            writer.WriteCollectionOfObjectValues<EducationSubmissionResource>("resources", Resources);
            writer.WriteStringValue("resourcesFolderUrl", ResourcesFolderUrl);
            writer.WriteObjectValue<IdentitySet>("returnedBy", ReturnedBy);
            writer.WriteDateTimeOffsetValue("returnedDateTime", ReturnedDateTime);
            writer.WriteEnumValue<EducationSubmissionStatus>("status", Status);
            writer.WriteObjectValue<IdentitySet>("submittedBy", SubmittedBy);
            writer.WriteDateTimeOffsetValue("submittedDateTime", SubmittedDateTime);
            writer.WriteCollectionOfObjectValues<EducationSubmissionResource>("submittedResources", SubmittedResources);
            writer.WriteObjectValue<IdentitySet>("unsubmittedBy", UnsubmittedBy);
            writer.WriteDateTimeOffsetValue("unsubmittedDateTime", UnsubmittedDateTime);
        }
    }
}
