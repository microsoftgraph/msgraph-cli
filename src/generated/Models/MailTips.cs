// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MailTips : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Mail tips for automatic reply if it has been set up by the recipient.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AutomaticRepliesMailTips? AutomaticReplies { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AutomaticRepliesMailTips AutomaticReplies { get; set; }
#endif
        /// <summary>A custom mail tip that can be set on the recipient&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomMailTip { get; set; }
#nullable restore
#else
        public string CustomMailTip { get; set; }
#endif
        /// <summary>Whether the recipient&apos;s mailbox is restricted, for example, accepting messages from only a predefined list of senders, rejecting messages from a predefined list of senders, or accepting messages from only authenticated senders.</summary>
        public bool? DeliveryRestricted { get; set; }
        /// <summary>The email address of the recipient to get mailtips for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EmailAddress? EmailAddress { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EmailAddress EmailAddress { get; set; }
#endif
        /// <summary>Errors that occur during the getMailTips action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.MailTipsError? Error { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.MailTipsError Error { get; set; }
#endif
        /// <summary>The number of external members if the recipient is a distribution list.</summary>
        public int? ExternalMemberCount { get; set; }
        /// <summary>Whether sending messages to the recipient requires approval. For example, if the recipient is a large distribution list and a moderator has been set up to approve messages sent to that distribution list, or if sending messages to a recipient requires approval of the recipient&apos;s manager.</summary>
        public bool? IsModerated { get; set; }
        /// <summary>The mailbox full status of the recipient.</summary>
        public bool? MailboxFull { get; set; }
        /// <summary>The maximum message size that has been configured for the recipient&apos;s organization or mailbox.</summary>
        public int? MaxMessageSize { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The scope of the recipient. Possible values are: none, internal, external, externalPartner, externalNonParther. For example, an administrator can set another organization to be its &apos;partner&apos;. The scope is useful if an administrator wants certain mailtips to be accessible to certain scopes. It&apos;s also useful to senders to inform them that their message may leave the organization, helping them make the correct decisions about wording, tone and content.</summary>
        public global::ApiSdk.Models.RecipientScopeType? RecipientScope { get; set; }
        /// <summary>Recipients suggested based on previous contexts where they appear in the same message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Recipient>? RecipientSuggestions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Recipient> RecipientSuggestions { get; set; }
#endif
        /// <summary>The number of members if the recipient is a distribution list.</summary>
        public int? TotalMemberCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.MailTips"/> and sets the default values.
        /// </summary>
        public MailTips()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.MailTips"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.MailTips CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.MailTips();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "automaticReplies", n => { AutomaticReplies = n.GetObjectValue<global::ApiSdk.Models.AutomaticRepliesMailTips>(global::ApiSdk.Models.AutomaticRepliesMailTips.CreateFromDiscriminatorValue); } },
                { "customMailTip", n => { CustomMailTip = n.GetStringValue(); } },
                { "deliveryRestricted", n => { DeliveryRestricted = n.GetBoolValue(); } },
                { "emailAddress", n => { EmailAddress = n.GetObjectValue<global::ApiSdk.Models.EmailAddress>(global::ApiSdk.Models.EmailAddress.CreateFromDiscriminatorValue); } },
                { "error", n => { Error = n.GetObjectValue<global::ApiSdk.Models.MailTipsError>(global::ApiSdk.Models.MailTipsError.CreateFromDiscriminatorValue); } },
                { "externalMemberCount", n => { ExternalMemberCount = n.GetIntValue(); } },
                { "isModerated", n => { IsModerated = n.GetBoolValue(); } },
                { "mailboxFull", n => { MailboxFull = n.GetBoolValue(); } },
                { "maxMessageSize", n => { MaxMessageSize = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "recipientScope", n => { RecipientScope = n.GetEnumValue<global::ApiSdk.Models.RecipientScopeType>(); } },
                { "recipientSuggestions", n => { RecipientSuggestions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Recipient>(global::ApiSdk.Models.Recipient.CreateFromDiscriminatorValue)?.AsList(); } },
                { "totalMemberCount", n => { TotalMemberCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.AutomaticRepliesMailTips>("automaticReplies", AutomaticReplies);
            writer.WriteStringValue("customMailTip", CustomMailTip);
            writer.WriteBoolValue("deliveryRestricted", DeliveryRestricted);
            writer.WriteObjectValue<global::ApiSdk.Models.EmailAddress>("emailAddress", EmailAddress);
            writer.WriteObjectValue<global::ApiSdk.Models.MailTipsError>("error", Error);
            writer.WriteIntValue("externalMemberCount", ExternalMemberCount);
            writer.WriteBoolValue("isModerated", IsModerated);
            writer.WriteBoolValue("mailboxFull", MailboxFull);
            writer.WriteIntValue("maxMessageSize", MaxMessageSize);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::ApiSdk.Models.RecipientScopeType>("recipientScope", RecipientScope);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Recipient>("recipientSuggestions", RecipientSuggestions);
            writer.WriteIntValue("totalMemberCount", TotalMemberCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
