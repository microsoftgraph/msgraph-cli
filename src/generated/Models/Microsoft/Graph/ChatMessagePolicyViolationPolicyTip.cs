using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ChatMessagePolicyViolationPolicyTip : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The URL a user can visit to read about the data loss prevention policies for the organization. (ie, policies about what users shouldn't say in chats)</summary>
        public string ComplianceUrl { get; set; }
        /// <summary>Explanatory text shown to the sender of the message.</summary>
        public string GeneralText { get; set; }
        /// <summary>The list of improper data in the message that was detected by the data loss prevention app. Each DLP app defines its own conditions, examples include 'Credit Card Number' and 'Social Security Number'.</summary>
        public List<string> MatchedConditionDescriptions { get; set; }
        /// <summary>
        /// Instantiates a new chatMessagePolicyViolationPolicyTip and sets the default values.
        /// </summary>
        public ChatMessagePolicyViolationPolicyTip() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"complianceUrl", (o,n) => { (o as ChatMessagePolicyViolationPolicyTip).ComplianceUrl = n.GetStringValue(); } },
                {"generalText", (o,n) => { (o as ChatMessagePolicyViolationPolicyTip).GeneralText = n.GetStringValue(); } },
                {"matchedConditionDescriptions", (o,n) => { (o as ChatMessagePolicyViolationPolicyTip).MatchedConditionDescriptions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("complianceUrl", ComplianceUrl);
            writer.WriteStringValue("generalText", GeneralText);
            writer.WriteCollectionOfPrimitiveValues<string>("matchedConditionDescriptions", MatchedConditionDescriptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
