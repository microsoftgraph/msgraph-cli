using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationAssignmentDefaults : Entity, IParsable {
        /// <summary>Class-level default behavior for handling students who are added after the assignment is published. Possible values are: none, assignIfOpen.</summary>
        public EducationAddedStudentAction? AddedStudentAction { get; set; }
        /// <summary>Optional field to control adding assignments to students' and teachers' calendars when the assignment is published. The possible values are: none, studentsAndPublisher, studentsAndTeamOwners, unknownFutureValue, and studentsOnly. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: studentsOnly. The default value is none.</summary>
        public EducationAddToCalendarOptions? AddToCalendarAction { get; set; }
        /// <summary>Class-level default value for due time field. Default value is 23:59:00.</summary>
        public Time? DueTime { get; set; }
        /// <summary>Default Teams channel to which notifications will be sent. Default value is null.</summary>
        public string NotificationChannelUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationAssignmentDefaults CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationAssignmentDefaults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addedStudentAction", (o,n) => { (o as EducationAssignmentDefaults).AddedStudentAction = n.GetEnumValue<EducationAddedStudentAction>(); } },
                {"addToCalendarAction", (o,n) => { (o as EducationAssignmentDefaults).AddToCalendarAction = n.GetEnumValue<EducationAddToCalendarOptions>(); } },
                {"dueTime", (o,n) => { (o as EducationAssignmentDefaults).DueTime = n.GetTimeValue(); } },
                {"notificationChannelUrl", (o,n) => { (o as EducationAssignmentDefaults).NotificationChannelUrl = n.GetStringValue(); } },
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
            writer.WriteTimeValue("dueTime", DueTime);
            writer.WriteStringValue("notificationChannelUrl", NotificationChannelUrl);
        }
    }
}
