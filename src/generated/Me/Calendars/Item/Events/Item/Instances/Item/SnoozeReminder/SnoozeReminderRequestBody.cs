using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.Calendars.Item.Events.Item.Instances.Item.SnoozeReminder {
    /// <summary>Provides operations to call the snoozeReminder method.</summary>
    public class SnoozeReminderRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DateTimeTimeZone NewReminderTime { get; set; }
        /// <summary>
        /// Instantiates a new snoozeReminderRequestBody and sets the default values.
        /// </summary>
        public SnoozeReminderRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Me.Calendars.Item.Events.Item.Instances.Item.SnoozeReminder.SnoozeReminderRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SnoozeReminderRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"newReminderTime", (o,n) => { (o as SnoozeReminderRequestBody).NewReminderTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DateTimeTimeZone>("newReminderTime", NewReminderTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
