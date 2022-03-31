using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MeetingTimeSuggestionsResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A reason for not returning any meeting suggestions. The possible values are: attendeesUnavailable, attendeesUnavailableOrUnknown, locationsUnavailable, organizerUnavailable, or unknown. This property is an empty string if the meetingTimeSuggestions property does include any meeting suggestions.</summary>
        public string EmptySuggestionsReason { get; set; }
        /// <summary>An array of meeting suggestions.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MeetingTimeSuggestion> MeetingTimeSuggestions { get; set; }
        /// <summary>
        /// Instantiates a new meetingTimeSuggestionsResult and sets the default values.
        /// </summary>
        public MeetingTimeSuggestionsResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.MeetingTimeSuggestionsResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingTimeSuggestionsResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"emptySuggestionsReason", (o,n) => { (o as MeetingTimeSuggestionsResult).EmptySuggestionsReason = n.GetStringValue(); } },
                {"meetingTimeSuggestions", (o,n) => { (o as MeetingTimeSuggestionsResult).MeetingTimeSuggestions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MeetingTimeSuggestion>(ApiSdk.Models.Microsoft.Graph.MeetingTimeSuggestion.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("emptySuggestionsReason", EmptySuggestionsReason);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MeetingTimeSuggestion>("meetingTimeSuggestions", MeetingTimeSuggestions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
