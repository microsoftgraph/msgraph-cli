using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Call : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public List<AudioRoutingGroup> AudioRoutingGroups { get; set; }
        /// <summary>The callback URL on which callbacks will be delivered. Must be https.</summary>
        public string CallbackUri { get; set; }
        /// <summary>A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
        public string CallChainId { get; set; }
        public CallOptions CallOptions { get; set; }
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
        public List<CallRoute> CallRoutes { get; set; }
        /// <summary>The chat information. Required information for meeting scenarios.</summary>
        public ChatInfo ChatInfo { get; set; }
        /// <summary>The direction of the call. The possible value are incoming or outgoing. Read-only.</summary>
        public CallDirection? Direction { get; set; }
        /// <summary>The context associated with an incoming call. Read-only. Server generated.</summary>
        public IncomingContext IncomingContext { get; set; }
        /// <summary>The media configuration. Required information for creating peer to peer calls or joining meetings.</summary>
        public MediaConfig MediaConfig { get; set; }
        /// <summary>Read-only. The call media state.</summary>
        public CallMediaState MediaState { get; set; }
        /// <summary>The meeting information. Required information for meeting scenarios.</summary>
        public MeetingInfo MeetingInfo { get; set; }
        public string MyParticipantId { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<CommsOperation> Operations { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<Participant> Participants { get; set; }
        public List<Modality?> RequestedModalities { get; set; }
        public ResultInfo ResultInfo { get; set; }
        public ParticipantInfo Source { get; set; }
        public CallState? State { get; set; }
        public string Subject { get; set; }
        public List<InvitationParticipantInfo> Targets { get; set; }
        public string TenantId { get; set; }
        public ToneInfo ToneInfo { get; set; }
        /// <summary>The transcription information for the call. Read-only.</summary>
        public CallTranscriptionInfo Transcription { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"audioRoutingGroups", (o,n) => { (o as Call).AudioRoutingGroups = n.GetCollectionOfObjectValues<AudioRoutingGroup>().ToList(); } },
                {"callbackUri", (o,n) => { (o as Call).CallbackUri = n.GetStringValue(); } },
                {"callChainId", (o,n) => { (o as Call).CallChainId = n.GetStringValue(); } },
                {"callOptions", (o,n) => { (o as Call).CallOptions = n.GetObjectValue<CallOptions>(); } },
                {"callRoutes", (o,n) => { (o as Call).CallRoutes = n.GetCollectionOfObjectValues<CallRoute>().ToList(); } },
                {"chatInfo", (o,n) => { (o as Call).ChatInfo = n.GetObjectValue<ChatInfo>(); } },
                {"direction", (o,n) => { (o as Call).Direction = n.GetEnumValue<CallDirection>(); } },
                {"incomingContext", (o,n) => { (o as Call).IncomingContext = n.GetObjectValue<IncomingContext>(); } },
                {"mediaConfig", (o,n) => { (o as Call).MediaConfig = n.GetObjectValue<MediaConfig>(); } },
                {"mediaState", (o,n) => { (o as Call).MediaState = n.GetObjectValue<CallMediaState>(); } },
                {"meetingInfo", (o,n) => { (o as Call).MeetingInfo = n.GetObjectValue<MeetingInfo>(); } },
                {"myParticipantId", (o,n) => { (o as Call).MyParticipantId = n.GetStringValue(); } },
                {"operations", (o,n) => { (o as Call).Operations = n.GetCollectionOfObjectValues<CommsOperation>().ToList(); } },
                {"participants", (o,n) => { (o as Call).Participants = n.GetCollectionOfObjectValues<Participant>().ToList(); } },
                {"requestedModalities", (o,n) => { (o as Call).RequestedModalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"resultInfo", (o,n) => { (o as Call).ResultInfo = n.GetObjectValue<ResultInfo>(); } },
                {"source", (o,n) => { (o as Call).Source = n.GetObjectValue<ParticipantInfo>(); } },
                {"state", (o,n) => { (o as Call).State = n.GetEnumValue<CallState>(); } },
                {"subject", (o,n) => { (o as Call).Subject = n.GetStringValue(); } },
                {"targets", (o,n) => { (o as Call).Targets = n.GetCollectionOfObjectValues<InvitationParticipantInfo>().ToList(); } },
                {"tenantId", (o,n) => { (o as Call).TenantId = n.GetStringValue(); } },
                {"toneInfo", (o,n) => { (o as Call).ToneInfo = n.GetObjectValue<ToneInfo>(); } },
                {"transcription", (o,n) => { (o as Call).Transcription = n.GetObjectValue<CallTranscriptionInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AudioRoutingGroup>("audioRoutingGroups", AudioRoutingGroups);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteStringValue("callChainId", CallChainId);
            writer.WriteObjectValue<CallOptions>("callOptions", CallOptions);
            writer.WriteCollectionOfObjectValues<CallRoute>("callRoutes", CallRoutes);
            writer.WriteObjectValue<ChatInfo>("chatInfo", ChatInfo);
            writer.WriteEnumValue<CallDirection>("direction", Direction);
            writer.WriteObjectValue<IncomingContext>("incomingContext", IncomingContext);
            writer.WriteObjectValue<MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteObjectValue<CallMediaState>("mediaState", MediaState);
            writer.WriteObjectValue<MeetingInfo>("meetingInfo", MeetingInfo);
            writer.WriteStringValue("myParticipantId", MyParticipantId);
            writer.WriteCollectionOfObjectValues<CommsOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Participant>("participants", Participants);
            writer.WriteCollectionOfEnumValues<Modality>("requestedModalities", RequestedModalities);
            writer.WriteObjectValue<ResultInfo>("resultInfo", ResultInfo);
            writer.WriteObjectValue<ParticipantInfo>("source", Source);
            writer.WriteEnumValue<CallState>("state", State);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<InvitationParticipantInfo>("targets", Targets);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<ToneInfo>("toneInfo", ToneInfo);
            writer.WriteObjectValue<CallTranscriptionInfo>("transcription", Transcription);
        }
    }
}
