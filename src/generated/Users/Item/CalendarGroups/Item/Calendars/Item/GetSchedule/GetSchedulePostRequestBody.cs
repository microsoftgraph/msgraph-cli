using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule {
    /// <summary>Provides operations to call the getSchedule method.</summary>
    public class GetSchedulePostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AvailabilityViewInterval property</summary>
        public int? AvailabilityViewInterval { get; set; }
        /// <summary>The EndTime property</summary>
        public DateTimeTimeZone EndTime { get; set; }
        /// <summary>The Schedules property</summary>
        public List<string> Schedules { get; set; }
        /// <summary>The StartTime property</summary>
        public DateTimeTimeZone StartTime { get; set; }
        /// <summary>
        /// Instantiates a new getSchedulePostRequestBody and sets the default values.
        /// </summary>
        public GetSchedulePostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetSchedulePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetSchedulePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AvailabilityViewInterval", n => { AvailabilityViewInterval = n.GetIntValue(); } },
                {"EndTime", n => { EndTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"Schedules", n => { Schedules = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"StartTime", n => { StartTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AvailabilityViewInterval", AvailabilityViewInterval);
            writer.WriteObjectValue<DateTimeTimeZone>("EndTime", EndTime);
            writer.WriteCollectionOfPrimitiveValues<string>("Schedules", Schedules);
            writer.WriteObjectValue<DateTimeTimeZone>("StartTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
