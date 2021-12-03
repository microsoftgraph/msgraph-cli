using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ChatMessagePolicyViolation : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The action taken by the DLP provider on the message with sensitive content. Supported values are: NoneNotifySender -- Inform the sender of the violation but allow readers to read the message.BlockAccess -- Block readers from reading the message.BlockAccessExternal -- Block users outside the organization from reading the message, while allowing users within the organization to read the message.</summary>
        public ChatMessagePolicyViolationDlpActionTypes? DlpAction { get; set; }
        /// <summary>Justification text provided by the sender of the message when overriding a policy violation.</summary>
        public string JustificationText { get; set; }
        /// <summary>Information to display to the message sender about why the message was flagged as a violation.</summary>
        public ChatMessagePolicyViolationPolicyTip PolicyTip { get; set; }
        /// <summary>Indicates the action taken by the user on a message blocked by the DLP provider. Supported values are: NoneOverrideReportFalsePositiveWhen the DLP provider is updating the message for blocking sensitive content, userAction is not required.</summary>
        public ChatMessagePolicyViolationUserActionTypes? UserAction { get; set; }
        /// <summary>Indicates what actions the sender may take in response to the policy violation. Supported values are: NoneAllowFalsePositiveOverride -- Allows the sender to declare the policyViolation to be an error in the DLP app and its rules, and allow readers to see the message again if the dlpAction had hidden it.AllowOverrideWithoutJustification -- Allows the sender to overriide the DLP violation and allow readers to see the message again if the dlpAction had hidden it, without needing to provide an explanation for doing so. AllowOverrideWithJustification -- Allows the sender to overriide the DLP violation and allow readers to see the message again if the dlpAction had hidden it, after providing an explanation for doing so.AllowOverrideWithoutJustification and AllowOverrideWithJustification are mutually exclusive.</summary>
        public ChatMessagePolicyViolationVerdictDetailsTypes? VerdictDetails { get; set; }
        /// <summary>
        /// Instantiates a new chatMessagePolicyViolation and sets the default values.
        /// </summary>
        public ChatMessagePolicyViolation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dlpAction", (o,n) => { (o as ChatMessagePolicyViolation).DlpAction = n.GetEnumValue<ChatMessagePolicyViolationDlpActionTypes>(); } },
                {"justificationText", (o,n) => { (o as ChatMessagePolicyViolation).JustificationText = n.GetStringValue(); } },
                {"policyTip", (o,n) => { (o as ChatMessagePolicyViolation).PolicyTip = n.GetObjectValue<ChatMessagePolicyViolationPolicyTip>(); } },
                {"userAction", (o,n) => { (o as ChatMessagePolicyViolation).UserAction = n.GetEnumValue<ChatMessagePolicyViolationUserActionTypes>(); } },
                {"verdictDetails", (o,n) => { (o as ChatMessagePolicyViolation).VerdictDetails = n.GetEnumValue<ChatMessagePolicyViolationVerdictDetailsTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ChatMessagePolicyViolationDlpActionTypes>("dlpAction", DlpAction);
            writer.WriteStringValue("justificationText", JustificationText);
            writer.WriteObjectValue<ChatMessagePolicyViolationPolicyTip>("policyTip", PolicyTip);
            writer.WriteEnumValue<ChatMessagePolicyViolationUserActionTypes>("userAction", UserAction);
            writer.WriteEnumValue<ChatMessagePolicyViolationVerdictDetailsTypes>("verdictDetails", VerdictDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
