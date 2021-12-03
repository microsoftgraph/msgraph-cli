using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ShiftActivity : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Customer defined code for the shiftActivity. Required.</summary>
        public string Code { get; set; }
        /// <summary>The name of the shiftActivity. Required.</summary>
        public string DisplayName { get; set; }
        /// <summary>The end date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Indicates whether the microsoft.graph.user should be paid for the activity during their shift. Required.</summary>
        public bool? IsPaid { get; set; }
        /// <summary>The start date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        public ScheduleEntityTheme? Theme { get; set; }
        /// <summary>
        /// Instantiates a new shiftActivity and sets the default values.
        /// </summary>
        public ShiftActivity() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as ShiftActivity).Code = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ShiftActivity).DisplayName = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as ShiftActivity).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"isPaid", (o,n) => { (o as ShiftActivity).IsPaid = n.GetBoolValue(); } },
                {"startDateTime", (o,n) => { (o as ShiftActivity).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"theme", (o,n) => { (o as ShiftActivity).Theme = n.GetEnumValue<ScheduleEntityTheme>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteBoolValue("isPaid", IsPaid);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<ScheduleEntityTheme>("theme", Theme);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
