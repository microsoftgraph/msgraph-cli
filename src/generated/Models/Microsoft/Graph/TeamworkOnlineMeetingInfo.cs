using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamworkOnlineMeetingInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier of the calendar event associated with the meeting.</summary>
        public string CalendarEventId { get; set; }
        /// <summary>The URL that users click to join or uniquely identify the meeting.</summary>
        public string JoinWebUrl { get; set; }
        /// <summary>The organizer of the meeting.</summary>
        public ApiSdk.Models.Microsoft.Graph.TeamworkUserIdentity Organizer { get; set; }
        /// <summary>
        /// Instantiates a new teamworkOnlineMeetingInfo and sets the default values.
        /// </summary>
        public TeamworkOnlineMeetingInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.TeamworkOnlineMeetingInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkOnlineMeetingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"calendarEventId", (o,n) => { (o as TeamworkOnlineMeetingInfo).CalendarEventId = n.GetStringValue(); } },
                {"joinWebUrl", (o,n) => { (o as TeamworkOnlineMeetingInfo).JoinWebUrl = n.GetStringValue(); } },
                {"organizer", (o,n) => { (o as TeamworkOnlineMeetingInfo).Organizer = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TeamworkUserIdentity>(ApiSdk.Models.Microsoft.Graph.TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("calendarEventId", CalendarEventId);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TeamworkUserIdentity>("organizer", Organizer);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
