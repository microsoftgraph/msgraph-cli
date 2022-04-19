using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ShiftAvailability : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the pattern for recurrence</summary>
        public PatternedRecurrence Recurrence { get; set; }
        /// <summary>The time slot(s) preferred by the user.</summary>
        public List<TimeRange> TimeSlots { get; set; }
        /// <summary>Specifies the time zone for the indicated time.</summary>
        public string TimeZone { get; set; }
        /// <summary>
        /// Instantiates a new shiftAvailability and sets the default values.
        /// </summary>
        public ShiftAvailability() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ShiftAvailability CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ShiftAvailability();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"timeSlots", n => { TimeSlots = n.GetCollectionOfObjectValues<TimeRange>(TimeRange.CreateFromDiscriminatorValue).ToList(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteCollectionOfObjectValues<TimeRange>("timeSlots", TimeSlots);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
