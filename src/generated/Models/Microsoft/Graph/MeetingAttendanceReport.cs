using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MeetingAttendanceReport : Entity, IParsable {
        /// <summary>List of attendance records of an attendance report. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AttendanceRecord> AttendanceRecords { get; set; }
        /// <summary>UTC time when the meeting ended. Read-only.</summary>
        public DateTimeOffset? MeetingEndDateTime { get; set; }
        /// <summary>UTC time when the meeting started. Read-only.</summary>
        public DateTimeOffset? MeetingStartDateTime { get; set; }
        /// <summary>Total number of participants. Read-only.</summary>
        public int? TotalParticipantCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.MeetingAttendanceReport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingAttendanceReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"attendanceRecords", (o,n) => { (o as MeetingAttendanceReport).AttendanceRecords = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AttendanceRecord>(ApiSdk.Models.Microsoft.Graph.AttendanceRecord.CreateFromDiscriminatorValue).ToList(); } },
                {"meetingEndDateTime", (o,n) => { (o as MeetingAttendanceReport).MeetingEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"meetingStartDateTime", (o,n) => { (o as MeetingAttendanceReport).MeetingStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"totalParticipantCount", (o,n) => { (o as MeetingAttendanceReport).TotalParticipantCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AttendanceRecord>("attendanceRecords", AttendanceRecords);
            writer.WriteDateTimeOffsetValue("meetingEndDateTime", MeetingEndDateTime);
            writer.WriteDateTimeOffsetValue("meetingStartDateTime", MeetingStartDateTime);
            writer.WriteIntValue("totalParticipantCount", TotalParticipantCount);
        }
    }
}
