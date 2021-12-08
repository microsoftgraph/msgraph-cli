using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Conversation : Entity, IParsable {
        /// <summary>Indicates whether any of the posts within this Conversation has at least one attachment. Supports $filter (eq, ne) and $search.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastDeliveredDateTime { get; set; }
        /// <summary>A short summary from the body of the latest post in this conversation. Supports $filter (eq, ne, le, ge).</summary>
        public string Preview { get; set; }
        /// <summary>A collection of all the conversation threads in the conversation. A navigation property. Read-only. Nullable.</summary>
        public List<ConversationThread> Threads { get; set; }
        /// <summary>The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.</summary>
        public string Topic { get; set; }
        /// <summary>All the users that sent a message to this Conversation.</summary>
        public List<string> UniqueSenders { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"hasAttachments", (o,n) => { (o as Conversation).HasAttachments = n.GetBoolValue(); } },
                {"lastDeliveredDateTime", (o,n) => { (o as Conversation).LastDeliveredDateTime = n.GetDateTimeOffsetValue(); } },
                {"preview", (o,n) => { (o as Conversation).Preview = n.GetStringValue(); } },
                {"threads", (o,n) => { (o as Conversation).Threads = n.GetCollectionOfObjectValues<ConversationThread>().ToList(); } },
                {"topic", (o,n) => { (o as Conversation).Topic = n.GetStringValue(); } },
                {"uniqueSenders", (o,n) => { (o as Conversation).UniqueSenders = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteDateTimeOffsetValue("lastDeliveredDateTime", LastDeliveredDateTime);
            writer.WriteStringValue("preview", Preview);
            writer.WriteCollectionOfObjectValues<ConversationThread>("threads", Threads);
            writer.WriteStringValue("topic", Topic);
            writer.WriteCollectionOfPrimitiveValues<string>("uniqueSenders", UniqueSenders);
        }
    }
}
