using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ChatInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier of a message in a Microsoft Teams channel.</summary>
        public string MessageId { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The ID of the reply message.</summary>
        public string ReplyChainMessageId { get; set; }
        /// <summary>The unique identifier for a thread in Microsoft Teams.</summary>
        public string ThreadId { get; set; }
        /// <summary>
        /// Instantiates a new chatInfo and sets the default values.
        /// </summary>
        public ChatInfo() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.chatInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ChatInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"messageId", n => { MessageId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"replyChainMessageId", n => { ReplyChainMessageId = n.GetStringValue(); } },
                {"threadId", n => { ThreadId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("messageId", MessageId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("replyChainMessageId", ReplyChainMessageId);
            writer.WriteStringValue("threadId", ThreadId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
