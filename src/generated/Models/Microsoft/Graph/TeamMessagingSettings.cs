using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamMessagingSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If set to true, @channel mentions are allowed.</summary>
        public bool? AllowChannelMentions { get; set; }
        /// <summary>If set to true, owners can delete any message.</summary>
        public bool? AllowOwnerDeleteMessages { get; set; }
        /// <summary>If set to true, @team mentions are allowed.</summary>
        public bool? AllowTeamMentions { get; set; }
        /// <summary>If set to true, users can delete their messages.</summary>
        public bool? AllowUserDeleteMessages { get; set; }
        /// <summary>If set to true, users can edit their messages.</summary>
        public bool? AllowUserEditMessages { get; set; }
        /// <summary>
        /// Instantiates a new teamMessagingSettings and sets the default values.
        /// </summary>
        public TeamMessagingSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowChannelMentions", (o,n) => { (o as TeamMessagingSettings).AllowChannelMentions = n.GetBoolValue(); } },
                {"allowOwnerDeleteMessages", (o,n) => { (o as TeamMessagingSettings).AllowOwnerDeleteMessages = n.GetBoolValue(); } },
                {"allowTeamMentions", (o,n) => { (o as TeamMessagingSettings).AllowTeamMentions = n.GetBoolValue(); } },
                {"allowUserDeleteMessages", (o,n) => { (o as TeamMessagingSettings).AllowUserDeleteMessages = n.GetBoolValue(); } },
                {"allowUserEditMessages", (o,n) => { (o as TeamMessagingSettings).AllowUserEditMessages = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowChannelMentions", AllowChannelMentions);
            writer.WriteBoolValue("allowOwnerDeleteMessages", AllowOwnerDeleteMessages);
            writer.WriteBoolValue("allowTeamMentions", AllowTeamMentions);
            writer.WriteBoolValue("allowUserDeleteMessages", AllowUserDeleteMessages);
            writer.WriteBoolValue("allowUserEditMessages", AllowUserEditMessages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
