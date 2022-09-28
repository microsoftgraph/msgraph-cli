using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ConversationMemberRoleUpdatedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Roles for the coversation member user.</summary>
        public List<string> ConversationMemberRoles { get; set; }
        /// <summary>Identity of the conversation member user.</summary>
        public TeamworkUserIdentity ConversationMemberUser { get; set; }
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator { get; set; }
        /// <summary>
        /// Instantiates a new ConversationMemberRoleUpdatedEventMessageDetail and sets the default values.
        /// </summary>
        public ConversationMemberRoleUpdatedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.conversationMemberRoleUpdatedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ConversationMemberRoleUpdatedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConversationMemberRoleUpdatedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conversationMemberRoles", n => { ConversationMemberRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"conversationMemberUser", n => { ConversationMemberUser = n.GetObjectValue<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("conversationMemberRoles", ConversationMemberRoles);
            writer.WriteObjectValue<TeamworkUserIdentity>("conversationMemberUser", ConversationMemberUser);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}
