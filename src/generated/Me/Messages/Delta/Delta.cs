using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.Messages.Delta {
    public class Delta : OutlookItem, IParsable {
        /// <summary>The fileAttachment and itemAttachment attachments for the message.</summary>
        public List<Attachment> Attachments { get; set; }
        /// <summary>The Bcc: recipients for the message.</summary>
        public List<Recipient> BccRecipients { get; set; }
        /// <summary>The body of the message. It can be in HTML or text format. Find out about safe HTML in a message body.</summary>
        public ItemBody Body { get; set; }
        /// <summary>The first 255 characters of the message body. It is in text format. If the message contains instances of mention, this property would contain a concatenation of these mentions as well.</summary>
        public string BodyPreview { get; set; }
        /// <summary>The Cc: recipients for the message.</summary>
        public List<Recipient> CcRecipients { get; set; }
        /// <summary>The ID of the conversation the email belongs to.</summary>
        public string ConversationId { get; set; }
        /// <summary>Indicates the position of the message within the conversation.</summary>
        public byte[] ConversationIndex { get; set; }
        /// <summary>The collection of open extensions defined for the message. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>The flag value that indicates the status, start date, due date, or completion date for the message.</summary>
        public FollowupFlag Flag { get; set; }
        /// <summary>The owner of the mailbox from which the message is sent. In most cases, this value is the same as the sender property, except for sharing or delegation scenarios. The value must correspond to the actual mailbox used. Find out more about setting the from and sender properties of a message.</summary>
        public Recipient From { get; set; }
        /// <summary>Indicates whether the message has attachments. This property doesn't include inline attachments, so if a message contains only inline attachments, this property is false. To verify the existence of inline attachments, parse the body property to look for a src attribute, such as <IMG src='cid:image001.jpg@01D26CD8.6C05F070'>.</summary>
        public bool? HasAttachments { get; set; }
        public Importance? Importance { get; set; }
        public InferenceClassificationType? InferenceClassification { get; set; }
        public List<InternetMessageHeader> InternetMessageHeaders { get; set; }
        public string InternetMessageId { get; set; }
        public bool? IsDeliveryReceiptRequested { get; set; }
        public bool? IsDraft { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsReadReceiptRequested { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the message. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        public string ParentFolderId { get; set; }
        public DateTimeOffset? ReceivedDateTime { get; set; }
        public List<Recipient> ReplyTo { get; set; }
        public Recipient Sender { get; set; }
        public DateTimeOffset? SentDateTime { get; set; }
        /// <summary>The collection of single-value extended properties defined for the message. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        public string Subject { get; set; }
        public List<Recipient> ToRecipients { get; set; }
        public ItemBody UniqueBody { get; set; }
        public string WebLink { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"attachments", (o,n) => { (o as Delta).Attachments = n.GetCollectionOfObjectValues<Attachment>().ToList(); } },
                {"bccRecipients", (o,n) => { (o as Delta).BccRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"body", (o,n) => { (o as Delta).Body = n.GetObjectValue<ItemBody>(); } },
                {"bodyPreview", (o,n) => { (o as Delta).BodyPreview = n.GetStringValue(); } },
                {"ccRecipients", (o,n) => { (o as Delta).CcRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"conversationId", (o,n) => { (o as Delta).ConversationId = n.GetStringValue(); } },
                {"conversationIndex", (o,n) => { (o as Delta).ConversationIndex = n.GetByteArrayValue(); } },
                {"extensions", (o,n) => { (o as Delta).Extensions = n.GetCollectionOfObjectValues<Extension>().ToList(); } },
                {"flag", (o,n) => { (o as Delta).Flag = n.GetObjectValue<FollowupFlag>(); } },
                {"from", (o,n) => { (o as Delta).From = n.GetObjectValue<Recipient>(); } },
                {"hasAttachments", (o,n) => { (o as Delta).HasAttachments = n.GetBoolValue(); } },
                {"importance", (o,n) => { (o as Delta).Importance = n.GetEnumValue<Importance>(); } },
                {"inferenceClassification", (o,n) => { (o as Delta).InferenceClassification = n.GetEnumValue<InferenceClassificationType>(); } },
                {"internetMessageHeaders", (o,n) => { (o as Delta).InternetMessageHeaders = n.GetCollectionOfObjectValues<InternetMessageHeader>().ToList(); } },
                {"internetMessageId", (o,n) => { (o as Delta).InternetMessageId = n.GetStringValue(); } },
                {"isDeliveryReceiptRequested", (o,n) => { (o as Delta).IsDeliveryReceiptRequested = n.GetBoolValue(); } },
                {"isDraft", (o,n) => { (o as Delta).IsDraft = n.GetBoolValue(); } },
                {"isRead", (o,n) => { (o as Delta).IsRead = n.GetBoolValue(); } },
                {"isReadReceiptRequested", (o,n) => { (o as Delta).IsReadReceiptRequested = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Delta).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>().ToList(); } },
                {"parentFolderId", (o,n) => { (o as Delta).ParentFolderId = n.GetStringValue(); } },
                {"receivedDateTime", (o,n) => { (o as Delta).ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"replyTo", (o,n) => { (o as Delta).ReplyTo = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"sender", (o,n) => { (o as Delta).Sender = n.GetObjectValue<Recipient>(); } },
                {"sentDateTime", (o,n) => { (o as Delta).SentDateTime = n.GetDateTimeOffsetValue(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Delta).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>().ToList(); } },
                {"subject", (o,n) => { (o as Delta).Subject = n.GetStringValue(); } },
                {"toRecipients", (o,n) => { (o as Delta).ToRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"uniqueBody", (o,n) => { (o as Delta).UniqueBody = n.GetObjectValue<ItemBody>(); } },
                {"webLink", (o,n) => { (o as Delta).WebLink = n.GetStringValue(); } },
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
