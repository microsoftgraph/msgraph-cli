using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ChatMessage : Entity, IParsable {
        /// <summary>References to attached objects like files, tabs, meetings etc.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ChatMessageAttachment> Attachments { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ItemBody Body { get; set; }
        /// <summary>If the message was sent in a channel, represents identity of the channel.</summary>
        public ApiSdk.Models.Microsoft.Graph.ChannelIdentity ChannelIdentity { get; set; }
        /// <summary>If the message was sent in a chat, represents the identity of the chat.</summary>
        public string ChatId { get; set; }
        /// <summary>Timestamp of when the chat message was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read only. Timestamp at which the chat message was deleted, or null if not deleted.</summary>
        public DateTimeOffset? DeletedDateTime { get; set; }
        /// <summary>Read-only. Version number of the chat message.</summary>
        public string Etag { get; set; }
        /// <summary>Read-only. If present, represents details of an event that happened in a chat, a channel, or a team, for example, adding new members. For event messages, the messageType property will be set to systemEventMessage.</summary>
        public ApiSdk.Models.Microsoft.Graph.EventMessageDetail EventDetail { get; set; }
        /// <summary>Details of the sender of the chat message. Can only be set during migration.</summary>
        public ApiSdk.Models.Microsoft.Graph.ChatMessageFromIdentitySet From { get; set; }
        /// <summary>Content in a message hosted by Microsoft Teams - for example, images or code snippets.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ChatMessageHostedContent> HostedContents { get; set; }
        /// <summary>The importance of the chat message. The possible values are: normal, high, urgent.</summary>
        public ChatMessageImportance? Importance { get; set; }
        /// <summary>Read only. Timestamp when edits to the chat message were made. Triggers an 'Edited' flag in the Teams UI. If no edits are made the value is null.</summary>
        public DateTimeOffset? LastEditedDateTime { get; set; }
        /// <summary>Read only. Timestamp when the chat message is created (initial setting) or modified, including when a reaction is added or removed.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Locale of the chat message set by the client. Always set to en-us.</summary>
        public string Locale { get; set; }
        /// <summary>List of entities mentioned in the chat message. Supported entities are: user, bot, team, and channel.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ChatMessageMention> Mentions { get; set; }
        /// <summary>The type of chat message. The possible values are: message, chatEvent, typing, unknownFutureValue, systemEventMessage. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value in this evolvable enum: systemEventMessage.</summary>
        public ChatMessageType? MessageType { get; set; }
        /// <summary>Defines the properties of a policy violation set by a data loss prevention (DLP) application.</summary>
        public ApiSdk.Models.Microsoft.Graph.ChatMessagePolicyViolation PolicyViolation { get; set; }
        /// <summary>Reactions for this chat message (for example, Like).</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ChatMessageReaction> Reactions { get; set; }
        /// <summary>Replies for a specified message.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ChatMessage> Replies { get; set; }
        /// <summary>Read-only. ID of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels, not chats.)</summary>
        public string ReplyToId { get; set; }
        /// <summary>The subject of the chat message, in plaintext.</summary>
        public string Subject { get; set; }
        /// <summary>Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.</summary>
        public string Summary { get; set; }
        /// <summary>Read-only. Link to the message in Microsoft Teams.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ChatMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"attachments", (o,n) => { (o as ChatMessage).Attachments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessageAttachment>(ApiSdk.Models.Microsoft.Graph.ChatMessageAttachment.CreateFromDiscriminatorValue).ToList(); } },
                {"body", (o,n) => { (o as ChatMessage).Body = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemBody>(ApiSdk.Models.Microsoft.Graph.ItemBody.CreateFromDiscriminatorValue); } },
                {"channelIdentity", (o,n) => { (o as ChatMessage).ChannelIdentity = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ChannelIdentity>(ApiSdk.Models.Microsoft.Graph.ChannelIdentity.CreateFromDiscriminatorValue); } },
                {"chatId", (o,n) => { (o as ChatMessage).ChatId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as ChatMessage).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deletedDateTime", (o,n) => { (o as ChatMessage).DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"etag", (o,n) => { (o as ChatMessage).Etag = n.GetStringValue(); } },
                {"eventDetail", (o,n) => { (o as ChatMessage).EventDetail = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EventMessageDetail>(ApiSdk.Models.Microsoft.Graph.EventMessageDetail.CreateFromDiscriminatorValue); } },
                {"from", (o,n) => { (o as ChatMessage).From = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ChatMessageFromIdentitySet>(ApiSdk.Models.Microsoft.Graph.ChatMessageFromIdentitySet.CreateFromDiscriminatorValue); } },
                {"hostedContents", (o,n) => { (o as ChatMessage).HostedContents = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessageHostedContent>(ApiSdk.Models.Microsoft.Graph.ChatMessageHostedContent.CreateFromDiscriminatorValue).ToList(); } },
                {"importance", (o,n) => { (o as ChatMessage).Importance = n.GetEnumValue<ChatMessageImportance>(); } },
                {"lastEditedDateTime", (o,n) => { (o as ChatMessage).LastEditedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ChatMessage).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"locale", (o,n) => { (o as ChatMessage).Locale = n.GetStringValue(); } },
                {"mentions", (o,n) => { (o as ChatMessage).Mentions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessageMention>(ApiSdk.Models.Microsoft.Graph.ChatMessageMention.CreateFromDiscriminatorValue).ToList(); } },
                {"messageType", (o,n) => { (o as ChatMessage).MessageType = n.GetEnumValue<ChatMessageType>(); } },
                {"policyViolation", (o,n) => { (o as ChatMessage).PolicyViolation = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ChatMessagePolicyViolation>(ApiSdk.Models.Microsoft.Graph.ChatMessagePolicyViolation.CreateFromDiscriminatorValue); } },
                {"reactions", (o,n) => { (o as ChatMessage).Reactions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessageReaction>(ApiSdk.Models.Microsoft.Graph.ChatMessageReaction.CreateFromDiscriminatorValue).ToList(); } },
                {"replies", (o,n) => { (o as ChatMessage).Replies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessage>(ApiSdk.Models.Microsoft.Graph.ChatMessage.CreateFromDiscriminatorValue).ToList(); } },
                {"replyToId", (o,n) => { (o as ChatMessage).ReplyToId = n.GetStringValue(); } },
                {"subject", (o,n) => { (o as ChatMessage).Subject = n.GetStringValue(); } },
                {"summary", (o,n) => { (o as ChatMessage).Summary = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as ChatMessage).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessageAttachment>("attachments", Attachments);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemBody>("body", Body);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ChannelIdentity>("channelIdentity", ChannelIdentity);
            writer.WriteStringValue("chatId", ChatId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("etag", Etag);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EventMessageDetail>("eventDetail", EventDetail);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ChatMessageFromIdentitySet>("from", From);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessageHostedContent>("hostedContents", HostedContents);
            writer.WriteEnumValue<ChatMessageImportance>("importance", Importance);
            writer.WriteDateTimeOffsetValue("lastEditedDateTime", LastEditedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("locale", Locale);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessageMention>("mentions", Mentions);
            writer.WriteEnumValue<ChatMessageType>("messageType", MessageType);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ChatMessagePolicyViolation>("policyViolation", PolicyViolation);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessageReaction>("reactions", Reactions);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessage>("replies", Replies);
            writer.WriteStringValue("replyToId", ReplyToId);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("summary", Summary);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
