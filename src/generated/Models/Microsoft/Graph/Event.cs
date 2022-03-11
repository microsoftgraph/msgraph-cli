using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Event : OutlookItem, IParsable {
        /// <summary>true if the meeting organizer allows invitees to propose a new time when responding; otherwise false. Optional. Default is true.</summary>
        public bool? AllowNewTimeProposals { get; set; }
        /// <summary>The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.</summary>
        public List<Attachment> Attachments { get; set; }
        /// <summary>The collection of attendees for the event.</summary>
        public List<Attendee> Attendees { get; set; }
        /// <summary>The body of the message associated with the event. It can be in HTML or text format.</summary>
        public ItemBody Body { get; set; }
        /// <summary>The preview of the message associated with the event. It is in text format.</summary>
        public string BodyPreview { get; set; }
        /// <summary>The calendar that contains the event. Navigation property. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Calendar Calendar { get; set; }
        /// <summary>The date, time, and time zone that the event ends. By default, the end time is in UTC.</summary>
        public DateTimeTimeZone End { get; set; }
        /// <summary>The collection of open extensions defined for the event. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>Set to true if the event has attachments.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.</summary>
        public bool? HideAttendees { get; set; }
        /// <summary>A unique identifier for an event across calendars. This ID is different for each occurrence in a recurring series. Read-only.</summary>
        public string ICalUId { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Importance? Importance { get; set; }
        /// <summary>The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.</summary>
        public List<Event> Instances { get; set; }
        public bool? IsAllDay { get; set; }
        public bool? IsCancelled { get; set; }
        public bool? IsDraft { get; set; }
        public bool? IsOnlineMeeting { get; set; }
        public bool? IsOrganizer { get; set; }
        public bool? IsReminderOn { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Location Location { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.Location> Locations { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        public OnlineMeetingInfo OnlineMeeting { get; set; }
        public OnlineMeetingProviderType? OnlineMeetingProvider { get; set; }
        public string OnlineMeetingUrl { get; set; }
        public Recipient Organizer { get; set; }
        public string OriginalEndTimeZone { get; set; }
        public DateTimeOffset? OriginalStart { get; set; }
        public string OriginalStartTimeZone { get; set; }
        public PatternedRecurrence Recurrence { get; set; }
        public int? ReminderMinutesBeforeStart { get; set; }
        public bool? ResponseRequested { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ResponseStatus ResponseStatus { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Sensitivity? Sensitivity { get; set; }
        public string SeriesMasterId { get; set; }
        public FreeBusyStatus? ShowAs { get; set; }
        /// <summary>The collection of single-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        public DateTimeTimeZone Start { get; set; }
        public string Subject { get; set; }
        public string TransactionId { get; set; }
        public EventType? Type { get; set; }
        public string WebLink { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Event CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Event();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowNewTimeProposals", (o,n) => { (o as Event).AllowNewTimeProposals = n.GetBoolValue(); } },
                {"attachments", (o,n) => { (o as Event).Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue).ToList(); } },
                {"attendees", (o,n) => { (o as Event).Attendees = n.GetCollectionOfObjectValues<Attendee>(Attendee.CreateFromDiscriminatorValue).ToList(); } },
                {"body", (o,n) => { (o as Event).Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyPreview", (o,n) => { (o as Event).BodyPreview = n.GetStringValue(); } },
                {"calendar", (o,n) => { (o as Event).Calendar = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Calendar>(ApiSdk.Models.Microsoft.Graph.Calendar.CreateFromDiscriminatorValue); } },
                {"end", (o,n) => { (o as Event).End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"extensions", (o,n) => { (o as Event).Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"hasAttachments", (o,n) => { (o as Event).HasAttachments = n.GetBoolValue(); } },
                {"hideAttendees", (o,n) => { (o as Event).HideAttendees = n.GetBoolValue(); } },
                {"iCalUId", (o,n) => { (o as Event).ICalUId = n.GetStringValue(); } },
                {"importance", (o,n) => { (o as Event).Importance = n.GetEnumValue<Importance>(); } },
                {"instances", (o,n) => { (o as Event).Instances = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue).ToList(); } },
                {"isAllDay", (o,n) => { (o as Event).IsAllDay = n.GetBoolValue(); } },
                {"isCancelled", (o,n) => { (o as Event).IsCancelled = n.GetBoolValue(); } },
                {"isDraft", (o,n) => { (o as Event).IsDraft = n.GetBoolValue(); } },
                {"isOnlineMeeting", (o,n) => { (o as Event).IsOnlineMeeting = n.GetBoolValue(); } },
                {"isOrganizer", (o,n) => { (o as Event).IsOrganizer = n.GetBoolValue(); } },
                {"isReminderOn", (o,n) => { (o as Event).IsReminderOn = n.GetBoolValue(); } },
                {"location", (o,n) => { (o as Event).Location = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Location>(ApiSdk.Models.Microsoft.Graph.Location.CreateFromDiscriminatorValue); } },
                {"locations", (o,n) => { (o as Event).Locations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Location>(ApiSdk.Models.Microsoft.Graph.Location.CreateFromDiscriminatorValue).ToList(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Event).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"onlineMeeting", (o,n) => { (o as Event).OnlineMeeting = n.GetObjectValue<OnlineMeetingInfo>(OnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                {"onlineMeetingProvider", (o,n) => { (o as Event).OnlineMeetingProvider = n.GetEnumValue<OnlineMeetingProviderType>(); } },
                {"onlineMeetingUrl", (o,n) => { (o as Event).OnlineMeetingUrl = n.GetStringValue(); } },
                {"organizer", (o,n) => { (o as Event).Organizer = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"originalEndTimeZone", (o,n) => { (o as Event).OriginalEndTimeZone = n.GetStringValue(); } },
                {"originalStart", (o,n) => { (o as Event).OriginalStart = n.GetDateTimeOffsetValue(); } },
                {"originalStartTimeZone", (o,n) => { (o as Event).OriginalStartTimeZone = n.GetStringValue(); } },
                {"recurrence", (o,n) => { (o as Event).Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderMinutesBeforeStart", (o,n) => { (o as Event).ReminderMinutesBeforeStart = n.GetIntValue(); } },
                {"responseRequested", (o,n) => { (o as Event).ResponseRequested = n.GetBoolValue(); } },
                {"responseStatus", (o,n) => { (o as Event).ResponseStatus = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ResponseStatus>(ApiSdk.Models.Microsoft.Graph.ResponseStatus.CreateFromDiscriminatorValue); } },
                {"sensitivity", (o,n) => { (o as Event).Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"seriesMasterId", (o,n) => { (o as Event).SeriesMasterId = n.GetStringValue(); } },
                {"showAs", (o,n) => { (o as Event).ShowAs = n.GetEnumValue<FreeBusyStatus>(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Event).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"start", (o,n) => { (o as Event).Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"subject", (o,n) => { (o as Event).Subject = n.GetStringValue(); } },
                {"transactionId", (o,n) => { (o as Event).TransactionId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Event).Type = n.GetEnumValue<EventType>(); } },
                {"webLink", (o,n) => { (o as Event).WebLink = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowNewTimeProposals", AllowNewTimeProposals);
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<Attendee>("attendees", Attendees);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("bodyPreview", BodyPreview);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Calendar>("calendar", Calendar);
            writer.WriteObjectValue<DateTimeTimeZone>("end", End);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("hideAttendees", HideAttendees);
            writer.WriteStringValue("iCalUId", ICalUId);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteCollectionOfObjectValues<Event>("instances", Instances);
            writer.WriteBoolValue("isAllDay", IsAllDay);
            writer.WriteBoolValue("isCancelled", IsCancelled);
            writer.WriteBoolValue("isDraft", IsDraft);
            writer.WriteBoolValue("isOnlineMeeting", IsOnlineMeeting);
            writer.WriteBoolValue("isOrganizer", IsOrganizer);
            writer.WriteBoolValue("isReminderOn", IsReminderOn);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Location>("location", Location);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Location>("locations", Locations);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteObjectValue<OnlineMeetingInfo>("onlineMeeting", OnlineMeeting);
            writer.WriteEnumValue<OnlineMeetingProviderType>("onlineMeetingProvider", OnlineMeetingProvider);
            writer.WriteStringValue("onlineMeetingUrl", OnlineMeetingUrl);
            writer.WriteObjectValue<Recipient>("organizer", Organizer);
            writer.WriteStringValue("originalEndTimeZone", OriginalEndTimeZone);
            writer.WriteDateTimeOffsetValue("originalStart", OriginalStart);
            writer.WriteStringValue("originalStartTimeZone", OriginalStartTimeZone);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteIntValue("reminderMinutesBeforeStart", ReminderMinutesBeforeStart);
            writer.WriteBoolValue("responseRequested", ResponseRequested);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ResponseStatus>("responseStatus", ResponseStatus);
            writer.WriteEnumValue<Sensitivity>("sensitivity", Sensitivity);
            writer.WriteStringValue("seriesMasterId", SeriesMasterId);
            writer.WriteEnumValue<FreeBusyStatus>("showAs", ShowAs);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteObjectValue<DateTimeTimeZone>("start", Start);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("transactionId", TransactionId);
            writer.WriteEnumValue<EventType>("type", Type);
            writer.WriteStringValue("webLink", WebLink);
        }
    }
}
