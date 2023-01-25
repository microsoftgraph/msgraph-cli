using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Message : OutlookItem, IParsable {
        /// <summary>The fileAttachment and itemAttachment attachments for the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Attachment>? Attachments { get; set; }
#nullable restore
#else
        public List<Attachment> Attachments { get; set; }
#endif
        /// <summary>The Bcc: recipients for the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? BccRecipients { get; set; }
#nullable restore
#else
        public List<Recipient> BccRecipients { get; set; }
#endif
        /// <summary>The body of the message. It can be in HTML or text format. Find out about safe HTML in a message body.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Body { get; set; }
#nullable restore
#else
        public ItemBody Body { get; set; }
#endif
        /// <summary>The first 255 characters of the message body. It is in text format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyPreview { get; set; }
#nullable restore
#else
        public string BodyPreview { get; set; }
#endif
        /// <summary>The Cc: recipients for the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? CcRecipients { get; set; }
#nullable restore
#else
        public List<Recipient> CcRecipients { get; set; }
#endif
        /// <summary>The ID of the conversation the email belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversationId { get; set; }
#nullable restore
#else
        public string ConversationId { get; set; }
#endif
        /// <summary>Indicates the position of the message within the conversation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ConversationIndex { get; set; }
#nullable restore
#else
        public byte[] ConversationIndex { get; set; }
#endif
        /// <summary>The collection of open extensions defined for the message. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions { get; set; }
#nullable restore
#else
        public List<Extension> Extensions { get; set; }
#endif
        /// <summary>The flag value that indicates the status, start date, due date, or completion date for the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FollowupFlag? Flag { get; set; }
#nullable restore
#else
        public FollowupFlag Flag { get; set; }
#endif
        /// <summary>The owner of the mailbox from which the message is sent. In most cases, this value is the same as the sender property, except for sharing or delegation scenarios. The value must correspond to the actual mailbox used. Find out more about setting the from and sender properties of a message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Recipient? From { get; set; }
#nullable restore
#else
        public Recipient From { get; set; }
#endif
        /// <summary>Indicates whether the message has attachments. This property doesn&apos;t include inline attachments, so if a message contains only inline attachments, this property is false. To verify the existence of inline attachments, parse the body property to look for a src attribute, such as &lt;IMG src=&apos;cid:image001.jpg@01D26CD8.6C05F070&apos;&gt;.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>The importance property</summary>
        public ApiSdk.Models.Importance? Importance { get; set; }
        /// <summary>The inferenceClassification property</summary>
        public InferenceClassificationType? InferenceClassification { get; set; }
        /// <summary>The internetMessageHeaders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InternetMessageHeader>? InternetMessageHeaders { get; set; }
#nullable restore
#else
        public List<InternetMessageHeader> InternetMessageHeaders { get; set; }
#endif
        /// <summary>The internetMessageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternetMessageId { get; set; }
#nullable restore
#else
        public string InternetMessageId { get; set; }
#endif
        /// <summary>The isDeliveryReceiptRequested property</summary>
        public bool? IsDeliveryReceiptRequested { get; set; }
        /// <summary>The isDraft property</summary>
        public bool? IsDraft { get; set; }
        /// <summary>The isRead property</summary>
        public bool? IsRead { get; set; }
        /// <summary>The isReadReceiptRequested property</summary>
        public bool? IsReadReceiptRequested { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the message. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
#endif
        /// <summary>The parentFolderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentFolderId { get; set; }
#nullable restore
#else
        public string ParentFolderId { get; set; }
#endif
        /// <summary>The receivedDateTime property</summary>
        public DateTimeOffset? ReceivedDateTime { get; set; }
        /// <summary>The replyTo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? ReplyTo { get; set; }
#nullable restore
#else
        public List<Recipient> ReplyTo { get; set; }
#endif
        /// <summary>The sender property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Recipient? Sender { get; set; }
#nullable restore
#else
        public Recipient Sender { get; set; }
#endif
        /// <summary>The sentDateTime property</summary>
        public DateTimeOffset? SentDateTime { get; set; }
        /// <summary>The collection of single-value extended properties defined for the message. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The toRecipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? ToRecipients { get; set; }
#nullable restore
#else
        public List<Recipient> ToRecipients { get; set; }
#endif
        /// <summary>The uniqueBody property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? UniqueBody { get; set; }
#nullable restore
#else
        public ItemBody UniqueBody { get; set; }
#endif
        /// <summary>The webLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebLink { get; set; }
#nullable restore
#else
        public string WebLink { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Message and sets the default values.
        /// </summary>
        public Message() : base() {
            OdataType = "#microsoft.graph.message";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Message CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.calendarSharingMessage" => new CalendarSharingMessage(),
                "#microsoft.graph.eventMessage" => new EventMessage(),
                "#microsoft.graph.eventMessageRequest" => new EventMessageRequest(),
                "#microsoft.graph.eventMessageResponse" => new EventMessageResponse(),
                _ => new Message(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bccRecipients", n => { BccRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyPreview", n => { BodyPreview = n.GetStringValue(); } },
                {"ccRecipients", n => { CcRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conversationId", n => { ConversationId = n.GetStringValue(); } },
                {"conversationIndex", n => { ConversationIndex = n.GetByteArrayValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"flag", n => { Flag = n.GetObjectValue<FollowupFlag>(FollowupFlag.CreateFromDiscriminatorValue); } },
                {"from", n => { From = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"inferenceClassification", n => { InferenceClassification = n.GetEnumValue<InferenceClassificationType>(); } },
                {"internetMessageHeaders", n => { InternetMessageHeaders = n.GetCollectionOfObjectValues<InternetMessageHeader>(InternetMessageHeader.CreateFromDiscriminatorValue)?.ToList(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"isDeliveryReceiptRequested", n => { IsDeliveryReceiptRequested = n.GetBoolValue(); } },
                {"isDraft", n => { IsDraft = n.GetBoolValue(); } },
                {"isRead", n => { IsRead = n.GetBoolValue(); } },
                {"isReadReceiptRequested", n => { IsReadReceiptRequested = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"replyTo", n => { ReplyTo = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sender", n => { Sender = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"sentDateTime", n => { SentDateTime = n.GetDateTimeOffsetValue(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"toRecipients", n => { ToRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"uniqueBody", n => { UniqueBody = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"webLink", n => { WebLink = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<Recipient>("bccRecipients", BccRecipients);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("bodyPreview", BodyPreview);
            writer.WriteCollectionOfObjectValues<Recipient>("ccRecipients", CcRecipients);
            writer.WriteStringValue("conversationId", ConversationId);
            writer.WriteByteArrayValue("conversationIndex", ConversationIndex);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteObjectValue<FollowupFlag>("flag", Flag);
            writer.WriteObjectValue<Recipient>("from", From);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteEnumValue<InferenceClassificationType>("inferenceClassification", InferenceClassification);
            writer.WriteCollectionOfObjectValues<InternetMessageHeader>("internetMessageHeaders", InternetMessageHeaders);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteBoolValue("isDeliveryReceiptRequested", IsDeliveryReceiptRequested);
            writer.WriteBoolValue("isDraft", IsDraft);
            writer.WriteBoolValue("isRead", IsRead);
            writer.WriteBoolValue("isReadReceiptRequested", IsReadReceiptRequested);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteCollectionOfObjectValues<Recipient>("replyTo", ReplyTo);
            writer.WriteObjectValue<Recipient>("sender", Sender);
            writer.WriteDateTimeOffsetValue("sentDateTime", SentDateTime);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<Recipient>("toRecipients", ToRecipients);
            writer.WriteObjectValue<ItemBody>("uniqueBody", UniqueBody);
            writer.WriteStringValue("webLink", WebLink);
        }
    }
}
