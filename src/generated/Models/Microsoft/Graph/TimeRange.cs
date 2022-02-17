using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TimeRange : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>End time for the time range.</summary>
        public Time? EndTime { get; set; }
        /// <summary>Start time for the time range.</summary>
        public Time? StartTime { get; set; }
        /// <summary>
        /// Instantiates a new timeRange and sets the default values.
        /// </summary>
        public TimeRange() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endTime", (o,n) => { (o as TimeRange).EndTime = n.GetTimeValue(); } },
                {"startTime", (o,n) => { (o as TimeRange).StartTime = n.GetTimeValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeValue("endTime", EndTime);
            writer.WriteTimeValue("startTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
