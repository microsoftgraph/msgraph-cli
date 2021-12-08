using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TimeSlot : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DateTimeTimeZone End { get; set; }
        public DateTimeTimeZone Start { get; set; }
        /// <summary>
        /// Instantiates a new timeSlot and sets the default values.
        /// </summary>
        public TimeSlot() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"end", (o,n) => { (o as TimeSlot).End = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"start", (o,n) => { (o as TimeSlot).Start = n.GetObjectValue<DateTimeTimeZone>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DateTimeTimeZone>("end", End);
            writer.WriteObjectValue<DateTimeTimeZone>("start", Start);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
