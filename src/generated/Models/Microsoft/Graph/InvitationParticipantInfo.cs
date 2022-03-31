using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class InvitationParticipantInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? Hidden { get; set; }
        public ApiSdk.Models.Microsoft.Graph.IdentitySet Identity { get; set; }
        public string ParticipantId { get; set; }
        public bool? RemoveFromDefaultAudioRoutingGroup { get; set; }
        /// <summary>Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.</summary>
        public string ReplacesCallId { get; set; }
        /// <summary>
        /// Instantiates a new invitationParticipantInfo and sets the default values.
        /// </summary>
        public InvitationParticipantInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.InvitationParticipantInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvitationParticipantInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hidden", (o,n) => { (o as InvitationParticipantInfo).Hidden = n.GetBoolValue(); } },
                {"identity", (o,n) => { (o as InvitationParticipantInfo).Identity = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"participantId", (o,n) => { (o as InvitationParticipantInfo).ParticipantId = n.GetStringValue(); } },
                {"removeFromDefaultAudioRoutingGroup", (o,n) => { (o as InvitationParticipantInfo).RemoveFromDefaultAudioRoutingGroup = n.GetBoolValue(); } },
                {"replacesCallId", (o,n) => { (o as InvitationParticipantInfo).ReplacesCallId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("identity", Identity);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteBoolValue("removeFromDefaultAudioRoutingGroup", RemoveFromDefaultAudioRoutingGroup);
            writer.WriteStringValue("replacesCallId", ReplacesCallId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
