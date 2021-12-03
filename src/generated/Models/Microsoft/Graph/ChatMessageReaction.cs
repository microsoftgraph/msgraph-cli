using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ChatMessageReaction : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Supported values are like, angry, sad, laugh, heart, surprised.</summary>
        public string ReactionType { get; set; }
        public ChatMessageReactionIdentitySet User { get; set; }
        /// <summary>
        /// Instantiates a new chatMessageReaction and sets the default values.
        /// </summary>
        public ChatMessageReaction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"createdDateTime", (o,n) => { (o as ChatMessageReaction).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reactionType", (o,n) => { (o as ChatMessageReaction).ReactionType = n.GetStringValue(); } },
                {"user", (o,n) => { (o as ChatMessageReaction).User = n.GetObjectValue<ChatMessageReactionIdentitySet>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("reactionType", ReactionType);
            writer.WriteObjectValue<ChatMessageReactionIdentitySet>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
