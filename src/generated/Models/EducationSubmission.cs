using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class EducationSubmission : Entity, IParsable {
        /// <summary>The outcomes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationOutcome>? Outcomes { get; set; }
#nullable restore
#else
        public List<EducationOutcome> Outcomes { get; set; }
#endif
        /// <summary>User who moved the status of this submission to reassigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? ReassignedBy { get; private set; }
#nullable restore
#else
        public IdentitySet ReassignedBy { get; private set; }
#endif
        /// <summary>Moment in time when the submission was reassigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReassignedDateTime { get; private set; }
        /// <summary>Who this submission is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSubmissionRecipient? Recipient { get; set; }
#nullable restore
#else
        public EducationSubmissionRecipient Recipient { get; set; }
#endif
        /// <summary>The resources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationSubmissionResource>? Resources { get; set; }
#nullable restore
#else
        public List<EducationSubmissionResource> Resources { get; set; }
#endif
        /// <summary>Folder where all file resources for this submission need to be stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourcesFolderUrl { get; private set; }
#nullable restore
#else
        public string ResourcesFolderUrl { get; private set; }
#endif
        /// <summary>User who moved the status of this submission to returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? ReturnedBy { get; private set; }
#nullable restore
#else
        public IdentitySet ReturnedBy { get; private set; }
#endif
        /// <summary>Moment in time when the submission was returned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReturnedDateTime { get; private set; }
        /// <summary>Read-only. Possible values are: working, submitted, released, returned, and reassigned. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: reassigned.</summary>
        public EducationSubmissionStatus? Status { get; private set; }
        /// <summary>User who moved the resource into the submitted state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? SubmittedBy { get; private set; }
#nullable restore
#else
        public IdentitySet SubmittedBy { get; private set; }
#endif
        /// <summary>Moment in time when the submission was moved into the submitted state. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? SubmittedDateTime { get; private set; }
        /// <summary>The submittedResources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationSubmissionResource>? SubmittedResources { get; set; }
#nullable restore
#else
        public List<EducationSubmissionResource> SubmittedResources { get; set; }
#endif
        /// <summary>User who moved the resource from submitted into the working state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? UnsubmittedBy { get; private set; }
#nullable restore
#else
        public IdentitySet UnsubmittedBy { get; private set; }
#endif
        /// <summary>Moment in time when the submission was moved from submitted into the working state. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? UnsubmittedDateTime { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationSubmission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSubmission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"outcomes", n => { Outcomes = n.GetCollectionOfObjectValues<EducationOutcome>(EducationOutcome.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reassignedBy", n => { ReassignedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"reassignedDateTime", n => { ReassignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipient", n => { Recipient = n.GetObjectValue<EducationSubmissionRecipient>(EducationSubmissionRecipient.CreateFromDiscriminatorValue); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<EducationSubmissionResource>(EducationSubmissionResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resourcesFolderUrl", n => { ResourcesFolderUrl = n.GetStringValue(); } },
                {"returnedBy", n => { ReturnedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"returnedDateTime", n => { ReturnedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<EducationSubmissionStatus>(); } },
                {"submittedBy", n => { SubmittedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"submittedDateTime", n => { SubmittedDateTime = n.GetDateTimeOffsetValue(); } },
                {"submittedResources", n => { SubmittedResources = n.GetCollectionOfObjectValues<EducationSubmissionResource>(EducationSubmissionResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"unsubmittedBy", n => { UnsubmittedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"unsubmittedDateTime", n => { UnsubmittedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EducationOutcome>("outcomes", Outcomes);
            writer.WriteObjectValue<EducationSubmissionRecipient>("recipient", Recipient);
            writer.WriteCollectionOfObjectValues<EducationSubmissionResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<EducationSubmissionResource>("submittedResources", SubmittedResources);
        }
    }
}
