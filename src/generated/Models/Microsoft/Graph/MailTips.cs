using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MailTips : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Mail tips for automatic reply if it has been set up by the recipient.</summary>
        public AutomaticRepliesMailTips AutomaticReplies { get; set; }
        /// <summary>A custom mail tip that can be set on the recipient's mailbox.</summary>
        public string CustomMailTip { get; set; }
        /// <summary>Whether the recipient's mailbox is restricted, for example, accepting messages from only a predefined list of senders, rejecting messages from a predefined list of senders, or accepting messages from only authenticated senders.</summary>
        public bool? DeliveryRestricted { get; set; }
        /// <summary>The email address of the recipient to get mailtips for.</summary>
        public ApiSdk.Models.Microsoft.Graph.EmailAddress EmailAddress { get; set; }
        /// <summary>Errors that occur during the getMailTips action.</summary>
        public MailTipsError Error { get; set; }
        /// <summary>The number of external members if the recipient is a distribution list.</summary>
        public int? ExternalMemberCount { get; set; }
        /// <summary>Whether sending messages to the recipient requires approval. For example, if the recipient is a large distribution list and a moderator has been set up to approve messages sent to that distribution list, or if sending messages to a recipient requires approval of the recipient's manager.</summary>
        public bool? IsModerated { get; set; }
        /// <summary>The mailbox full status of the recipient.</summary>
        public bool? MailboxFull { get; set; }
        /// <summary>The maximum message size that has been configured for the recipient's organization or mailbox.</summary>
        public int? MaxMessageSize { get; set; }
        /// <summary>The scope of the recipient. Possible values are: none, internal, external, externalPartner, externalNonParther. For example, an administrator can set another organization to be its 'partner'. The scope is useful if an administrator wants certain mailtips to be accessible to certain scopes. It's also useful to senders to inform them that their message may leave the organization, helping them make the correct decisions about wording, tone and content.</summary>
        public RecipientScopeType? RecipientScope { get; set; }
        /// <summary>Recipients suggested based on previous contexts where they appear in the same message.</summary>
        public List<Recipient> RecipientSuggestions { get; set; }
        /// <summary>The number of members if the recipient is a distribution list.</summary>
        public int? TotalMemberCount { get; set; }
        /// <summary>
        /// Instantiates a new MailTips and sets the default values.
        /// </summary>
        public MailTips() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MailTips CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailTips();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"automaticReplies", (o,n) => { (o as MailTips).AutomaticReplies = n.GetObjectValue<AutomaticRepliesMailTips>(AutomaticRepliesMailTips.CreateFromDiscriminatorValue); } },
                {"customMailTip", (o,n) => { (o as MailTips).CustomMailTip = n.GetStringValue(); } },
                {"deliveryRestricted", (o,n) => { (o as MailTips).DeliveryRestricted = n.GetBoolValue(); } },
                {"emailAddress", (o,n) => { (o as MailTips).EmailAddress = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EmailAddress>(ApiSdk.Models.Microsoft.Graph.EmailAddress.CreateFromDiscriminatorValue); } },
                {"error", (o,n) => { (o as MailTips).Error = n.GetObjectValue<MailTipsError>(MailTipsError.CreateFromDiscriminatorValue); } },
                {"externalMemberCount", (o,n) => { (o as MailTips).ExternalMemberCount = n.GetIntValue(); } },
                {"isModerated", (o,n) => { (o as MailTips).IsModerated = n.GetBoolValue(); } },
                {"mailboxFull", (o,n) => { (o as MailTips).MailboxFull = n.GetBoolValue(); } },
                {"maxMessageSize", (o,n) => { (o as MailTips).MaxMessageSize = n.GetIntValue(); } },
                {"recipientScope", (o,n) => { (o as MailTips).RecipientScope = n.GetEnumValue<RecipientScopeType>(); } },
                {"recipientSuggestions", (o,n) => { (o as MailTips).RecipientSuggestions = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
                {"totalMemberCount", (o,n) => { (o as MailTips).TotalMemberCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AutomaticRepliesMailTips>("automaticReplies", AutomaticReplies);
            writer.WriteStringValue("customMailTip", CustomMailTip);
            writer.WriteBoolValue("deliveryRestricted", DeliveryRestricted);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EmailAddress>("emailAddress", EmailAddress);
            writer.WriteObjectValue<MailTipsError>("error", Error);
            writer.WriteIntValue("externalMemberCount", ExternalMemberCount);
            writer.WriteBoolValue("isModerated", IsModerated);
            writer.WriteBoolValue("mailboxFull", MailboxFull);
            writer.WriteIntValue("maxMessageSize", MaxMessageSize);
            writer.WriteEnumValue<RecipientScopeType>("recipientScope", RecipientScope);
            writer.WriteCollectionOfObjectValues<Recipient>("recipientSuggestions", RecipientSuggestions);
            writer.WriteIntValue("totalMemberCount", TotalMemberCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
