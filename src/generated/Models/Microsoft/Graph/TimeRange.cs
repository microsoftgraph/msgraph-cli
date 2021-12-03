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
        public string EndTime { get; set; }
        /// <summary>Start time for the time range.</summary>
        public string StartTime { get; set; }
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
                {"endTime", (o,n) => { (o as TimeRange).EndTime = n.GetStringValue(); } },
                {"startTime", (o,n) => { (o as TimeRange).StartTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("endTime", EndTime);
            writer.WriteStringValue("startTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
