using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MessageRulePredicates : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the strings that should appear in the body of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> BodyContains { get; set; }
        /// <summary>Represents the strings that should appear in the body or subject of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> BodyOrSubjectContains { get; set; }
        /// <summary>Represents the categories that an incoming message should be labeled with in order for the condition or exception to apply.</summary>
        public List<string> Categories { get; set; }
        /// <summary>Represents the specific sender email addresses of an incoming message in order for the condition or exception to apply.</summary>
        public List<Recipient> FromAddresses { get; set; }
        /// <summary>Indicates whether an incoming message must have attachments in order for the condition or exception to apply.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>Represents the strings that appear in the headers of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> HeaderContains { get; set; }
        /// <summary>The importance that is stamped on an incoming message in order for the condition or exception to apply: low, normal, high.</summary>
        public Importance? Importance { get; set; }
        /// <summary>Indicates whether an incoming message must be an approval request in order for the condition or exception to apply.</summary>
        public bool? IsApprovalRequest { get; set; }
        /// <summary>Indicates whether an incoming message must be automatically forwarded in order for the condition or exception to apply.</summary>
        public bool? IsAutomaticForward { get; set; }
        /// <summary>Indicates whether an incoming message must be an auto reply in order for the condition or exception to apply.</summary>
        public bool? IsAutomaticReply { get; set; }
        /// <summary>Indicates whether an incoming message must be encrypted in order for the condition or exception to apply.</summary>
        public bool? IsEncrypted { get; set; }
        /// <summary>Indicates whether an incoming message must be a meeting request in order for the condition or exception to apply.</summary>
        public bool? IsMeetingRequest { get; set; }
        /// <summary>Indicates whether an incoming message must be a meeting response in order for the condition or exception to apply.</summary>
        public bool? IsMeetingResponse { get; set; }
        /// <summary>Indicates whether an incoming message must be a non-delivery report in order for the condition or exception to apply.</summary>
        public bool? IsNonDeliveryReport { get; set; }
        /// <summary>Indicates whether an incoming message must be permission controlled (RMS-protected) in order for the condition or exception to apply.</summary>
        public bool? IsPermissionControlled { get; set; }
        /// <summary>Indicates whether an incoming message must be a read receipt in order for the condition or exception to apply.</summary>
        public bool? IsReadReceipt { get; set; }
        /// <summary>Indicates whether an incoming message must be S/MIME-signed in order for the condition or exception to apply.</summary>
        public bool? IsSigned { get; set; }
        /// <summary>Indicates whether an incoming message must be a voice mail in order for the condition or exception to apply.</summary>
        public bool? IsVoicemail { get; set; }
        /// <summary>Represents the flag-for-action value that appears on an incoming message in order for the condition or exception to apply. The possible values are: any, call, doNotForward, followUp, fyi, forward, noResponseNecessary, read, reply, replyToAll, review.</summary>
        public MessageActionFlag? MessageActionFlag { get; set; }
        /// <summary>Indicates whether the owner of the mailbox must not be a recipient of an incoming message in order for the condition or exception to apply.</summary>
        public bool? NotSentToMe { get; set; }
        /// <summary>Represents the strings that appear in either the toRecipients or ccRecipients properties of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> RecipientContains { get; set; }
        /// <summary>Represents the strings that appear in the from property of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> SenderContains { get; set; }
        /// <summary>Represents the sensitivity level that must be stamped on an incoming message in order for the condition or exception to apply. The possible values are: normal, personal, private, confidential.</summary>
        public Sensitivity? Sensitivity { get; set; }
        /// <summary>Indicates whether the owner of the mailbox must be in the ccRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentCcMe { get; set; }
        /// <summary>Indicates whether the owner of the mailbox must be the only recipient in an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentOnlyToMe { get; set; }
        /// <summary>Represents the email addresses that an incoming message must have been sent to in order for the condition or exception to apply.</summary>
        public List<Recipient> SentToAddresses { get; set; }
        /// <summary>Indicates whether the owner of the mailbox must be in the toRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentToMe { get; set; }
        /// <summary>Indicates whether the owner of the mailbox must be in either a toRecipients or ccRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentToOrCcMe { get; set; }
        /// <summary>Represents the strings that appear in the subject of an incoming message in order for the condition or exception to apply.</summary>
        public List<string> SubjectContains { get; set; }
        /// <summary>Represents the minimum and maximum sizes (in kilobytes) that an incoming message must fall in between in order for the condition or exception to apply.</summary>
        public SizeRange WithinSizeRange { get; set; }
        /// <summary>
        /// Instantiates a new messageRulePredicates and sets the default values.
        /// </summary>
        public MessageRulePredicates() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bodyContains", (o,n) => { (o as MessageRulePredicates).BodyContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"bodyOrSubjectContains", (o,n) => { (o as MessageRulePredicates).BodyOrSubjectContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"categories", (o,n) => { (o as MessageRulePredicates).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"fromAddresses", (o,n) => { (o as MessageRulePredicates).FromAddresses = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"hasAttachments", (o,n) => { (o as MessageRulePredicates).HasAttachments = n.GetBoolValue(); } },
                {"headerContains", (o,n) => { (o as MessageRulePredicates).HeaderContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"importance", (o,n) => { (o as MessageRulePredicates).Importance = n.GetEnumValue<Importance>(); } },
                {"isApprovalRequest", (o,n) => { (o as MessageRulePredicates).IsApprovalRequest = n.GetBoolValue(); } },
                {"isAutomaticForward", (o,n) => { (o as MessageRulePredicates).IsAutomaticForward = n.GetBoolValue(); } },
                {"isAutomaticReply", (o,n) => { (o as MessageRulePredicates).IsAutomaticReply = n.GetBoolValue(); } },
                {"isEncrypted", (o,n) => { (o as MessageRulePredicates).IsEncrypted = n.GetBoolValue(); } },
                {"isMeetingRequest", (o,n) => { (o as MessageRulePredicates).IsMeetingRequest = n.GetBoolValue(); } },
                {"isMeetingResponse", (o,n) => { (o as MessageRulePredicates).IsMeetingResponse = n.GetBoolValue(); } },
                {"isNonDeliveryReport", (o,n) => { (o as MessageRulePredicates).IsNonDeliveryReport = n.GetBoolValue(); } },
                {"isPermissionControlled", (o,n) => { (o as MessageRulePredicates).IsPermissionControlled = n.GetBoolValue(); } },
                {"isReadReceipt", (o,n) => { (o as MessageRulePredicates).IsReadReceipt = n.GetBoolValue(); } },
                {"isSigned", (o,n) => { (o as MessageRulePredicates).IsSigned = n.GetBoolValue(); } },
                {"isVoicemail", (o,n) => { (o as MessageRulePredicates).IsVoicemail = n.GetBoolValue(); } },
                {"messageActionFlag", (o,n) => { (o as MessageRulePredicates).MessageActionFlag = n.GetEnumValue<MessageActionFlag>(); } },
                {"notSentToMe", (o,n) => { (o as MessageRulePredicates).NotSentToMe = n.GetBoolValue(); } },
                {"recipientContains", (o,n) => { (o as MessageRulePredicates).RecipientContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"senderContains", (o,n) => { (o as MessageRulePredicates).SenderContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sensitivity", (o,n) => { (o as MessageRulePredicates).Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"sentCcMe", (o,n) => { (o as MessageRulePredicates).SentCcMe = n.GetBoolValue(); } },
                {"sentOnlyToMe", (o,n) => { (o as MessageRulePredicates).SentOnlyToMe = n.GetBoolValue(); } },
                {"sentToAddresses", (o,n) => { (o as MessageRulePredicates).SentToAddresses = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"sentToMe", (o,n) => { (o as MessageRulePredicates).SentToMe = n.GetBoolValue(); } },
                {"sentToOrCcMe", (o,n) => { (o as MessageRulePredicates).SentToOrCcMe = n.GetBoolValue(); } },
                {"subjectContains", (o,n) => { (o as MessageRulePredicates).SubjectContains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"withinSizeRange", (o,n) => { (o as MessageRulePredicates).WithinSizeRange = n.GetObjectValue<SizeRange>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("bodyContains", BodyContains);
            writer.WriteCollectionOfPrimitiveValues<string>("bodyOrSubjectContains", BodyOrSubjectContains);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfObjectValues<Recipient>("fromAddresses", FromAddresses);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteCollectionOfPrimitiveValues<string>("headerContains", HeaderContains);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteBoolValue("isApprovalRequest", IsApprovalRequest);
            writer.WriteBoolValue("isAutomaticForward", IsAutomaticForward);
            writer.WriteBoolValue("isAutomaticReply", IsAutomaticReply);
            writer.WriteBoolValue("isEncrypted", IsEncrypted);
            writer.WriteBoolValue("isMeetingRequest", IsMeetingRequest);
            writer.WriteBoolValue("isMeetingResponse", IsMeetingResponse);
            writer.WriteBoolValue("isNonDeliveryReport", IsNonDeliveryReport);
            writer.WriteBoolValue("isPermissionControlled", IsPermissionControlled);
            writer.WriteBoolValue("isReadReceipt", IsReadReceipt);
            writer.WriteBoolValue("isSigned", IsSigned);
            writer.WriteBoolValue("isVoicemail", IsVoicemail);
            writer.WriteEnumValue<MessageActionFlag>("messageActionFlag", MessageActionFlag);
            writer.WriteBoolValue("notSentToMe", NotSentToMe);
            writer.WriteCollectionOfPrimitiveValues<string>("recipientContains", RecipientContains);
            writer.WriteCollectionOfPrimitiveValues<string>("senderContains", SenderContains);
            writer.WriteEnumValue<Sensitivity>("sensitivity", Sensitivity);
            writer.WriteBoolValue("sentCcMe", SentCcMe);
            writer.WriteBoolValue("sentOnlyToMe", SentOnlyToMe);
            writer.WriteCollectionOfObjectValues<Recipient>("sentToAddresses", SentToAddresses);
            writer.WriteBoolValue("sentToMe", SentToMe);
            writer.WriteBoolValue("sentToOrCcMe", SentToOrCcMe);
            writer.WriteCollectionOfPrimitiveValues<string>("subjectContains", SubjectContains);
            writer.WriteObjectValue<SizeRange>("withinSizeRange", WithinSizeRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
