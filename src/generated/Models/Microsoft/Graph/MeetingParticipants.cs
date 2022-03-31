using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MeetingParticipants : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Information of the meeting attendees.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MeetingParticipantInfo> Attendees { get; set; }
        /// <summary>Information of the meeting organizer.</summary>
        public ApiSdk.Models.Microsoft.Graph.MeetingParticipantInfo Organizer { get; set; }
        /// <summary>
        /// Instantiates a new meetingParticipants and sets the default values.
        /// </summary>
        public MeetingParticipants() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.MeetingParticipants CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingParticipants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attendees", (o,n) => { (o as MeetingParticipants).Attendees = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MeetingParticipantInfo>(ApiSdk.Models.Microsoft.Graph.MeetingParticipantInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"organizer", (o,n) => { (o as MeetingParticipants).Organizer = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.MeetingParticipantInfo>(ApiSdk.Models.Microsoft.Graph.MeetingParticipantInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MeetingParticipantInfo>("attendees", Attendees);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.MeetingParticipantInfo>("organizer", Organizer);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
