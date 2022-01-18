using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.CallRecords {
    public class Session : Entity, IParsable {
        /// <summary>Endpoint that answered the session.</summary>
        public Endpoint Callee { get; set; }
        /// <summary>Endpoint that initiated the session.</summary>
        public Endpoint Caller { get; set; }
        /// <summary>UTC time when the last user left the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Failure information associated with the session if the session failed.</summary>
        public FailureInfo FailureInfo { get; set; }
        /// <summary>List of modalities present in the session. Possible values are: unknown, audio, video, videoBasedScreenSharing, data, screenSharing, unknownFutureValue.</summary>
        public List<Modality?> Modalities { get; set; }
        /// <summary>The list of segments involved in the session. Read-only. Nullable.</summary>
        public List<Segment> Segments { get; set; }
        /// <summary>UTC fime when the first user joined the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"callee", (o,n) => { (o as Session).Callee = n.GetObjectValue<Endpoint>(); } },
                {"caller", (o,n) => { (o as Session).Caller = n.GetObjectValue<Endpoint>(); } },
                {"endDateTime", (o,n) => { (o as Session).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"failureInfo", (o,n) => { (o as Session).FailureInfo = n.GetObjectValue<FailureInfo>(); } },
                {"modalities", (o,n) => { (o as Session).Modalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"segments", (o,n) => { (o as Session).Segments = n.GetCollectionOfObjectValues<Segment>().ToList(); } },
                {"startDateTime", (o,n) => { (o as Session).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Endpoint>("callee", Callee);
            writer.WriteObjectValue<Endpoint>("caller", Caller);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<FailureInfo>("failureInfo", FailureInfo);
            writer.WriteCollectionOfEnumValues<Modality>("modalities", Modalities);
            writer.WriteCollectionOfObjectValues<Segment>("segments", Segments);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
