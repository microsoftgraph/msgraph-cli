using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class InvitationParticipantInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? Hidden { get; set; }
        public IdentitySet Identity { get; set; }
        public string ParticipantId { get; set; }
        public bool? RemoveFromDefaultAudioRoutingGroup { get; set; }
        /// <summary>Optional. The call which the target idenity is currently a part of. This call will be dropped once the participant is added.</summary>
        public string ReplacesCallId { get; set; }
        /// <summary>
        /// Instantiates a new invitationParticipantInfo and sets the default values.
        /// </summary>
        public InvitationParticipantInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hidden", (o,n) => { (o as InvitationParticipantInfo).Hidden = n.GetBoolValue(); } },
                {"identity", (o,n) => { (o as InvitationParticipantInfo).Identity = n.GetObjectValue<IdentitySet>(); } },
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
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteBoolValue("removeFromDefaultAudioRoutingGroup", RemoveFromDefaultAudioRoutingGroup);
            writer.WriteStringValue("replacesCallId", ReplacesCallId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
