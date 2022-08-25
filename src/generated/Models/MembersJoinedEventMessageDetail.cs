using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MembersJoinedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator { get; set; }
        /// <summary>List of members who joined the chat.</summary>
        public List<TeamworkUserIdentity> Members { get; set; }
        /// <summary>
        /// Instantiates a new MembersJoinedEventMessageDetail and sets the default values.
        /// </summary>
        public MembersJoinedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.membersJoinedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MembersJoinedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MembersJoinedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteCollectionOfObjectValues<TeamworkUserIdentity>("members", Members);
        }
    }
}