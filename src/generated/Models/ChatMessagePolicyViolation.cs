using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ChatMessagePolicyViolation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The action taken by the DLP provider on the message with sensitive content. Supported values are: NoneNotifySender -- Inform the sender of the violation but allow readers to read the message.BlockAccess -- Block readers from reading the message.BlockAccessExternal -- Block users outside the organization from reading the message, while allowing users within the organization to read the message.</summary>
        public ChatMessagePolicyViolationDlpActionTypes? DlpAction { get; set; }
        /// <summary>Justification text provided by the sender of the message when overriding a policy violation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JustificationText { get; set; }
#nullable restore
#else
        public string JustificationText { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Information to display to the message sender about why the message was flagged as a violation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChatMessagePolicyViolationPolicyTip? PolicyTip { get; set; }
#nullable restore
#else
        public ChatMessagePolicyViolationPolicyTip PolicyTip { get; set; }
#endif
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static ChatMessagePolicyViolation CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static ChatMessagePolicyViolation CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessagePolicyViolation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dlpAction", n => { DlpAction = n.GetEnumValue<ChatMessagePolicyViolationDlpActionTypes>(); } },
                {"justificationText", n => { JustificationText = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"policyTip", n => { PolicyTip = n.GetObjectValue<ChatMessagePolicyViolationPolicyTip>(ChatMessagePolicyViolationPolicyTip.CreateFromDiscriminatorValue); } },
                {"userAction", n => { UserAction = n.GetEnumValue<ChatMessagePolicyViolationUserActionTypes>(); } },
                {"verdictDetails", n => { VerdictDetails = n.GetEnumValue<ChatMessagePolicyViolationVerdictDetailsTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ChatMessagePolicyViolationDlpActionTypes>("dlpAction", DlpAction);
            writer.WriteStringValue("justificationText", JustificationText);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ChatMessagePolicyViolationPolicyTip>("policyTip", PolicyTip);
            writer.WriteEnumValue<ChatMessagePolicyViolationUserActionTypes>("userAction", UserAction);
            writer.WriteEnumValue<ChatMessagePolicyViolationVerdictDetailsTypes>("verdictDetails", VerdictDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
