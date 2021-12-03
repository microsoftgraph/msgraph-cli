using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime {
    public class ReminderViewWithStartDateTimeWithEndDateTime : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifies the version of the reminder. Every time the reminder is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object.</summary>
        public string ChangeKey { get; set; }
        /// <summary>The date, time and time zone that the event ends.</summary>
        public DateTimeTimeZone EventEndTime { get; set; }
        /// <summary>The unique ID of the event. Read only.</summary>
        public string EventId { get; set; }
        /// <summary>The location of the event.</summary>
        public Location EventLocation { get; set; }
        /// <summary>The date, time, and time zone that the event starts.</summary>
        public DateTimeTimeZone EventStartTime { get; set; }
        /// <summary>The text of the event's subject line.</summary>
        public string EventSubject { get; set; }
        /// <summary>The URL to open the event in Outlook on the web.The event will open in the browser if you are logged in to your mailbox via Outlook on the web. You will be prompted to login if you are not already logged in with the browser.This URL cannot be accessed from within an iFrame.</summary>
        public string EventWebLink { get; set; }
        /// <summary>The date, time, and time zone that the reminder is set to occur.</summary>
        public DateTimeTimeZone ReminderFireTime { get; set; }
        /// <summary>
        /// Instantiates a new reminderViewWithStartDateTimeWithEndDateTime and sets the default values.
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTime() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"changeKey", (o,n) => { (o as ReminderViewWithStartDateTimeWithEndDateTime).ChangeKey = n.GetStringValue(); } },
                {"eventEndTime", (o,n) => { (o as ReminderViewWithStartDateTimeWithEndDateTime).EventEndTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"eventId", (o,n) => { (o as ReminderViewWithStartDateTimeWithEndDateTime).EventId = n.GetStringValue(); } },
                {"eventLocation", (o,n) => { (o as ReminderViewWithStartDateTimeWithEndDateTime).EventLocation = n.GetObjectValue<Location>(); } },
                {"eventStartTime", (o,n) => { (o as ReminderViewWithStartDateTimeWithEndDateTime).EventStartTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"eventSubject", (o,n) => { (o as ReminderViewWithStartDateTimeWithEndDateTime).EventSubject = n.GetStringValue(); } },
                {"eventWebLink", (o,n) => { (o as ReminderViewWithStartDateTimeWithEndDateTime).EventWebLink = n.GetStringValue(); } },
                {"reminderFireTime", (o,n) => { (o as ReminderViewWithStartDateTimeWithEndDateTime).ReminderFireTime = n.GetObjectValue<DateTimeTimeZone>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteObjectValue<DateTimeTimeZone>("eventEndTime", EventEndTime);
            writer.WriteStringValue("eventId", EventId);
            writer.WriteObjectValue<Location>("eventLocation", EventLocation);
            writer.WriteObjectValue<DateTimeTimeZone>("eventStartTime", EventStartTime);
            writer.WriteStringValue("eventSubject", EventSubject);
            writer.WriteStringValue("eventWebLink", EventWebLink);
            writer.WriteObjectValue<DateTimeTimeZone>("reminderFireTime", ReminderFireTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
