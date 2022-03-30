using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.ReminderViewWithStartDateTimeWithEndDateTime {
    /// <summary>Provides operations to call the reminderView method.</summary>
    public class ReminderViewWithStartDateTimeWithEndDateTimeResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<Reminder> Value { get; set; }
        /// <summary>
        /// Instantiates a new reminderViewWithStartDateTimeWithEndDateTimeResponse and sets the default values.
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTimeResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReminderViewWithStartDateTimeWithEndDateTimeResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as ReminderViewWithStartDateTimeWithEndDateTimeResponse).Value = n.GetCollectionOfObjectValues<Reminder>(Reminder.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Reminder>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
