using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConversationMember : Entity, IParsable {
        /// <summary>The display name of the user.</summary>
        public string DisplayName { get; set; }
        /// <summary>The roles for that user.</summary>
        public List<string> Roles { get; set; }
        /// <summary>The timestamp denoting how far back a conversation's history is shared with the conversation member. This property is settable only for members of a chat.</summary>
        public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as ConversationMember).DisplayName = n.GetStringValue(); } },
                {"roles", (o,n) => { (o as ConversationMember).Roles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"visibleHistoryStartDateTime", (o,n) => { (o as ConversationMember).VisibleHistoryStartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("roles", Roles);
            writer.WriteDateTimeOffsetValue("visibleHistoryStartDateTime", VisibleHistoryStartDateTime);
        }
    }
}
