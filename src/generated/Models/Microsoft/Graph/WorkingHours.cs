using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkingHours : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The days of the week on which the user works.</summary>
        public List<DayOfWeek?> DaysOfWeek { get; set; }
        /// <summary>The time of the day that the user stops working.</summary>
        public string EndTime { get; set; }
        /// <summary>The time of the day that the user starts working.</summary>
        public string StartTime { get; set; }
        /// <summary>The time zone to which the working hours apply.</summary>
        public TimeZoneBase TimeZone { get; set; }
        /// <summary>
        /// Instantiates a new workingHours and sets the default values.
        /// </summary>
        public WorkingHours() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"daysOfWeek", (o,n) => { (o as WorkingHours).DaysOfWeek = n.GetCollectionOfEnumValues<DayOfWeek>().ToList(); } },
                {"endTime", (o,n) => { (o as WorkingHours).EndTime = n.GetStringValue(); } },
                {"startTime", (o,n) => { (o as WorkingHours).StartTime = n.GetStringValue(); } },
                {"timeZone", (o,n) => { (o as WorkingHours).TimeZone = n.GetObjectValue<TimeZoneBase>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<DayOfWeek>("daysOfWeek", DaysOfWeek);
            writer.WriteStringValue("endTime", EndTime);
            writer.WriteStringValue("startTime", StartTime);
            writer.WriteObjectValue<TimeZoneBase>("timeZone", TimeZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
