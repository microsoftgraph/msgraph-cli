using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ChatRenamedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>The updated name of the chat.</summary>
        public string ChatDisplayName { get; set; }
        /// <summary>Unique identifier of the chat.</summary>
        public string ChatId { get; set; }
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator { get; set; }
        /// <summary>
        /// Instantiates a new ChatRenamedEventMessageDetail and sets the default values.
        /// </summary>
        public ChatRenamedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.chatRenamedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ChatRenamedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatRenamedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"chatDisplayName", n => { ChatDisplayName = n.GetStringValue(); } },
                {"chatId", n => { ChatId = n.GetStringValue(); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("chatDisplayName", ChatDisplayName);
            writer.WriteStringValue("chatId", ChatId);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}
