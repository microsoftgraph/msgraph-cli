using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class InferenceClassificationOverride : Entity, IParsable {
        /// <summary>Specifies how incoming messages from a specific sender should always be classified as. Possible values are: focused, other.</summary>
        public InferenceClassificationType? ClassifyAs { get; set; }
        /// <summary>The email address information of the sender for whom the override is created.</summary>
        public EmailAddress SenderEmailAddress { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"classifyAs", (o,n) => { (o as InferenceClassificationOverride).ClassifyAs = n.GetEnumValue<InferenceClassificationType>(); } },
                {"senderEmailAddress", (o,n) => { (o as InferenceClassificationOverride).SenderEmailAddress = n.GetObjectValue<EmailAddress>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<InferenceClassificationType>("classifyAs", ClassifyAs);
            writer.WriteObjectValue<EmailAddress>("senderEmailAddress", SenderEmailAddress);
        }
    }
}
