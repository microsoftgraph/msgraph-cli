using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.CalendarGroups.Item.Calendars.Item.MicrosoftGraphGetSchedule {
    public class GetSchedulePostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AvailabilityViewInterval property</summary>
        public int? AvailabilityViewInterval { get; set; }
        /// <summary>The EndTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? EndTime { get; set; }
#nullable restore
#else
        public DateTimeTimeZone EndTime { get; set; }
#endif
        /// <summary>The Schedules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Schedules { get; set; }
#nullable restore
#else
        public List<string> Schedules { get; set; }
#endif
        /// <summary>The StartTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? StartTime { get; set; }
#nullable restore
#else
        public DateTimeTimeZone StartTime { get; set; }
#endif
        /// <summary>
        /// Instantiates a new getSchedulePostRequestBody and sets the default values.
        /// </summary>
        public GetSchedulePostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetSchedulePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetSchedulePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"availabilityViewInterval", n => { AvailabilityViewInterval = n.GetIntValue(); } },
                {"endTime", n => { EndTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"schedules", n => { Schedules = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"startTime", n => { StartTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
