using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MeetingTimeSuggestion : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An array that shows the availability status of each attendee for this meeting suggestion.</summary>
        public List<ApiSdk.Models.AttendeeAvailability> AttendeeAvailability { get; set; }
        /// <summary>A percentage that represents the likelhood of all the attendees attending.</summary>
        public double? Confidence { get; set; }
        /// <summary>An array that specifies the name and geographic location of each meeting location for this meeting suggestion.</summary>
        public List<Location> Locations { get; set; }
        /// <summary>A time period suggested for the meeting.</summary>
        public TimeSlot MeetingTimeSlot { get; set; }
        /// <summary>Order of meeting time suggestions sorted by their computed confidence value from high to low, then by chronology if there are suggestions with the same confidence.</summary>
        public int? Order { get; set; }
        /// <summary>Availability of the meeting organizer for this meeting suggestion. Possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public FreeBusyStatus? OrganizerAvailability { get; set; }
        /// <summary>Reason for suggesting the meeting time.</summary>
        public string SuggestionReason { get; set; }
        /// <summary>
        /// Instantiates a new meetingTimeSuggestion and sets the default values.
        /// </summary>
        public MeetingTimeSuggestion() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MeetingTimeSuggestion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingTimeSuggestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attendeeAvailability", n => { AttendeeAvailability = n.GetCollectionOfObjectValues<ApiSdk.Models.AttendeeAvailability>(ApiSdk.Models.AttendeeAvailability.CreateFromDiscriminatorValue).ToList(); } },
                {"confidence", n => { Confidence = n.GetDoubleValue(); } },
                {"locations", n => { Locations = n.GetCollectionOfObjectValues<Location>(Location.CreateFromDiscriminatorValue).ToList(); } },
                {"meetingTimeSlot", n => { MeetingTimeSlot = n.GetObjectValue<TimeSlot>(TimeSlot.CreateFromDiscriminatorValue); } },
                {"order", n => { Order = n.GetIntValue(); } },
                {"organizerAvailability", n => { OrganizerAvailability = n.GetEnumValue<FreeBusyStatus>(); } },
                {"suggestionReason", n => { SuggestionReason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.AttendeeAvailability>("attendeeAvailability", AttendeeAvailability);
            writer.WriteDoubleValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<Location>("locations", Locations);
            writer.WriteObjectValue<TimeSlot>("meetingTimeSlot", MeetingTimeSlot);
            writer.WriteIntValue("order", Order);
            writer.WriteEnumValue<FreeBusyStatus>("organizerAvailability", OrganizerAvailability);
            writer.WriteStringValue("suggestionReason", SuggestionReason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
