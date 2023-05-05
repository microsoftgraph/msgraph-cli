using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class EducationAssignment : Entity, IParsable {
        /// <summary>Optional field to control the assignment behavior for students who are added after the assignment is published. If not specified, defaults to none. Supported values are: none, assignIfOpen. For example, a teacher can use assignIfOpen to indicate that an assignment should be assigned to any new student who joins the class while the assignment is still open, and none to indicate that an assignment should not be assigned to new students.</summary>
        public EducationAddedStudentAction? AddedStudentAction { get; set; }
        /// <summary>Optional field to control the assignment behavior  for adding assignments to students&apos; and teachers&apos; calendars when the assignment is published. The possible values are: none, studentsAndPublisher, studentsAndTeamOwners, unknownFutureValue, and studentsOnly. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: studentsOnly. The default value is none.</summary>
        public EducationAddToCalendarOptions? AddToCalendarAction { get; set; }
        /// <summary>Identifies whether students can submit after the due date. If this property isn&apos;t specified during create, it defaults to true.</summary>
        public bool? AllowLateSubmissions { get; set; }
        /// <summary>Identifies whether students can add their own resources to a submission or if they can only modify resources added by the teacher.</summary>
        public bool? AllowStudentsToAddResourcesToSubmission { get; set; }
        /// <summary>The date when the assignment should become active.  If in the future, the assignment isn&apos;t shown to the student until this date.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? AssignDateTime { get; private set; }
        /// <summary>The moment that the assignment was published to students and the assignment shows up on the students timeline.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? AssignedDateTime { get; private set; }
        /// <summary>Which users, or whole class should receive a submission object once the assignment is published.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationAssignmentRecipient? AssignTo { get; set; }
#nullable restore
#else
        public EducationAssignmentRecipient AssignTo { get; set; }
#endif
        /// <summary>When set, enables users to easily find assignments of a given type.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationCategory>? Categories { get; set; }
#nullable restore
#else
        public List<EducationCategory> Categories { get; set; }
#endif
        /// <summary>Class which this assignment belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClassId { get; set; }
#nullable restore
#else
        public string ClassId { get; set; }
#endif
        /// <summary>Date when the assignment will be closed for submissions. This is an optional field that can be null if the assignment does not allowLateSubmissions or when the closeDateTime is the same as the dueDateTime. But if specified, then the closeDateTime must be greater than or equal to the dueDateTime. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CloseDateTime { get; set; }
        /// <summary>Who created the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy { get; private set; }
#nullable restore
#else
        public IdentitySet CreatedBy { get; private set; }
#endif
        /// <summary>Moment when the assignment was created.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>Name of the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Date when the students assignment is due.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DueDateTime { get; set; }
        /// <summary>Folder URL where all the feedback file resources for this assignment are stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FeedbackResourcesFolderUrl { get; private set; }
#nullable restore
#else
        public string FeedbackResourcesFolderUrl { get; private set; }
#endif
        /// <summary>How the assignment will be graded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationAssignmentGradeType? Grading { get; set; }
#nullable restore
#else
        public EducationAssignmentGradeType Grading { get; set; }
#endif
        /// <summary>Instructions for the assignment.  This along with the display name tell the student what to do.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationItemBody? Instructions { get; set; }
#nullable restore
#else
        public EducationItemBody Instructions { get; set; }
#endif
        /// <summary>Who last modified the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy { get; private set; }
#nullable restore
#else
        public IdentitySet LastModifiedBy { get; private set; }
#endif
        /// <summary>Moment when the assignment was last modified.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>Optional field to specify the URL of the channel to post the assignment publish notification. If not specified or null, defaults to the General channel. This field only applies to assignments where the assignTo value is educationAssignmentClassRecipient. Updating the notificationChannelUrl isn&apos;t allowed after the assignment has been published.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationChannelUrl { get; set; }
#nullable restore
#else
        public string NotificationChannelUrl { get; set; }
#endif
        /// <summary>Learning objects that are associated with this assignment.  Only teachers can modify this list. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationAssignmentResource>? Resources { get; set; }
#nullable restore
#else
        public List<EducationAssignmentResource> Resources { get; set; }
#endif
        /// <summary>Folder URL where all the file resources for this assignment are stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourcesFolderUrl { get; private set; }
#nullable restore
#else
        public string ResourcesFolderUrl { get; private set; }
#endif
        /// <summary>When set, the grading rubric attached to this assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationRubric? Rubric { get; set; }
#nullable restore
#else
        public EducationRubric Rubric { get; set; }
#endif
        /// <summary>Status of the Assignment.  You can&apos;t PATCH this value.  Possible values are: draft, scheduled, published, assigned.</summary>
        public EducationAssignmentStatus? Status { get; private set; }
        /// <summary>Once published, there is a submission object for each student representing their work and grade.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationSubmission>? Submissions { get; set; }
#nullable restore
#else
        public List<EducationSubmission> Submissions { get; set; }
#endif
        /// <summary>The deep link URL for the given assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; private set; }
#nullable restore
#else
        public string WebUrl { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addedStudentAction", n => { AddedStudentAction = n.GetEnumValue<EducationAddedStudentAction>(); } },
                {"addToCalendarAction", n => { AddToCalendarAction = n.GetEnumValue<EducationAddToCalendarOptions>(); } },
                {"allowLateSubmissions", n => { AllowLateSubmissions = n.GetBoolValue(); } },
                {"allowStudentsToAddResourcesToSubmission", n => { AllowStudentsToAddResourcesToSubmission = n.GetBoolValue(); } },
                {"assignDateTime", n => { AssignDateTime = n.GetDateTimeOffsetValue(); } },
                {"assignedDateTime", n => { AssignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"assignTo", n => { AssignTo = n.GetObjectValue<EducationAssignmentRecipient>(EducationAssignmentRecipient.CreateFromDiscriminatorValue); } },
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<EducationCategory>(EducationCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"classId", n => { ClassId = n.GetStringValue(); } },
                {"closeDateTime", n => { CloseDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"dueDateTime", n => { DueDateTime = n.GetDateTimeOffsetValue(); } },
                {"feedbackResourcesFolderUrl", n => { FeedbackResourcesFolderUrl = n.GetStringValue(); } },
                {"grading", n => { Grading = n.GetObjectValue<EducationAssignmentGradeType>(EducationAssignmentGradeType.CreateFromDiscriminatorValue); } },
                {"instructions", n => { Instructions = n.GetObjectValue<EducationItemBody>(EducationItemBody.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notificationChannelUrl", n => { NotificationChannelUrl = n.GetStringValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<EducationAssignmentResource>(EducationAssignmentResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resourcesFolderUrl", n => { ResourcesFolderUrl = n.GetStringValue(); } },
                {"rubric", n => { Rubric = n.GetObjectValue<EducationRubric>(EducationRubric.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<EducationAssignmentStatus>(); } },
                {"submissions", n => { Submissions = n.GetCollectionOfObjectValues<EducationSubmission>(EducationSubmission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EducationAddedStudentAction>("addedStudentAction", AddedStudentAction);
            writer.WriteEnumValue<EducationAddToCalendarOptions>("addToCalendarAction", AddToCalendarAction);
            writer.WriteBoolValue("allowLateSubmissions", AllowLateSubmissions);
            writer.WriteBoolValue("allowStudentsToAddResourcesToSubmission", AllowStudentsToAddResourcesToSubmission);
            writer.WriteObjectValue<EducationAssignmentRecipient>("assignTo", AssignTo);
            writer.WriteCollectionOfObjectValues<EducationCategory>("categories", Categories);
            writer.WriteStringValue("classId", ClassId);
            writer.WriteDateTimeOffsetValue("closeDateTime", CloseDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteObjectValue<EducationAssignmentGradeType>("grading", Grading);
            writer.WriteObjectValue<EducationItemBody>("instructions", Instructions);
            writer.WriteStringValue("notificationChannelUrl", NotificationChannelUrl);
            writer.WriteCollectionOfObjectValues<EducationAssignmentResource>("resources", Resources);
            writer.WriteObjectValue<EducationRubric>("rubric", Rubric);
            writer.WriteCollectionOfObjectValues<EducationSubmission>("submissions", Submissions);
        }
    }
}
