using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Call : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AudioRoutingGroup> AudioRoutingGroups { get; set; }
        /// <summary>The callback URL on which callbacks will be delivered. Must be https.</summary>
        public string CallbackUri { get; set; }
        /// <summary>A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
        public string CallChainId { get; set; }
        public ApiSdk.Models.Microsoft.Graph.CallOptions CallOptions { get; set; }
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.CallRoute> CallRoutes { get; set; }
        /// <summary>The chat information. Required information for joining a meeting.</summary>
        public ApiSdk.Models.Microsoft.Graph.ChatInfo ChatInfo { get; set; }
        /// <summary>The direction of the call. The possible value are incoming or outgoing. Read-only.</summary>
        public CallDirection? Direction { get; set; }
        /// <summary>The context associated with an incoming call. Read-only. Server generated.</summary>
        public ApiSdk.Models.Microsoft.Graph.IncomingContext IncomingContext { get; set; }
        /// <summary>The media configuration. Required.</summary>
        public ApiSdk.Models.Microsoft.Graph.MediaConfig MediaConfig { get; set; }
        /// <summary>Read-only. The call media state.</summary>
        public ApiSdk.Models.Microsoft.Graph.CallMediaState MediaState { get; set; }
        /// <summary>The meeting information that's required for joining a meeting.</summary>
        public ApiSdk.Models.Microsoft.Graph.MeetingInfo MeetingInfo { get; set; }
        public string MyParticipantId { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.CommsOperation> Operations { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Participant> Participants { get; set; }
        public List<Modality?> RequestedModalities { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ResultInfo ResultInfo { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ParticipantInfo Source { get; set; }
        public CallState? State { get; set; }
        public string Subject { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.InvitationParticipantInfo> Targets { get; set; }
        public string TenantId { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ToneInfo ToneInfo { get; set; }
        /// <summary>The transcription information for the call. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.CallTranscriptionInfo Transcription { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Call CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Call();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"audioRoutingGroups", (o,n) => { (o as Call).AudioRoutingGroups = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AudioRoutingGroup>(ApiSdk.Models.Microsoft.Graph.AudioRoutingGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"callbackUri", (o,n) => { (o as Call).CallbackUri = n.GetStringValue(); } },
                {"callChainId", (o,n) => { (o as Call).CallChainId = n.GetStringValue(); } },
                {"callOptions", (o,n) => { (o as Call).CallOptions = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CallOptions>(ApiSdk.Models.Microsoft.Graph.CallOptions.CreateFromDiscriminatorValue); } },
                {"callRoutes", (o,n) => { (o as Call).CallRoutes = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.CallRoute>(ApiSdk.Models.Microsoft.Graph.CallRoute.CreateFromDiscriminatorValue).ToList(); } },
                {"chatInfo", (o,n) => { (o as Call).ChatInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ChatInfo>(ApiSdk.Models.Microsoft.Graph.ChatInfo.CreateFromDiscriminatorValue); } },
                {"direction", (o,n) => { (o as Call).Direction = n.GetEnumValue<CallDirection>(); } },
                {"incomingContext", (o,n) => { (o as Call).IncomingContext = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IncomingContext>(ApiSdk.Models.Microsoft.Graph.IncomingContext.CreateFromDiscriminatorValue); } },
                {"mediaConfig", (o,n) => { (o as Call).MediaConfig = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.MediaConfig>(ApiSdk.Models.Microsoft.Graph.MediaConfig.CreateFromDiscriminatorValue); } },
                {"mediaState", (o,n) => { (o as Call).MediaState = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CallMediaState>(ApiSdk.Models.Microsoft.Graph.CallMediaState.CreateFromDiscriminatorValue); } },
                {"meetingInfo", (o,n) => { (o as Call).MeetingInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.MeetingInfo>(ApiSdk.Models.Microsoft.Graph.MeetingInfo.CreateFromDiscriminatorValue); } },
                {"myParticipantId", (o,n) => { (o as Call).MyParticipantId = n.GetStringValue(); } },
                {"operations", (o,n) => { (o as Call).Operations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.CommsOperation>(ApiSdk.Models.Microsoft.Graph.CommsOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"participants", (o,n) => { (o as Call).Participants = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Participant>(ApiSdk.Models.Microsoft.Graph.Participant.CreateFromDiscriminatorValue).ToList(); } },
                {"requestedModalities", (o,n) => { (o as Call).RequestedModalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"resultInfo", (o,n) => { (o as Call).ResultInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ResultInfo>(ApiSdk.Models.Microsoft.Graph.ResultInfo.CreateFromDiscriminatorValue); } },
                {"source", (o,n) => { (o as Call).Source = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ParticipantInfo>(ApiSdk.Models.Microsoft.Graph.ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"state", (o,n) => { (o as Call).State = n.GetEnumValue<CallState>(); } },
                {"subject", (o,n) => { (o as Call).Subject = n.GetStringValue(); } },
                {"targets", (o,n) => { (o as Call).Targets = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.InvitationParticipantInfo>(ApiSdk.Models.Microsoft.Graph.InvitationParticipantInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantId", (o,n) => { (o as Call).TenantId = n.GetStringValue(); } },
                {"toneInfo", (o,n) => { (o as Call).ToneInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ToneInfo>(ApiSdk.Models.Microsoft.Graph.ToneInfo.CreateFromDiscriminatorValue); } },
                {"transcription", (o,n) => { (o as Call).Transcription = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CallTranscriptionInfo>(ApiSdk.Models.Microsoft.Graph.CallTranscriptionInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AudioRoutingGroup>("audioRoutingGroups", AudioRoutingGroups);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteStringValue("callChainId", CallChainId);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CallOptions>("callOptions", CallOptions);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.CallRoute>("callRoutes", CallRoutes);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteEnumValue<CallDirection>("direction", Direction);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IncomingContext>("incomingContext", IncomingContext);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CallMediaState>("mediaState", MediaState);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.MeetingInfo>("meetingInfo", MeetingInfo);
            writer.WriteStringValue("myParticipantId", MyParticipantId);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.CommsOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Participant>("participants", Participants);
            writer.WriteCollectionOfEnumValues<Modality>("requestedModalities", RequestedModalities);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ParticipantInfo>("source", Source);
            writer.WriteEnumValue<CallState>("state", State);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.InvitationParticipantInfo>("targets", Targets);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ToneInfo>("toneInfo", ToneInfo);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CallTranscriptionInfo>("transcription", Transcription);
        }
    }
}
