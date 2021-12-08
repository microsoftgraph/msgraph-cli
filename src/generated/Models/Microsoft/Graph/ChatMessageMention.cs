using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ChatMessageMention : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Index of an entity being mentioned in the specified chatMessage. Matches the {index} value in the corresponding <at id='{index}'> tag in the message body.</summary>
        public int? Id { get; set; }
        /// <summary>The entity (user, application, team, or channel) that was @mentioned.</summary>
        public ChatMessageMentionedIdentitySet Mentioned { get; set; }
        /// <summary>String used to represent the mention. For example, a user's display name, a team name.</summary>
        public string MentionText { get; set; }
        /// <summary>
        /// Instantiates a new chatMessageMention and sets the default values.
        /// </summary>
        public ChatMessageMention() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"id", (o,n) => { (o as ChatMessageMention).Id = n.GetIntValue(); } },
                {"mentioned", (o,n) => { (o as ChatMessageMention).Mentioned = n.GetObjectValue<ChatMessageMentionedIdentitySet>(); } },
                {"mentionText", (o,n) => { (o as ChatMessageMention).MentionText = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<ChatMessageMentionedIdentitySet>("mentioned", Mentioned);
            writer.WriteStringValue("mentionText", MentionText);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
