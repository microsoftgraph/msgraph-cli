using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AttendanceRecord : Entity, IParsable {
        /// <summary>List of time periods between joining and leaving a meeting.</summary>
        public List<AttendanceInterval> AttendanceIntervals { get; set; }
        /// <summary>Email address of the user associated with this atttendance record.</summary>
        public string EmailAddress { get; set; }
        /// <summary>Identity of the user associated with this atttendance record.</summary>
        public ApiSdk.Models.Microsoft.Graph.Identity Identity { get; set; }
        /// <summary>Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.</summary>
        public string Role { get; set; }
        /// <summary>Total duration of the attendances in seconds.</summary>
        public int? TotalAttendanceInSeconds { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AttendanceRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttendanceRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"attendanceIntervals", (o,n) => { (o as AttendanceRecord).AttendanceIntervals = n.GetCollectionOfObjectValues<AttendanceInterval>(AttendanceInterval.CreateFromDiscriminatorValue).ToList(); } },
                {"emailAddress", (o,n) => { (o as AttendanceRecord).EmailAddress = n.GetStringValue(); } },
                {"identity", (o,n) => { (o as AttendanceRecord).Identity = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>(ApiSdk.Models.Microsoft.Graph.Identity.CreateFromDiscriminatorValue); } },
                {"role", (o,n) => { (o as AttendanceRecord).Role = n.GetStringValue(); } },
                {"totalAttendanceInSeconds", (o,n) => { (o as AttendanceRecord).TotalAttendanceInSeconds = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AttendanceInterval>("attendanceIntervals", AttendanceIntervals);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>("identity", Identity);
            writer.WriteStringValue("role", Role);
            writer.WriteIntValue("totalAttendanceInSeconds", TotalAttendanceInSeconds);
        }
    }
}
