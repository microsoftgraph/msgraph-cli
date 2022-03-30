using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnlineMeeting : Entity, IParsable {
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        public bool? AllowAttendeeToEnableCamera { get; set; }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        public bool? AllowAttendeeToEnableMic { get; set; }
        /// <summary>Specifies who can be a presenter in a meeting. Possible values are listed in the following table.</summary>
        public OnlineMeetingPresenters? AllowedPresenters { get; set; }
        /// <summary>Specifies the mode of meeting chat.</summary>
        public MeetingChatMode? AllowMeetingChat { get; set; }
        /// <summary>Indicates whether Teams reactions are enabled for the meeting.</summary>
        public bool? AllowTeamworkReactions { get; set; }
        /// <summary>The attendance reports of an online meeting. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MeetingAttendanceReport> AttendanceReports { get; set; }
        /// <summary>The content stream of the attendee report of a Microsoft Teams live event. Read-only.</summary>
        public byte[] AttendeeReport { get; set; }
        /// <summary>The phone access (dial-in) information for an online meeting. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.AudioConferencing AudioConferencing { get; set; }
        /// <summary>Settings related to a live event.</summary>
        public ApiSdk.Models.Microsoft.Graph.BroadcastMeetingSettings BroadcastSettings { get; set; }
        /// <summary>The chat information associated with this online meeting.</summary>
        public ApiSdk.Models.Microsoft.Graph.ChatInfo ChatInfo { get; set; }
        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>The meeting end time in UTC.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The external ID. A custom ID. Optional.</summary>
        public string ExternalId { get; set; }
        /// <summary>Indicates if this is a Teams live event.</summary>
        public bool? IsBroadcast { get; set; }
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        public bool? IsEntryExitAnnounced { get; set; }
        /// <summary>The join information in the language and locale variant specified in the Accept-Language request HTTP header. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemBody JoinInformation { get; set; }
        /// <summary>The join URL of the online meeting. Read-only.</summary>
        public string JoinWebUrl { get; set; }
        /// <summary>Specifies which participants can bypass the meeting   lobby.</summary>
        public ApiSdk.Models.Microsoft.Graph.LobbyBypassSettings LobbyBypassSettings { get; set; }
        /// <summary>The participants associated with the online meeting.  This includes the organizer and the attendees.</summary>
        public ApiSdk.Models.Microsoft.Graph.MeetingParticipants Participants { get; set; }
        /// <summary>Indicates whether to record the meeting automatically.</summary>
        public bool? RecordAutomatically { get; set; }
        /// <summary>The meeting start time in UTC.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The subject of the online meeting.</summary>
        public string Subject { get; set; }
        /// <summary>The video teleconferencing ID. Read-only.</summary>
        public string VideoTeleconferenceId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.OnlineMeeting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnlineMeeting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowAttendeeToEnableCamera", (o,n) => { (o as OnlineMeeting).AllowAttendeeToEnableCamera = n.GetBoolValue(); } },
                {"allowAttendeeToEnableMic", (o,n) => { (o as OnlineMeeting).AllowAttendeeToEnableMic = n.GetBoolValue(); } },
                {"allowedPresenters", (o,n) => { (o as OnlineMeeting).AllowedPresenters = n.GetEnumValue<OnlineMeetingPresenters>(); } },
                {"allowMeetingChat", (o,n) => { (o as OnlineMeeting).AllowMeetingChat = n.GetEnumValue<MeetingChatMode>(); } },
                {"allowTeamworkReactions", (o,n) => { (o as OnlineMeeting).AllowTeamworkReactions = n.GetBoolValue(); } },
                {"attendanceReports", (o,n) => { (o as OnlineMeeting).AttendanceReports = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MeetingAttendanceReport>(ApiSdk.Models.Microsoft.Graph.MeetingAttendanceReport.CreateFromDiscriminatorValue).ToList(); } },
                {"attendeeReport", (o,n) => { (o as OnlineMeeting).AttendeeReport = n.GetByteArrayValue(); } },
                {"audioConferencing", (o,n) => { (o as OnlineMeeting).AudioConferencing = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AudioConferencing>(ApiSdk.Models.Microsoft.Graph.AudioConferencing.CreateFromDiscriminatorValue); } },
                {"broadcastSettings", (o,n) => { (o as OnlineMeeting).BroadcastSettings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.BroadcastMeetingSettings>(ApiSdk.Models.Microsoft.Graph.BroadcastMeetingSettings.CreateFromDiscriminatorValue); } },
                {"chatInfo", (o,n) => { (o as OnlineMeeting).ChatInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ChatInfo>(ApiSdk.Models.Microsoft.Graph.ChatInfo.CreateFromDiscriminatorValue); } },
                {"creationDateTime", (o,n) => { (o as OnlineMeeting).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"endDateTime", (o,n) => { (o as OnlineMeeting).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", (o,n) => { (o as OnlineMeeting).ExternalId = n.GetStringValue(); } },
                {"isBroadcast", (o,n) => { (o as OnlineMeeting).IsBroadcast = n.GetBoolValue(); } },
                {"isEntryExitAnnounced", (o,n) => { (o as OnlineMeeting).IsEntryExitAnnounced = n.GetBoolValue(); } },
                {"joinInformation", (o,n) => { (o as OnlineMeeting).JoinInformation = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemBody>(ApiSdk.Models.Microsoft.Graph.ItemBody.CreateFromDiscriminatorValue); } },
                {"joinWebUrl", (o,n) => { (o as OnlineMeeting).JoinWebUrl = n.GetStringValue(); } },
                {"lobbyBypassSettings", (o,n) => { (o as OnlineMeeting).LobbyBypassSettings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.LobbyBypassSettings>(ApiSdk.Models.Microsoft.Graph.LobbyBypassSettings.CreateFromDiscriminatorValue); } },
                {"participants", (o,n) => { (o as OnlineMeeting).Participants = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.MeetingParticipants>(ApiSdk.Models.Microsoft.Graph.MeetingParticipants.CreateFromDiscriminatorValue); } },
                {"recordAutomatically", (o,n) => { (o as OnlineMeeting).RecordAutomatically = n.GetBoolValue(); } },
                {"startDateTime", (o,n) => { (o as OnlineMeeting).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", (o,n) => { (o as OnlineMeeting).Subject = n.GetStringValue(); } },
                {"videoTeleconferenceId", (o,n) => { (o as OnlineMeeting).VideoTeleconferenceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAttendeeToEnableCamera", AllowAttendeeToEnableCamera);
            writer.WriteBoolValue("allowAttendeeToEnableMic", AllowAttendeeToEnableMic);
            writer.WriteEnumValue<OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteEnumValue<MeetingChatMode>("allowMeetingChat", AllowMeetingChat);
            writer.WriteBoolValue("allowTeamworkReactions", AllowTeamworkReactions);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MeetingAttendanceReport>("attendanceReports", AttendanceReports);
            writer.WriteByteArrayValue("attendeeReport", AttendeeReport);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AudioConferencing>("audioConferencing", AudioConferencing);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.BroadcastMeetingSettings>("broadcastSettings", BroadcastSettings);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteBoolValue("isBroadcast", IsBroadcast);
            writer.WriteBoolValue("isEntryExitAnnounced", IsEntryExitAnnounced);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemBody>("joinInformation", JoinInformation);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.MeetingParticipants>("participants", Participants);
            writer.WriteBoolValue("recordAutomatically", RecordAutomatically);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("videoTeleconferenceId", VideoTeleconferenceId);
        }
    }
}
