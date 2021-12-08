using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationAssignmentDefaults : Entity, IParsable {
        /// <summary>Class-level default behavior for handling students who are added after the assignment is published. Possible values are: none, assignIfOpen.</summary>
        public EducationAddedStudentAction? AddedStudentAction { get; set; }
        /// <summary>Class-level default value for due time field. Default value is 23:59:00.</summary>
        public string DueTime { get; set; }
        /// <summary>Default Teams channel to which notifications will be sent. Default value is null.</summary>
        public string NotificationChannelUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addedStudentAction", (o,n) => { (o as EducationAssignmentDefaults).AddedStudentAction = n.GetEnumValue<EducationAddedStudentAction>(); } },
                {"dueTime", (o,n) => { (o as EducationAssignmentDefaults).DueTime = n.GetStringValue(); } },
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
            writer.WriteStringValue("dueTime", DueTime);
            writer.WriteStringValue("notificationChannelUrl", NotificationChannelUrl);
        }
    }
}
