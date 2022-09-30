using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Event : OutlookItem, IParsable {
        /// <summary>true if the meeting organizer allows invitees to propose a new time when responding; otherwise, false. Optional. Default is true.</summary>
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
        public ApiSdk.Models.Calendar Calendar { get; set; }
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
        /// <summary>The importance property</summary>
        public ApiSdk.Models.Importance? Importance { get; set; }
        /// <summary>The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.</summary>
        public List<Event> Instances { get; set; }
        /// <summary>The isAllDay property</summary>
        public bool? IsAllDay { get; set; }
        /// <summary>The isCancelled property</summary>
        public bool? IsCancelled { get; set; }
        /// <summary>The isDraft property</summary>
        public bool? IsDraft { get; set; }
        /// <summary>The isOnlineMeeting property</summary>
        public bool? IsOnlineMeeting { get; set; }
        /// <summary>The isOrganizer property</summary>
        public bool? IsOrganizer { get; set; }
        /// <summary>The isReminderOn property</summary>
        public bool? IsReminderOn { get; set; }
        /// <summary>The location property</summary>
        public ApiSdk.Models.Location Location { get; set; }
        /// <summary>The locations property</summary>
        public List<ApiSdk.Models.Location> Locations { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>The onlineMeeting property</summary>
        public OnlineMeetingInfo OnlineMeeting { get; set; }
        /// <summary>The onlineMeetingProvider property</summary>
        public OnlineMeetingProviderType? OnlineMeetingProvider { get; set; }
        /// <summary>The onlineMeetingUrl property</summary>
        public string OnlineMeetingUrl { get; set; }
        /// <summary>The organizer property</summary>
        public Recipient Organizer { get; set; }
        /// <summary>The originalEndTimeZone property</summary>
        public string OriginalEndTimeZone { get; set; }
        /// <summary>The originalStart property</summary>
        public DateTimeOffset? OriginalStart { get; set; }
        /// <summary>The originalStartTimeZone property</summary>
        public string OriginalStartTimeZone { get; set; }
        /// <summary>The recurrence property</summary>
        public PatternedRecurrence Recurrence { get; set; }
        /// <summary>The reminderMinutesBeforeStart property</summary>
        public int? ReminderMinutesBeforeStart { get; set; }
        /// <summary>The responseRequested property</summary>
        public bool? ResponseRequested { get; set; }
        /// <summary>The responseStatus property</summary>
        public ApiSdk.Models.ResponseStatus ResponseStatus { get; set; }
        /// <summary>The sensitivity property</summary>
        public ApiSdk.Models.Sensitivity? Sensitivity { get; set; }
        /// <summary>The seriesMasterId property</summary>
        public string SeriesMasterId { get; set; }
        /// <summary>The showAs property</summary>
        public FreeBusyStatus? ShowAs { get; set; }
        /// <summary>The collection of single-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>The start property</summary>
        public DateTimeTimeZone Start { get; set; }
        /// <summary>The subject property</summary>
        public string Subject { get; set; }
        /// <summary>The transactionId property</summary>
        public string TransactionId { get; set; }
        /// <summary>The type property</summary>
        public EventType? Type { get; set; }
        /// <summary>The webLink property</summary>
        public string WebLink { get; set; }
        /// <summary>
        /// Instantiates a new Event and sets the default values.
        /// </summary>
        public Event() : base() {
            OdataType = "#microsoft.graph.event";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowNewTimeProposals", n => { AllowNewTimeProposals = n.GetBoolValue(); } },
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attendees", n => { Attendees = n.GetCollectionOfObjectValues<Attendee>(Attendee.CreateFromDiscriminatorValue)?.ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyPreview", n => { BodyPreview = n.GetStringValue(); } },
                {"calendar", n => { Calendar = n.GetObjectValue<ApiSdk.Models.Calendar>(ApiSdk.Models.Calendar.CreateFromDiscriminatorValue); } },
                {"end", n => { End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"hideAttendees", n => { HideAttendees = n.GetBoolValue(); } },
                {"iCalUId", n => { ICalUId = n.GetStringValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"instances", n => { Instances = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isAllDay", n => { IsAllDay = n.GetBoolValue(); } },
                {"isCancelled", n => { IsCancelled = n.GetBoolValue(); } },
                {"isDraft", n => { IsDraft = n.GetBoolValue(); } },
                {"isOnlineMeeting", n => { IsOnlineMeeting = n.GetBoolValue(); } },
                {"isOrganizer", n => { IsOrganizer = n.GetBoolValue(); } },
                {"isReminderOn", n => { IsReminderOn = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetObjectValue<ApiSdk.Models.Location>(ApiSdk.Models.Location.CreateFromDiscriminatorValue); } },
                {"locations", n => { Locations = n.GetCollectionOfObjectValues<ApiSdk.Models.Location>(ApiSdk.Models.Location.CreateFromDiscriminatorValue)?.ToList(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onlineMeeting", n => { OnlineMeeting = n.GetObjectValue<OnlineMeetingInfo>(OnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                {"onlineMeetingProvider", n => { OnlineMeetingProvider = n.GetEnumValue<OnlineMeetingProviderType>(); } },
                {"onlineMeetingUrl", n => { OnlineMeetingUrl = n.GetStringValue(); } },
                {"organizer", n => { Organizer = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"originalEndTimeZone", n => { OriginalEndTimeZone = n.GetStringValue(); } },
                {"originalStart", n => { OriginalStart = n.GetDateTimeOffsetValue(); } },
                {"originalStartTimeZone", n => { OriginalStartTimeZone = n.GetStringValue(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderMinutesBeforeStart", n => { ReminderMinutesBeforeStart = n.GetIntValue(); } },
                {"responseRequested", n => { ResponseRequested = n.GetBoolValue(); } },
                {"responseStatus", n => { ResponseStatus = n.GetObjectValue<ApiSdk.Models.ResponseStatus>(ApiSdk.Models.ResponseStatus.CreateFromDiscriminatorValue); } },
                {"sensitivity", n => { Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"seriesMasterId", n => { SeriesMasterId = n.GetStringValue(); } },
                {"showAs", n => { ShowAs = n.GetEnumValue<FreeBusyStatus>(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"start", n => { Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"transactionId", n => { TransactionId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<EventType>(); } },
                {"webLink", n => { WebLink = n.GetStringValue(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.Calendar>("calendar", Calendar);
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
            writer.WriteObjectValue<ApiSdk.Models.Location>("location", Location);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Location>("locations", Locations);
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
            writer.WriteObjectValue<ApiSdk.Models.ResponseStatus>("responseStatus", ResponseStatus);
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
