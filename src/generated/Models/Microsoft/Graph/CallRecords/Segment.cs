using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.CallRecords {
    public class Segment : Entity, IParsable {
        /// <summary>Endpoint that answered this segment.</summary>
        public Endpoint Callee { get; set; }
        /// <summary>Endpoint that initiated this segment.</summary>
        public Endpoint Caller { get; set; }
        /// <summary>UTC time when the segment ended. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Failure information associated with the segment if it failed.</summary>
        public FailureInfo FailureInfo { get; set; }
        /// <summary>Media associated with this segment.</summary>
        public List<Media> Media { get; set; }
        /// <summary>UTC time when the segment started. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"callee", (o,n) => { (o as Segment).Callee = n.GetObjectValue<Endpoint>(); } },
                {"caller", (o,n) => { (o as Segment).Caller = n.GetObjectValue<Endpoint>(); } },
                {"endDateTime", (o,n) => { (o as Segment).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"failureInfo", (o,n) => { (o as Segment).FailureInfo = n.GetObjectValue<FailureInfo>(); } },
                {"media", (o,n) => { (o as Segment).Media = n.GetCollectionOfObjectValues<Media>().ToList(); } },
                {"startDateTime", (o,n) => { (o as Segment).StartDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteCollectionOfObjectValues<Media>("media", Media);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
