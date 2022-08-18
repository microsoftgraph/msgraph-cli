using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CallTranscriptEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Unique identifier of the call.</summary>
        public string CallId { get; set; }
        /// <summary>Unique identifier for a call transcript.</summary>
        public string CallTranscriptICalUid { get; set; }
        /// <summary>The organizer of the meeting.</summary>
        public IdentitySet MeetingOrganizer { get; set; }
        /// <summary>
        /// Instantiates a new CallTranscriptEventMessageDetail and sets the default values.
        /// </summary>
        public CallTranscriptEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.callTranscriptEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CallTranscriptEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallTranscriptEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callId", n => { CallId = n.GetStringValue(); } },
                {"callTranscriptICalUid", n => { CallTranscriptICalUid = n.GetStringValue(); } },
                {"meetingOrganizer", n => { MeetingOrganizer = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("callId", CallId);
            writer.WriteStringValue("callTranscriptICalUid", CallTranscriptICalUid);
            writer.WriteObjectValue<IdentitySet>("meetingOrganizer", MeetingOrganizer);
        }
    }
}
