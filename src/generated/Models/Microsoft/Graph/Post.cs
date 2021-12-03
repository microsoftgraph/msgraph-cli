using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Post : OutlookItem, IParsable {
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public List<Attachment> Attachments { get; set; }
        /// <summary>The contents of the post. This is a default property. This property can be null.</summary>
        public ItemBody Body { get; set; }
        /// <summary>Unique ID of the conversation. Read-only.</summary>
        public string ConversationId { get; set; }
        /// <summary>Unique ID of the conversation thread. Read-only.</summary>
        public string ConversationThreadId { get; set; }
        /// <summary>The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.</summary>
        public List<Extension> Extensions { get; set; }
        public Recipient From { get; set; }
        /// <summary>Indicates whether the post has at least one attachment. This is a default property.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>Read-only. Supports $expand.</summary>
        public Post InReplyTo { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the post. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>Conversation participants that were added to the thread as part of this post.</summary>
        public List<Recipient> NewParticipants { get; set; }
        /// <summary>Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReceivedDateTime { get; set; }
        /// <summary>Contains the address of the sender. The value of Sender is assumed to be the address of the authenticated user in the case when Sender is not specified. This is a default property.</summary>
        public Recipient Sender { get; set; }
        /// <summary>The collection of single-value extended properties defined for the post. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"attachments", (o,n) => { (o as Post).Attachments = n.GetCollectionOfObjectValues<Attachment>().ToList(); } },
                {"body", (o,n) => { (o as Post).Body = n.GetObjectValue<ItemBody>(); } },
                {"conversationId", (o,n) => { (o as Post).ConversationId = n.GetStringValue(); } },
                {"conversationThreadId", (o,n) => { (o as Post).ConversationThreadId = n.GetStringValue(); } },
                {"extensions", (o,n) => { (o as Post).Extensions = n.GetCollectionOfObjectValues<Extension>().ToList(); } },
                {"from", (o,n) => { (o as Post).From = n.GetObjectValue<Recipient>(); } },
                {"hasAttachments", (o,n) => { (o as Post).HasAttachments = n.GetBoolValue(); } },
                {"inReplyTo", (o,n) => { (o as Post).InReplyTo = n.GetObjectValue<Post>(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Post).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>().ToList(); } },
                {"newParticipants", (o,n) => { (o as Post).NewParticipants = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"receivedDateTime", (o,n) => { (o as Post).ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sender", (o,n) => { (o as Post).Sender = n.GetObjectValue<Recipient>(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Post).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("conversationId", ConversationId);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteObjectValue<Recipient>("from", From);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteObjectValue<Post>("inReplyTo", InReplyTo);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteCollectionOfObjectValues<Recipient>("newParticipants", NewParticipants);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteObjectValue<Recipient>("sender", Sender);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
