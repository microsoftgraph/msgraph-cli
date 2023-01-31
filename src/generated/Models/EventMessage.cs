using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class EventMessage : Message, IParsable {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? EndDateTime { get; set; }
#nullable restore
#else
        public DateTimeTimeZone EndDateTime { get; set; }
#endif
        /// <summary>The event associated with the event message. The assumption for attendees or room resources is that the Calendar Attendant is set to automatically update the calendar with an event when meeting request event messages arrive. Navigation property.  Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Event? Event { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Event Event { get; set; }
#endif
        public bool? IsAllDay { get; set; }
        public bool? IsDelegated { get; set; }
        public bool? IsOutOfDate { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Location? Location { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Location Location { get; set; }
#endif
        public ApiSdk.Models.MeetingMessageType? MeetingMessageType { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PatternedRecurrence? Recurrence { get; set; }
#nullable restore
#else
        public PatternedRecurrence Recurrence { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? StartDateTime { get; set; }
#nullable restore
#else
        public DateTimeTimeZone StartDateTime { get; set; }
#endif
        public EventType? Type { get; set; }
        /// <summary>
        /// Instantiates a new EventMessage and sets the default values.
        /// </summary>
        public EventMessage() : base() {
            OdataType = "#microsoft.graph.eventMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new EventMessage CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new EventMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.eventMessageRequest" => new EventMessageRequest(),
                "#microsoft.graph.eventMessageResponse" => new EventMessageResponse(),
                _ => new EventMessage(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"endDateTime", n => { EndDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"event", n => { Event = n.GetObjectValue<ApiSdk.Models.Event>(ApiSdk.Models.Event.CreateFromDiscriminatorValue); } },
                {"isAllDay", n => { IsAllDay = n.GetBoolValue(); } },
                {"isDelegated", n => { IsDelegated = n.GetBoolValue(); } },
                {"isOutOfDate", n => { IsOutOfDate = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetObjectValue<ApiSdk.Models.Location>(ApiSdk.Models.Location.CreateFromDiscriminatorValue); } },
                {"meetingMessageType", n => { MeetingMessageType = n.GetEnumValue<MeetingMessageType>(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<EventType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Event>("event", Event);
            writer.WriteBoolValue("isAllDay", IsAllDay);
            writer.WriteBoolValue("isDelegated", IsDelegated);
            writer.WriteBoolValue("isOutOfDate", IsOutOfDate);
            writer.WriteObjectValue<ApiSdk.Models.Location>("location", Location);
            writer.WriteEnumValue<MeetingMessageType>("meetingMessageType", MeetingMessageType);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<EventType>("type", Type);
        }
    }
}
