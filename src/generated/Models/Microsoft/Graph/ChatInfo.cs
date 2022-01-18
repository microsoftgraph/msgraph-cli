using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ChatInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier for a message in a Microsoft Teams channel.</summary>
        public string MessageId { get; set; }
        /// <summary>The ID of the reply message.</summary>
        public string ReplyChainMessageId { get; set; }
        /// <summary>The unique identifier for a thread in Microsoft Teams.</summary>
        public string ThreadId { get; set; }
        /// <summary>
        /// Instantiates a new chatInfo and sets the default values.
        /// </summary>
        public ChatInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"messageId", (o,n) => { (o as ChatInfo).MessageId = n.GetStringValue(); } },
                {"replyChainMessageId", (o,n) => { (o as ChatInfo).ReplyChainMessageId = n.GetStringValue(); } },
                {"threadId", (o,n) => { (o as ChatInfo).ThreadId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("messageId", MessageId);
            writer.WriteStringValue("replyChainMessageId", ReplyChainMessageId);
            writer.WriteStringValue("threadId", ThreadId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
