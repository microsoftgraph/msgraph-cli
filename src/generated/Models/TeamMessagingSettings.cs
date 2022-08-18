using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class TeamMessagingSettings : IAdditionalDataHolder, IParsable {
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
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new teamMessagingSettings and sets the default values.
        /// </summary>
        public TeamMessagingSettings() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teamMessagingSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamMessagingSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamMessagingSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowChannelMentions", n => { AllowChannelMentions = n.GetBoolValue(); } },
                {"allowOwnerDeleteMessages", n => { AllowOwnerDeleteMessages = n.GetBoolValue(); } },
                {"allowTeamMentions", n => { AllowTeamMentions = n.GetBoolValue(); } },
                {"allowUserDeleteMessages", n => { AllowUserDeleteMessages = n.GetBoolValue(); } },
                {"allowUserEditMessages", n => { AllowUserEditMessages = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
