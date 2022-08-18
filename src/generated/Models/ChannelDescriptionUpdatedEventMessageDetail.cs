using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ChannelDescriptionUpdatedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>The updated description of the channel.</summary>
        public string ChannelDescription { get; set; }
        /// <summary>Unique identifier of the channel.</summary>
        public string ChannelId { get; set; }
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator { get; set; }
        /// <summary>
        /// Instantiates a new ChannelDescriptionUpdatedEventMessageDetail and sets the default values.
        /// </summary>
        public ChannelDescriptionUpdatedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.channelDescriptionUpdatedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ChannelDescriptionUpdatedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChannelDescriptionUpdatedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"channelDescription", n => { ChannelDescription = n.GetStringValue(); } },
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
            writer.WriteStringValue("channelDescription", ChannelDescription);
            writer.WriteStringValue("channelId", ChannelId);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}
