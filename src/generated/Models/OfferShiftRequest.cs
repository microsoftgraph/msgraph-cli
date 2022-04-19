using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class OfferShiftRequest : ScheduleChangeRequest, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? RecipientActionDateTime { get; set; }
        /// <summary>Custom message sent by recipient of the offer shift request.</summary>
        public string RecipientActionMessage { get; set; }
        /// <summary>User ID of the recipient of the offer shift request.</summary>
        public string RecipientUserId { get; set; }
        /// <summary>User ID of the sender of the offer shift request.</summary>
        public string SenderShiftId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OfferShiftRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfferShiftRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"recipientActionDateTime", n => { RecipientActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipientActionMessage", n => { RecipientActionMessage = n.GetStringValue(); } },
                {"recipientUserId", n => { RecipientUserId = n.GetStringValue(); } },
                {"senderShiftId", n => { SenderShiftId = n.GetStringValue(); } },
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
