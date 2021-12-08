using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MeetingParticipantInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identity information of the participant.</summary>
        public IdentitySet Identity { get; set; }
        /// <summary>Specifies the participant's role in the meeting.  Possible values are attendee, presenter, producer, and unknownFutureValue.</summary>
        public OnlineMeetingRole? Role { get; set; }
        /// <summary>User principal name of the participant.</summary>
        public string Upn { get; set; }
        /// <summary>
        /// Instantiates a new meetingParticipantInfo and sets the default values.
        /// </summary>
        public MeetingParticipantInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"identity", (o,n) => { (o as MeetingParticipantInfo).Identity = n.GetObjectValue<IdentitySet>(); } },
                {"role", (o,n) => { (o as MeetingParticipantInfo).Role = n.GetEnumValue<OnlineMeetingRole>(); } },
                {"upn", (o,n) => { (o as MeetingParticipantInfo).Upn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteEnumValue<OnlineMeetingRole>("role", Role);
            writer.WriteStringValue("upn", Upn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
