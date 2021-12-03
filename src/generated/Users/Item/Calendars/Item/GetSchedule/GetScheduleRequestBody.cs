using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.Calendars.Item.GetSchedule {
    public class GetScheduleRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public int? AvailabilityViewInterval { get; set; }
        public DateTimeTimeZone EndTime { get; set; }
        public List<string> Schedules { get; set; }
        public DateTimeTimeZone StartTime { get; set; }
        /// <summary>
        /// Instantiates a new getScheduleRequestBody and sets the default values.
        /// </summary>
        public GetScheduleRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"availabilityViewInterval", (o,n) => { (o as GetScheduleRequestBody).AvailabilityViewInterval = n.GetIntValue(); } },
                {"endTime", (o,n) => { (o as GetScheduleRequestBody).EndTime = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"schedules", (o,n) => { (o as GetScheduleRequestBody).Schedules = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"startTime", (o,n) => { (o as GetScheduleRequestBody).StartTime = n.GetObjectValue<DateTimeTimeZone>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("availabilityViewInterval", AvailabilityViewInterval);
            writer.WriteObjectValue<DateTimeTimeZone>("endTime", EndTime);
            writer.WriteCollectionOfPrimitiveValues<string>("schedules", Schedules);
            writer.WriteObjectValue<DateTimeTimeZone>("startTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
