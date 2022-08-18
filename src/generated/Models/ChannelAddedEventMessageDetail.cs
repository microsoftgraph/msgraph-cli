using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ChannelAddedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Display name of the channel.</summary>
        public string ChannelDisplayName { get; set; }
        /// <summary>Unique identifier of the channel.</summary>
        public string ChannelId { get; set; }
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator { get; set; }
        /// <summary>
        /// Instantiates a new ChannelAddedEventMessageDetail and sets the default values.
        /// </summary>
        public ChannelAddedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.channelAddedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ChannelAddedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChannelAddedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"channelDisplayName", n => { ChannelDisplayName = n.GetStringValue(); } },
                {"channelId", n => { ChannelId = n.GetStringValue(); } },
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
            writer.WriteStringValue("channelDisplayName", ChannelDisplayName);
            writer.WriteStringValue("channelId", ChannelId);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}
