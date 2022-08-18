using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Invitation : Entity, IParsable {
        /// <summary>The user created as part of the invitation creation. Read-Only</summary>
        public User InvitedUser { get; set; }
        /// <summary>The display name of the user being invited.</summary>
        public string InvitedUserDisplayName { get; set; }
        /// <summary>The email address of the user being invited. Required. The following special characters are not permitted in the email address:Tilde (~)Exclamation point (!)Number sign (#)Dollar sign ($)Percent (%)Circumflex (^)Ampersand (&amp;)Asterisk (*)Parentheses (( ))Plus sign (+)Equal sign (=)Brackets ([ ])Braces ({ })Backslash (/)Slash mark (/)Pipe (/|)Semicolon (;)Colon (:)Quotation marks (&apos;)Angle brackets (&lt; &gt;)Question mark (?)Comma (,)However, the following exceptions apply:A period (.) or a hyphen (-) is permitted anywhere in the user name, except at the beginning or end of the name.An underscore (_) is permitted anywhere in the user name. This includes at the beginning or end of the name.</summary>
        public string InvitedUserEmailAddress { get; set; }
        /// <summary>Additional configuration for the message being sent to the invited user, including customizing message text, language and cc recipient list.</summary>
        public ApiSdk.Models.InvitedUserMessageInfo InvitedUserMessageInfo { get; set; }
        /// <summary>The userType of the user being invited. By default, this is Guest. You can invite as Member if you are a company administrator.</summary>
        public string InvitedUserType { get; set; }
        /// <summary>The URL the user can use to redeem their invitation. Read-only.</summary>
        public string InviteRedeemUrl { get; set; }
        /// <summary>The URL the user should be redirected to once the invitation is redeemed. Required.</summary>
        public string InviteRedirectUrl { get; set; }
        /// <summary>Indicates whether an email should be sent to the user being invited. The default is false.</summary>
        public bool? SendInvitationMessage { get; set; }
        /// <summary>The status of the invitation. Possible values are: PendingAcceptance, Completed, InProgress, and Error.</summary>
        public string Status { get; set; }
        /// <summary>
        /// Instantiates a new Invitation and sets the default values.
        /// </summary>
        public Invitation() : base() {
            OdataType = "#microsoft.graph.invitation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Invitation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Invitation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"invitedUser", n => { InvitedUser = n.GetObjectValue<User>(User.CreateFromDiscriminatorValue); } },
                {"invitedUserDisplayName", n => { InvitedUserDisplayName = n.GetStringValue(); } },
                {"invitedUserEmailAddress", n => { InvitedUserEmailAddress = n.GetStringValue(); } },
                {"invitedUserMessageInfo", n => { InvitedUserMessageInfo = n.GetObjectValue<ApiSdk.Models.InvitedUserMessageInfo>(ApiSdk.Models.InvitedUserMessageInfo.CreateFromDiscriminatorValue); } },
                {"invitedUserType", n => { InvitedUserType = n.GetStringValue(); } },
                {"inviteRedeemUrl", n => { InviteRedeemUrl = n.GetStringValue(); } },
                {"inviteRedirectUrl", n => { InviteRedirectUrl = n.GetStringValue(); } },
                {"sendInvitationMessage", n => { SendInvitationMessage = n.GetBoolValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<User>("invitedUser", InvitedUser);
            writer.WriteStringValue("invitedUserDisplayName", InvitedUserDisplayName);
            writer.WriteStringValue("invitedUserEmailAddress", InvitedUserEmailAddress);
            writer.WriteObjectValue<ApiSdk.Models.InvitedUserMessageInfo>("invitedUserMessageInfo", InvitedUserMessageInfo);
            writer.WriteStringValue("invitedUserType", InvitedUserType);
            writer.WriteStringValue("inviteRedeemUrl", InviteRedeemUrl);
            writer.WriteStringValue("inviteRedirectUrl", InviteRedirectUrl);
            writer.WriteBoolValue("sendInvitationMessage", SendInvitationMessage);
            writer.WriteStringValue("status", Status);
        }
    }
}
