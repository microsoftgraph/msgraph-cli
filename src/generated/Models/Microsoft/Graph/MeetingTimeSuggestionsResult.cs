using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MeetingTimeSuggestionsResult : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A reason for not returning any meeting suggestions. Possible values are: attendeesUnavailable, attendeesUnavailableOrUnknown, locationsUnavailable, organizerUnavailable, or unknown. This property is an empty string if the meetingTimeSuggestions property does include any meeting suggestions.</summary>
        public string EmptySuggestionsReason { get; set; }
        /// <summary>An array of meeting suggestions.</summary>
        public List<MeetingTimeSuggestion> MeetingTimeSuggestions { get; set; }
        /// <summary>
        /// Instantiates a new meetingTimeSuggestionsResult and sets the default values.
        /// </summary>
        public MeetingTimeSuggestionsResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"emptySuggestionsReason", (o,n) => { (o as MeetingTimeSuggestionsResult).EmptySuggestionsReason = n.GetStringValue(); } },
                {"meetingTimeSuggestions", (o,n) => { (o as MeetingTimeSuggestionsResult).MeetingTimeSuggestions = n.GetCollectionOfObjectValues<MeetingTimeSuggestion>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("emptySuggestionsReason", EmptySuggestionsReason);
            writer.WriteCollectionOfObjectValues<MeetingTimeSuggestion>("meetingTimeSuggestions", MeetingTimeSuggestions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
