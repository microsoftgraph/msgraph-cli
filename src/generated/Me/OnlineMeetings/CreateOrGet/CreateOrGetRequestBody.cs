using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.OnlineMeetings.CreateOrGet {
    public class CreateOrGetRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ChatInfo ChatInfo { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public string ExternalId { get; set; }
        public MeetingParticipants Participants { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        public string Subject { get; set; }
        /// <summary>
        /// Instantiates a new createOrGetRequestBody and sets the default values.
        /// </summary>
        public CreateOrGetRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"chatInfo", (o,n) => { (o as CreateOrGetRequestBody).ChatInfo = n.GetObjectValue<ChatInfo>(); } },
                {"endDateTime", (o,n) => { (o as CreateOrGetRequestBody).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", (o,n) => { (o as CreateOrGetRequestBody).ExternalId = n.GetStringValue(); } },
                {"participants", (o,n) => { (o as CreateOrGetRequestBody).Participants = n.GetObjectValue<MeetingParticipants>(); } },
                {"startDateTime", (o,n) => { (o as CreateOrGetRequestBody).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", (o,n) => { (o as CreateOrGetRequestBody).Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ChatInfo>("chatInfo", ChatInfo);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<MeetingParticipants>("participants", Participants);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("subject", Subject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
