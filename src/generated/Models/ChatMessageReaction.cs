using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ChatMessageReaction : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Supported values are like, angry, sad, laugh, heart, surprised.</summary>
        public string ReactionType { get; set; }
        /// <summary>The user property</summary>
        public ChatMessageReactionIdentitySet User { get; set; }
        /// <summary>
        /// Instantiates a new chatMessageReaction and sets the default values.
        /// </summary>
        public ChatMessageReaction() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.chatMessageReaction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ChatMessageReaction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessageReaction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reactionType", n => { ReactionType = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<ChatMessageReactionIdentitySet>(ChatMessageReactionIdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("reactionType", ReactionType);
            writer.WriteObjectValue<ChatMessageReactionIdentitySet>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
