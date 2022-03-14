using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class BookingReminder : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The message in the reminder.</summary>
        public string Message { get; set; }
        /// <summary>The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.</summary>
        public TimeSpan? Offset { get; set; }
        /// <summary>The persons who should receive the reminder. Possible values are: allAttendees, staff, customer and unknownFutureValue.</summary>
        public BookingReminderRecipients? Recipients { get; set; }
        /// <summary>
        /// Instantiates a new bookingReminder and sets the default values.
        /// </summary>
        public BookingReminder() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BookingReminder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingReminder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"message", (o,n) => { (o as BookingReminder).Message = n.GetStringValue(); } },
                {"offset", (o,n) => { (o as BookingReminder).Offset = n.GetTimeSpanValue(); } },
                {"recipients", (o,n) => { (o as BookingReminder).Recipients = n.GetEnumValue<BookingReminderRecipients>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("message", Message);
            writer.WriteTimeSpanValue("offset", Offset);
            writer.WriteEnumValue<BookingReminderRecipients>("recipients", Recipients);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
