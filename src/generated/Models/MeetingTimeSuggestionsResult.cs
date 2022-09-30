using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MeetingTimeSuggestionsResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A reason for not returning any meeting suggestions. The possible values are: attendeesUnavailable, attendeesUnavailableOrUnknown, locationsUnavailable, organizerUnavailable, or unknown. This property is an empty string if the meetingTimeSuggestions property does include any meeting suggestions.</summary>
        public string EmptySuggestionsReason { get; set; }
        /// <summary>An array of meeting suggestions.</summary>
        public List<MeetingTimeSuggestion> MeetingTimeSuggestions { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new meetingTimeSuggestionsResult and sets the default values.
        /// </summary>
        public MeetingTimeSuggestionsResult() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.meetingTimeSuggestionsResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MeetingTimeSuggestionsResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingTimeSuggestionsResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"emptySuggestionsReason", n => { EmptySuggestionsReason = n.GetStringValue(); } },
                {"meetingTimeSuggestions", n => { MeetingTimeSuggestions = n.GetCollectionOfObjectValues<MeetingTimeSuggestion>(MeetingTimeSuggestion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
