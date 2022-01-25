using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RecurrenceRange : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.</summary>
        public string EndDate { get; set; }
        /// <summary>The number of times to repeat the event. Required and must be positive if type is numbered.</summary>
        public int? NumberOfOccurrences { get; set; }
        /// <summary>Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.</summary>
        public string RecurrenceTimeZone { get; set; }
        /// <summary>The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.</summary>
        public string StartDate { get; set; }
        /// <summary>The recurrence range. Possible values are: endDate, noEnd, numbered. Required.</summary>
        public RecurrenceRangeType? Type { get; set; }
        /// <summary>
        /// Instantiates a new recurrenceRange and sets the default values.
        /// </summary>
        public RecurrenceRange() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDate", (o,n) => { (o as RecurrenceRange).EndDate = n.GetStringValue(); } },
                {"numberOfOccurrences", (o,n) => { (o as RecurrenceRange).NumberOfOccurrences = n.GetIntValue(); } },
                {"recurrenceTimeZone", (o,n) => { (o as RecurrenceRange).RecurrenceTimeZone = n.GetStringValue(); } },
                {"startDate", (o,n) => { (o as RecurrenceRange).StartDate = n.GetStringValue(); } },
                {"type", (o,n) => { (o as RecurrenceRange).Type = n.GetEnumValue<RecurrenceRangeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("endDate", EndDate);
            writer.WriteIntValue("numberOfOccurrences", NumberOfOccurrences);
            writer.WriteStringValue("recurrenceTimeZone", RecurrenceTimeZone);
            writer.WriteStringValue("startDate", StartDate);
            writer.WriteEnumValue<RecurrenceRangeType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
