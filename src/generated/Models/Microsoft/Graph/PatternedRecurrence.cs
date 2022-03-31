using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PatternedRecurrence : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The frequency of an event.  For access reviews: Do not specify this property for a one-time access review.  Only interval, dayOfMonth, and type (weekly, absoluteMonthly) properties of recurrencePattern are supported.</summary>
        public ApiSdk.Models.Microsoft.Graph.RecurrencePattern Pattern { get; set; }
        /// <summary>The duration of an event.</summary>
        public ApiSdk.Models.Microsoft.Graph.RecurrenceRange Range { get; set; }
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
        public static ApiSdk.Models.Microsoft.Graph.PatternedRecurrence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PatternedRecurrence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"pattern", (o,n) => { (o as PatternedRecurrence).Pattern = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.RecurrencePattern>(ApiSdk.Models.Microsoft.Graph.RecurrencePattern.CreateFromDiscriminatorValue); } },
                {"range", (o,n) => { (o as PatternedRecurrence).Range = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.RecurrenceRange>(ApiSdk.Models.Microsoft.Graph.RecurrenceRange.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.RecurrencePattern>("pattern", Pattern);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.RecurrenceRange>("range", Range);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
