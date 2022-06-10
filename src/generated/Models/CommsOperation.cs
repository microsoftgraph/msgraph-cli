using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the cloudCommunications singleton.</summary>
    public class CommsOperation : Entity, IParsable {
        /// <summary>Unique Client Context string. Max limit is 256 chars.</summary>
        public string ClientContext { get; set; }
        /// <summary>The result information. Read-only.</summary>
        public ApiSdk.Models.ResultInfo ResultInfo { get; set; }
        /// <summary>Possible values are: notStarted, running, completed, failed. Read-only.</summary>
        public OperationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CommsOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.cancelMediaProcessingOperation" => new CancelMediaProcessingOperation(),
                "#microsoft.graph.inviteParticipantsOperation" => new InviteParticipantsOperation(),
                "#microsoft.graph.muteParticipantOperation" => new MuteParticipantOperation(),
                "#microsoft.graph.playPromptOperation" => new PlayPromptOperation(),
                "#microsoft.graph.recordOperation" => new RecordOperation(),
                "#microsoft.graph.startHoldMusicOperation" => new StartHoldMusicOperation(),
                "#microsoft.graph.stopHoldMusicOperation" => new StopHoldMusicOperation(),
                "#microsoft.graph.subscribeToToneOperation" => new SubscribeToToneOperation(),
                "#microsoft.graph.unmuteParticipantOperation" => new UnmuteParticipantOperation(),
                "#microsoft.graph.updateRecordingStatusOperation" => new UpdateRecordingStatusOperation(),
                _ => new CommsOperation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clientContext", n => { ClientContext = n.GetStringValue(); } },
                {"resultInfo", n => { ResultInfo = n.GetObjectValue<ApiSdk.Models.ResultInfo>(ApiSdk.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<OperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteObjectValue<ApiSdk.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteEnumValue<OperationStatus>("status", Status);
        }
    }
}
