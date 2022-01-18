using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamworkConversationIdentity : Identity, IParsable {
        /// <summary>Type of conversation. Possible values are: team, channel, and chat.</summary>
        public TeamworkConversationIdentityType? ConversationIdentityType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"conversationIdentityType", (o,n) => { (o as TeamworkConversationIdentity).ConversationIdentityType = n.GetEnumValue<TeamworkConversationIdentityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TeamworkConversationIdentityType>("conversationIdentityType", ConversationIdentityType);
        }
    }
}
