using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PatternedRecurrence : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The frequency of an event. Do not specify for a one-time access review.  For access reviews: Do not specify this property for a one-time access review.   Only interval, dayOfMonth, and type (weekly, absoluteMonthly) properties of recurrencePattern are supported.</summary>
        public RecurrencePattern Pattern { get; set; }
        /// <summary>The duration of an event.</summary>
        public RecurrenceRange Range { get; set; }
        /// <summary>
        /// Instantiates a new patternedRecurrence and sets the default values.
        /// </summary>
        public PatternedRecurrence() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PatternedRecurrence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PatternedRecurrence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"pattern", n => { Pattern = n.GetObjectValue<RecurrencePattern>(RecurrencePattern.CreateFromDiscriminatorValue); } },
                {"range", n => { Range = n.GetObjectValue<RecurrenceRange>(RecurrenceRange.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RecurrencePattern>("pattern", Pattern);
            writer.WriteObjectValue<RecurrenceRange>("range", Range);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
