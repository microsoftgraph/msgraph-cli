using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class OfferShiftRequest : ScheduleChangeRequest, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? RecipientActionDateTime { get; private set; }
        /// <summary>Custom message sent by recipient of the offer shift request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientActionMessage { get; set; }
#nullable restore
#else
        public string RecipientActionMessage { get; set; }
#endif
        /// <summary>User ID of the recipient of the offer shift request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientUserId { get; set; }
#nullable restore
#else
        public string RecipientUserId { get; set; }
#endif
        /// <summary>User ID of the sender of the offer shift request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderShiftId { get; set; }
#nullable restore
#else
        public string SenderShiftId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new OfferShiftRequest and sets the default values.
        /// </summary>
        public OfferShiftRequest() : base() {
            OdataType = "#microsoft.graph.offerShiftRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new OfferShiftRequest CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new OfferShiftRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.swapShiftsChangeRequest" => new SwapShiftsChangeRequest(),
                _ => new OfferShiftRequest(),
            };
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("recipientActionMessage", RecipientActionMessage);
            writer.WriteStringValue("recipientUserId", RecipientUserId);
            writer.WriteStringValue("senderShiftId", SenderShiftId);
        }
    }
}
