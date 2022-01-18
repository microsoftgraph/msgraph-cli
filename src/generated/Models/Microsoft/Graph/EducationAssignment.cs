using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationAssignment : Entity, IParsable {
        /// <summary>Optional field to control the assignment behavior for students who are added after the assignment is published. If not specified, defaults to none value. Currently supports only two values: none or assignIfOpen.</summary>
        public EducationAddedStudentAction? AddedStudentAction { get; set; }
        /// <summary>Optional field to control the assignment behavior  for adding assignments to students' and teachers' calendars when the assignment is published. The possible values are: none, studentsAndPublisher, studentsAndTeamOwners, unknownFutureValue, and studentsOnly. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: studentsOnly. The default value is none.</summary>
        public EducationAddToCalendarOptions? AddToCalendarAction { get; set; }
        /// <summary>Identifies whether students can submit after the due date. If this property is not specified during create, it defaults to true.</summary>
        public bool? AllowLateSubmissions { get; set; }
        /// <summary>Identifies whether students can add their own resources to a submission or if they can only modify resources added by the teacher.</summary>
        public bool? AllowStudentsToAddResourcesToSubmission { get; set; }
        /// <summary>The date when the assignment should become active.  If in the future, the assignment is not shown to the student until this date.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? AssignDateTime { get; set; }
        /// <summary>The moment that the assignment was published to students and the assignment shows up on the students timeline.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? AssignedDateTime { get; set; }
        /// <summary>Which users, or whole class should receive a submission object once the assignment is published.</summary>
        public EducationAssignmentRecipient AssignTo { get; set; }
        /// <summary>When set, enables users to easily find assignments of a given type.  Read-only. Nullable.</summary>
        public List<EducationCategory> Categories { get; set; }
        /// <summary>Class which this assignment belongs.</summary>
        public string ClassId { get; set; }
        /// <summary>Date when the assignment will be closed for submissions. This is an optional field that can be null if the assignment does not allowLateSubmissions or when the closeDateTime is the same as the dueDateTime. But if specified, then the closeDateTime must be greater than or equal to the dueDateTime. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CloseDateTime { get; set; }
        /// <summary>Who created the assignment.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>Moment when the assignment was created.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Name of the assignment.</summary>
        public string DisplayName { get; set; }
        /// <summary>Date when the students assignment is due.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DueDateTime { get; set; }
        /// <summary>How the assignment will be graded.</summary>
        public EducationAssignmentGradeType Grading { get; set; }
        /// <summary>Instructions for the assignment.  This along with the display name tell the student what to do.</summary>
        public EducationItemBody Instructions { get; set; }
        /// <summary>Who last modified the assignment.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>Moment when the assignment was last modified.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Optional field to specify the URL of the channel to post the assignment publish notification. If not specified or null, defaults to the General channel. This field only applies to assignments where the assignTo value is educationAssignmentClassRecipient. Updating the notificationChannelUrl is not allowed after the assignment has been published.</summary>
        public string NotificationChannelUrl { get; set; }
        /// <summary>Learning objects that are associated with this assignment.  Only teachers can modify this list. Nullable.</summary>
        public List<EducationAssignmentResource> Resources { get; set; }
        /// <summary>Folder URL where all the file resources for this assignment are stored.</summary>
        public string ResourcesFolderUrl { get; set; }
        /// <summary>When set, the grading rubric attached to this assignment.</summary>
        public EducationRubric Rubric { get; set; }
        /// <summary>Status of the Assignment.  You can not PATCH this value.  Possible values are: draft, scheduled, published, assigned.</summary>
        public EducationAssignmentStatus? Status { get; set; }
        /// <summary>Once published, there is a submission object for each student representing their work and grade.  Read-only. Nullable.</summary>
        public List<EducationSubmission> Submissions { get; set; }
        /// <summary>The deep link URL for the given assignment.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addedStudentAction", (o,n) => { (o as EducationAssignment).AddedStudentAction = n.GetEnumValue<EducationAddedStudentAction>(); } },
                {"addToCalendarAction", (o,n) => { (o as EducationAssignment).AddToCalendarAction = n.GetEnumValue<EducationAddToCalendarOptions>(); } },
                {"allowLateSubmissions", (o,n) => { (o as EducationAssignment).AllowLateSubmissions = n.GetBoolValue(); } },
                {"allowStudentsToAddResourcesToSubmission", (o,n) => { (o as EducationAssignment).AllowStudentsToAddResourcesToSubmission = n.GetBoolValue(); } },
                {"assignDateTime", (o,n) => { (o as EducationAssignment).AssignDateTime = n.GetDateTimeOffsetValue(); } },
                {"assignedDateTime", (o,n) => { (o as EducationAssignment).AssignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"assignTo", (o,n) => { (o as EducationAssignment).AssignTo = n.GetObjectValue<EducationAssignmentRecipient>(); } },
                {"categories", (o,n) => { (o as EducationAssignment).Categories = n.GetCollectionOfObjectValues<EducationCategory>().ToList(); } },
                {"classId", (o,n) => { (o as EducationAssignment).ClassId = n.GetStringValue(); } },
                {"closeDateTime", (o,n) => { (o as EducationAssignment).CloseDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", (o,n) => { (o as EducationAssignment).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as EducationAssignment).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as EducationAssignment).DisplayName = n.GetStringValue(); } },
                {"dueDateTime", (o,n) => { (o as EducationAssignment).DueDateTime = n.GetDateTimeOffsetValue(); } },
                {"grading", (o,n) => { (o as EducationAssignment).Grading = n.GetObjectValue<EducationAssignmentGradeType>(); } },
                {"instructions", (o,n) => { (o as EducationAssignment).Instructions = n.GetObjectValue<EducationItemBody>(); } },
                {"lastModifiedBy", (o,n) => { (o as EducationAssignment).LastModifiedBy = n.GetObjectValue<IdentitySet>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as EducationAssignment).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notificationChannelUrl", (o,n) => { (o as EducationAssignment).NotificationChannelUrl = n.GetStringValue(); } },
                {"resources", (o,n) => { (o as EducationAssignment).Resources = n.GetCollectionOfObjectValues<EducationAssignmentResource>().ToList(); } },
                {"resourcesFolderUrl", (o,n) => { (o as EducationAssignment).ResourcesFolderUrl = n.GetStringValue(); } },
                {"rubric", (o,n) => { (o as EducationAssignment).Rubric = n.GetObjectValue<EducationRubric>(); } },
                {"status", (o,n) => { (o as EducationAssignment).Status = n.GetEnumValue<EducationAssignmentStatus>(); } },
                {"submissions", (o,n) => { (o as EducationAssignment).Submissions = n.GetCollectionOfObjectValues<EducationSubmission>().ToList(); } },
                {"webUrl", (o,n) => { (o as EducationAssignment).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EducationAddedStudentAction>("addedStudentAction", AddedStudentAction);
            writer.WriteEnumValue<EducationAddToCalendarOptions>("addToCalendarAction", AddToCalendarAction);
            writer.WriteBoolValue("allowLateSubmissions", AllowLateSubmissions);
            writer.WriteBoolValue("allowStudentsToAddResourcesToSubmission", AllowStudentsToAddResourcesToSubmission);
            writer.WriteDateTimeOffsetValue("assignDateTime", AssignDateTime);
            writer.WriteDateTimeOffsetValue("assignedDateTime", AssignedDateTime);
            writer.WriteObjectValue<EducationAssignmentRecipient>("assignTo", AssignTo);
            writer.WriteCollectionOfObjectValues<EducationCategory>("categories", Categories);
            writer.WriteStringValue("classId", ClassId);
            writer.WriteDateTimeOffsetValue("closeDateTime", CloseDateTime);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteObjectValue<EducationAssignmentGradeType>("grading", Grading);
            writer.WriteObjectValue<EducationItemBody>("instructions", Instructions);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("notificationChannelUrl", NotificationChannelUrl);
            writer.WriteCollectionOfObjectValues<EducationAssignmentResource>("resources", Resources);
            writer.WriteStringValue("resourcesFolderUrl", ResourcesFolderUrl);
            writer.WriteObjectValue<EducationRubric>("rubric", Rubric);
            writer.WriteEnumValue<EducationAssignmentStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<EducationSubmission>("submissions", Submissions);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
