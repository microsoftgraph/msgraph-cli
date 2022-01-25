using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConversationThread : Entity, IParsable {
        /// <summary>The Cc: recipients for the thread. Returned only on $select.</summary>
        public List<Recipient> CcRecipients { get; set; }
        /// <summary>Indicates whether any of the posts within this thread has at least one attachment. Returned by default.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>Indicates if the thread is locked. Returned by default.</summary>
        public bool? IsLocked { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default.</summary>
        public DateTimeOffset? LastDeliveredDateTime { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<Post> Posts { get; set; }
        /// <summary>A short summary from the body of the latest post in this conversation. Returned by default.</summary>
        public string Preview { get; set; }
        /// <summary>The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated. Returned by default.</summary>
        public string Topic { get; set; }
        /// <summary>The To: recipients for the thread. Returned only on $select.</summary>
        public List<Recipient> ToRecipients { get; set; }
        /// <summary>All the users that sent a message to this thread. Returned by default.</summary>
        public List<string> UniqueSenders { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"ccRecipients", (o,n) => { (o as ConversationThread).CcRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"hasAttachments", (o,n) => { (o as ConversationThread).HasAttachments = n.GetBoolValue(); } },
                {"isLocked", (o,n) => { (o as ConversationThread).IsLocked = n.GetBoolValue(); } },
                {"lastDeliveredDateTime", (o,n) => { (o as ConversationThread).LastDeliveredDateTime = n.GetDateTimeOffsetValue(); } },
                {"posts", (o,n) => { (o as ConversationThread).Posts = n.GetCollectionOfObjectValues<Post>().ToList(); } },
                {"preview", (o,n) => { (o as ConversationThread).Preview = n.GetStringValue(); } },
                {"topic", (o,n) => { (o as ConversationThread).Topic = n.GetStringValue(); } },
                {"toRecipients", (o,n) => { (o as ConversationThread).ToRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"uniqueSenders", (o,n) => { (o as ConversationThread).UniqueSenders = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Recipient>("ccRecipients", CcRecipients);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("isLocked", IsLocked);
            writer.WriteDateTimeOffsetValue("lastDeliveredDateTime", LastDeliveredDateTime);
            writer.WriteCollectionOfObjectValues<Post>("posts", Posts);
            writer.WriteStringValue("preview", Preview);
            writer.WriteStringValue("topic", Topic);
            writer.WriteCollectionOfObjectValues<Recipient>("toRecipients", ToRecipients);
            writer.WriteCollectionOfPrimitiveValues<string>("uniqueSenders", UniqueSenders);
        }
    }
}
