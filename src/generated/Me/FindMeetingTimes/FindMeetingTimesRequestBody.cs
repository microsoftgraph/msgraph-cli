using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.FindMeetingTimes {
    public class FindMeetingTimesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<AttendeeBase> Attendees { get; set; }
        public bool? IsOrganizerOptional { get; set; }
        public LocationConstraint LocationConstraint { get; set; }
        public int? MaxCandidates { get; set; }
        public string MeetingDuration { get; set; }
        public double? MinimumAttendeePercentage { get; set; }
        public bool? ReturnSuggestionReasons { get; set; }
        public TimeConstraint TimeConstraint { get; set; }
        /// <summary>
        /// Instantiates a new findMeetingTimesRequestBody and sets the default values.
        /// </summary>
        public FindMeetingTimesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attendees", (o,n) => { (o as FindMeetingTimesRequestBody).Attendees = n.GetCollectionOfObjectValues<AttendeeBase>().ToList(); } },
                {"isOrganizerOptional", (o,n) => { (o as FindMeetingTimesRequestBody).IsOrganizerOptional = n.GetBoolValue(); } },
                {"locationConstraint", (o,n) => { (o as FindMeetingTimesRequestBody).LocationConstraint = n.GetObjectValue<LocationConstraint>(); } },
                {"maxCandidates", (o,n) => { (o as FindMeetingTimesRequestBody).MaxCandidates = n.GetIntValue(); } },
                {"meetingDuration", (o,n) => { (o as FindMeetingTimesRequestBody).MeetingDuration = n.GetStringValue(); } },
                {"minimumAttendeePercentage", (o,n) => { (o as FindMeetingTimesRequestBody).MinimumAttendeePercentage = n.GetDoubleValue(); } },
                {"returnSuggestionReasons", (o,n) => { (o as FindMeetingTimesRequestBody).ReturnSuggestionReasons = n.GetBoolValue(); } },
                {"timeConstraint", (o,n) => { (o as FindMeetingTimesRequestBody).TimeConstraint = n.GetObjectValue<TimeConstraint>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AttendeeBase>("attendees", Attendees);
            writer.WriteBoolValue("isOrganizerOptional", IsOrganizerOptional);
            writer.WriteObjectValue<LocationConstraint>("locationConstraint", LocationConstraint);
            writer.WriteIntValue("maxCandidates", MaxCandidates);
            writer.WriteStringValue("meetingDuration", MeetingDuration);
            writer.WriteDoubleValue("minimumAttendeePercentage", MinimumAttendeePercentage);
            writer.WriteBoolValue("returnSuggestionReasons", ReturnSuggestionReasons);
            writer.WriteObjectValue<TimeConstraint>("timeConstraint", TimeConstraint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
