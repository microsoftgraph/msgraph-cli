using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RecurrencePattern : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.</summary>
        public int? DayOfMonth { get; set; }
        /// <summary>A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.</summary>
        public List<DayOfWeek?> DaysOfWeek { get; set; }
        /// <summary>The first day of the week. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. Default is sunday. Required if type is weekly.</summary>
        public DayOfWeek? FirstDayOfWeek { get; set; }
        /// <summary>Specifies on which instance of the allowed days specified in daysOfWeek the event occurs, counted from the first instance in the month. The possible values are: first, second, third, fourth, last. Default is first. Optional and used if type is relativeMonthly or relativeYearly.</summary>
        public WeekIndex? Index { get; set; }
        /// <summary>The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.</summary>
        public int? Interval { get; set; }
        /// <summary>The month in which the event occurs.  This is a number from 1 to 12.</summary>
        public int? Month { get; set; }
        /// <summary>The recurrence pattern type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly. Required.</summary>
        public RecurrencePatternType? Type { get; set; }
        /// <summary>
        /// Instantiates a new recurrencePattern and sets the default values.
        /// </summary>
        public RecurrencePattern() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dayOfMonth", (o,n) => { (o as RecurrencePattern).DayOfMonth = n.GetIntValue(); } },
                {"daysOfWeek", (o,n) => { (o as RecurrencePattern).DaysOfWeek = n.GetCollectionOfEnumValues<DayOfWeek>().ToList(); } },
                {"firstDayOfWeek", (o,n) => { (o as RecurrencePattern).FirstDayOfWeek = n.GetEnumValue<DayOfWeek>(); } },
                {"index", (o,n) => { (o as RecurrencePattern).Index = n.GetEnumValue<WeekIndex>(); } },
                {"interval", (o,n) => { (o as RecurrencePattern).Interval = n.GetIntValue(); } },
                {"month", (o,n) => { (o as RecurrencePattern).Month = n.GetIntValue(); } },
                {"type", (o,n) => { (o as RecurrencePattern).Type = n.GetEnumValue<RecurrencePatternType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("dayOfMonth", DayOfMonth);
            writer.WriteCollectionOfEnumValues<DayOfWeek>("daysOfWeek", DaysOfWeek);
            writer.WriteEnumValue<DayOfWeek>("firstDayOfWeek", FirstDayOfWeek);
            writer.WriteEnumValue<WeekIndex>("index", Index);
            writer.WriteIntValue("interval", Interval);
            writer.WriteIntValue("month", Month);
            writer.WriteEnumValue<RecurrencePatternType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
