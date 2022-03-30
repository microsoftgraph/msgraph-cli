using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Post : OutlookItem, IParsable {
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Attachment> Attachments { get; set; }
        /// <summary>The contents of the post. This is a default property. This property can be null.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemBody Body { get; set; }
        /// <summary>Unique ID of the conversation. Read-only.</summary>
        public string ConversationId { get; set; }
        /// <summary>Unique ID of the conversation thread. Read-only.</summary>
        public string ConversationThreadId { get; set; }
        /// <summary>The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Extension> Extensions { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Recipient From { get; set; }
        /// <summary>Indicates whether the post has at least one attachment. This is a default property.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>Read-only. Supports $expand.</summary>
        public ApiSdk.Models.Microsoft.Graph.Post InReplyTo { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the post. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>Conversation participants that were added to the thread as part of this post.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Recipient> NewParticipants { get; set; }
        /// <summary>Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ReceivedDateTime { get; set; }
        /// <summary>Contains the address of the sender. The value of Sender is assumed to be the address of the authenticated user in the case when Sender is not specified. This is a default property.</summary>
        public ApiSdk.Models.Microsoft.Graph.Recipient Sender { get; set; }
        /// <summary>The collection of single-value extended properties defined for the post. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Post CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Post();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"attachments", (o,n) => { (o as Post).Attachments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Attachment>(ApiSdk.Models.Microsoft.Graph.Attachment.CreateFromDiscriminatorValue).ToList(); } },
                {"body", (o,n) => { (o as Post).Body = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemBody>(ApiSdk.Models.Microsoft.Graph.ItemBody.CreateFromDiscriminatorValue); } },
                {"conversationId", (o,n) => { (o as Post).ConversationId = n.GetStringValue(); } },
                {"conversationThreadId", (o,n) => { (o as Post).ConversationThreadId = n.GetStringValue(); } },
                {"extensions", (o,n) => { (o as Post).Extensions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Extension>(ApiSdk.Models.Microsoft.Graph.Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"from", (o,n) => { (o as Post).From = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Recipient>(ApiSdk.Models.Microsoft.Graph.Recipient.CreateFromDiscriminatorValue); } },
                {"hasAttachments", (o,n) => { (o as Post).HasAttachments = n.GetBoolValue(); } },
                {"inReplyTo", (o,n) => { (o as Post).InReplyTo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Post>(ApiSdk.Models.Microsoft.Graph.Post.CreateFromDiscriminatorValue); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Post).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MultiValueLegacyExtendedProperty>(ApiSdk.Models.Microsoft.Graph.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"newParticipants", (o,n) => { (o as Post).NewParticipants = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Recipient>(ApiSdk.Models.Microsoft.Graph.Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"receivedDateTime", (o,n) => { (o as Post).ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sender", (o,n) => { (o as Post).Sender = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Recipient>(ApiSdk.Models.Microsoft.Graph.Recipient.CreateFromDiscriminatorValue); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Post).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SingleValueLegacyExtendedProperty>(ApiSdk.Models.Microsoft.Graph.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Attachment>("attachments", Attachments);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemBody>("body", Body);
            writer.WriteStringValue("conversationId", ConversationId);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Extension>("extensions", Extensions);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Recipient>("from", From);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Post>("inReplyTo", InReplyTo);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Recipient>("newParticipants", NewParticipants);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Recipient>("sender", Sender);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
