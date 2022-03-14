using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AttendanceInterval : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Duration of the meeting interval in seconds; that is, the difference between joinDateTime and leaveDateTime.</summary>
        public int? DurationInSeconds { get; set; }
        /// <summary>The time the attendee joined in UTC.</summary>
        public DateTimeOffset? JoinDateTime { get; set; }
        /// <summary>The time the attendee left in UTC.</summary>
        public DateTimeOffset? LeaveDateTime { get; set; }
        /// <summary>
        /// Instantiates a new attendanceInterval and sets the default values.
        /// </summary>
        public AttendanceInterval() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AttendanceInterval CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttendanceInterval();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"durationInSeconds", (o,n) => { (o as AttendanceInterval).DurationInSeconds = n.GetIntValue(); } },
                {"joinDateTime", (o,n) => { (o as AttendanceInterval).JoinDateTime = n.GetDateTimeOffsetValue(); } },
                {"leaveDateTime", (o,n) => { (o as AttendanceInterval).LeaveDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("durationInSeconds", DurationInSeconds);
            writer.WriteDateTimeOffsetValue("joinDateTime", JoinDateTime);
            writer.WriteDateTimeOffsetValue("leaveDateTime", LeaveDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
