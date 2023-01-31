using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class InferenceClassificationOverride : Entity, IParsable {
        /// <summary>Specifies how incoming messages from a specific sender should always be classified as. The possible values are: focused, other.</summary>
        public InferenceClassificationType? ClassifyAs { get; set; }
        /// <summary>The email address information of the sender for whom the override is created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailAddress? SenderEmailAddress { get; set; }
#nullable restore
#else
        public EmailAddress SenderEmailAddress { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new InferenceClassificationOverride CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new InferenceClassificationOverride CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InferenceClassificationOverride();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classifyAs", n => { ClassifyAs = n.GetEnumValue<InferenceClassificationType>(); } },
                {"senderEmailAddress", n => { SenderEmailAddress = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<InferenceClassificationType>("classifyAs", ClassifyAs);
            writer.WriteObjectValue<EmailAddress>("senderEmailAddress", SenderEmailAddress);
        }
    }
}
