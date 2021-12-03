using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TodoTask : Entity, IParsable {
        /// <summary>The task body that typically contains information about the task.</summary>
        public ItemBody Body { get; set; }
        /// <summary>The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.</summary>
        public DateTimeOffset? BodyLastModifiedDateTime { get; set; }
        /// <summary>The date in the specified time zone that the task was finished.</summary>
        public DateTimeTimeZone CompletedDateTime { get; set; }
        /// <summary>The date and time when the task was created. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The date in the specified time zone that the task is to be finished.</summary>
        public DateTimeTimeZone DueDateTime { get; set; }
        /// <summary>The collection of open extensions defined for the task. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>The importance of the task. Possible values are: low, normal, high.</summary>
        public Importance? Importance { get; set; }
        /// <summary>Set to true if an alert is set to remind the user of the task.</summary>
        public bool? IsReminderOn { get; set; }
        /// <summary>The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>A collection of resources linked to the task.</summary>
        public List<LinkedResource> LinkedResources { get; set; }
        /// <summary>The recurrence pattern for the task.</summary>
        public PatternedRecurrence Recurrence { get; set; }
        /// <summary>The date and time for a reminder alert of the task to occur.</summary>
        public DateTimeTimeZone ReminderDateTime { get; set; }
        /// <summary>Indicates the state or progress of the task. Possible values are: notStarted, inProgress, completed, waitingOnOthers, deferred.</summary>
        public TaskStatus? Status { get; set; }
        /// <summary>A brief description of the task.</summary>
        public string Title { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"body", (o,n) => { (o as TodoTask).Body = n.GetObjectValue<ItemBody>(); } },
                {"bodyLastModifiedDateTime", (o,n) => { (o as TodoTask).BodyLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"completedDateTime", (o,n) => { (o as TodoTask).CompletedDateTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"createdDateTime", (o,n) => { (o as TodoTask).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dueDateTime", (o,n) => { (o as TodoTask).DueDateTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"extensions", (o,n) => { (o as TodoTask).Extensions = n.GetCollectionOfObjectValues<Extension>().ToList(); } },
                {"importance", (o,n) => { (o as TodoTask).Importance = n.GetEnumValue<Importance>(); } },
                {"isReminderOn", (o,n) => { (o as TodoTask).IsReminderOn = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as TodoTask).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"linkedResources", (o,n) => { (o as TodoTask).LinkedResources = n.GetCollectionOfObjectValues<LinkedResource>().ToList(); } },
                {"recurrence", (o,n) => { (o as TodoTask).Recurrence = n.GetObjectValue<PatternedRecurrence>(); } },
                {"reminderDateTime", (o,n) => { (o as TodoTask).ReminderDateTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"status", (o,n) => { (o as TodoTask).Status = n.GetEnumValue<TaskStatus>(); } },
                {"title", (o,n) => { (o as TodoTask).Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteDateTimeOffsetValue("bodyLastModifiedDateTime", BodyLastModifiedDateTime);
            writer.WriteObjectValue<DateTimeTimeZone>("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DateTimeTimeZone>("dueDateTime", DueDateTime);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteBoolValue("isReminderOn", IsReminderOn);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LinkedResource>("linkedResources", LinkedResources);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteObjectValue<DateTimeTimeZone>("reminderDateTime", ReminderDateTime);
            writer.WriteEnumValue<TaskStatus>("status", Status);
            writer.WriteStringValue("title", Title);
        }
    }
}
