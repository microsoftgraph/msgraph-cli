using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OfferShiftRequest : ScheduleChangeRequest, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? RecipientActionDateTime { get; set; }
        /// <summary>Custom message sent by recipient of the offer shift request.</summary>
        public string RecipientActionMessage { get; set; }
        /// <summary>User id of the recipient of the offer shift request.</summary>
        public string RecipientUserId { get; set; }
        /// <summary>User id of the sender of the offer shift request.</summary>
        public string SenderShiftId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"recipientActionDateTime", (o,n) => { (o as OfferShiftRequest).RecipientActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipientActionMessage", (o,n) => { (o as OfferShiftRequest).RecipientActionMessage = n.GetStringValue(); } },
                {"recipientUserId", (o,n) => { (o as OfferShiftRequest).RecipientUserId = n.GetStringValue(); } },
                {"senderShiftId", (o,n) => { (o as OfferShiftRequest).SenderShiftId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("recipientActionDateTime", RecipientActionDateTime);
            writer.WriteStringValue("recipientActionMessage", RecipientActionMessage);
            writer.WriteStringValue("recipientUserId", RecipientUserId);
            writer.WriteStringValue("senderShiftId", SenderShiftId);
        }
    }
}
