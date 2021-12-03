using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ChannelIdentity : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identity of the channel in which the message was posted.</summary>
        public string ChannelId { get; set; }
        /// <summary>The identity of the team in which the message was posted.</summary>
        public string TeamId { get; set; }
        /// <summary>
        /// Instantiates a new channelIdentity and sets the default values.
        /// </summary>
        public ChannelIdentity() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"channelId", (o,n) => { (o as ChannelIdentity).ChannelId = n.GetStringValue(); } },
                {"teamId", (o,n) => { (o as ChannelIdentity).TeamId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("channelId", ChannelId);
            writer.WriteStringValue("teamId", TeamId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
