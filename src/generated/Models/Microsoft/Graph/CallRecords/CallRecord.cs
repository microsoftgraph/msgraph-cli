using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.CallRecords {
    public class CallRecord : Entity, IParsable {
        /// <summary>UTC time when the last user left the call. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Meeting URL associated to the call. May not be available for a peerToPeer call record type.</summary>
        public string JoinWebUrl { get; set; }
        /// <summary>UTC time when the call record was created. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>List of all the modalities used in the call. Possible values are: unknown, audio, video, videoBasedScreenSharing, data, screenSharing, unknownFutureValue.</summary>
        public List<Modality?> Modalities { get; set; }
        /// <summary>The organizing party's identity.</summary>
        public IdentitySet Organizer { get; set; }
        /// <summary>List of distinct identities involved in the call.</summary>
        public List<IdentitySet> Participants { get; set; }
        /// <summary>List of sessions involved in the call. Peer-to-peer calls typically only have one session, whereas group calls typically have at least one session per participant. Read-only. Nullable.</summary>
        public List<Session> Sessions { get; set; }
        /// <summary>UTC time when the first user joined the call. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Indicates the type of the call. Possible values are: unknown, groupCall, peerToPeer, unknownFutureValue.</summary>
        public CallType? Type { get; set; }
        /// <summary>Monotonically increasing version of the call record. Higher version call records with the same ID includes additional data compared to the lower version.</summary>
        public long? Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"endDateTime", (o,n) => { (o as CallRecord).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"joinWebUrl", (o,n) => { (o as CallRecord).JoinWebUrl = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as CallRecord).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"modalities", (o,n) => { (o as CallRecord).Modalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"organizer", (o,n) => { (o as CallRecord).Organizer = n.GetObjectValue<IdentitySet>(); } },
                {"participants", (o,n) => { (o as CallRecord).Participants = n.GetCollectionOfObjectValues<IdentitySet>().ToList(); } },
                {"sessions", (o,n) => { (o as CallRecord).Sessions = n.GetCollectionOfObjectValues<Session>().ToList(); } },
                {"startDateTime", (o,n) => { (o as CallRecord).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"type", (o,n) => { (o as CallRecord).Type = n.GetEnumValue<CallType>(); } },
                {"version", (o,n) => { (o as CallRecord).Version = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfEnumValues<Modality>("modalities", Modalities);
            writer.WriteObjectValue<IdentitySet>("organizer", Organizer);
            writer.WriteCollectionOfObjectValues<IdentitySet>("participants", Participants);
            writer.WriteCollectionOfObjectValues<Session>("sessions", Sessions);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<CallType>("type", Type);
            writer.WriteLongValue("version", Version);
        }
    }
}
