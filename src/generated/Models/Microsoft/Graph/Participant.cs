using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Participant : Entity, IParsable {
        public ApiSdk.Models.Microsoft.Graph.ParticipantInfo Info { get; set; }
        /// <summary>true if the participant is in lobby.</summary>
        public bool? IsInLobby { get; set; }
        /// <summary>true if the participant is muted (client or server muted).</summary>
        public bool? IsMuted { get; set; }
        /// <summary>The list of media streams.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MediaStream> MediaStreams { get; set; }
        /// <summary>A blob of data provided by the participant in the roster.</summary>
        public string Metadata { get; set; }
        /// <summary>Information about whether the participant has recording capability.</summary>
        public ApiSdk.Models.Microsoft.Graph.RecordingInfo RecordingInfo { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Participant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Participant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"info", (o,n) => { (o as Participant).Info = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ParticipantInfo>(ApiSdk.Models.Microsoft.Graph.ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"isInLobby", (o,n) => { (o as Participant).IsInLobby = n.GetBoolValue(); } },
                {"isMuted", (o,n) => { (o as Participant).IsMuted = n.GetBoolValue(); } },
                {"mediaStreams", (o,n) => { (o as Participant).MediaStreams = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MediaStream>(ApiSdk.Models.Microsoft.Graph.MediaStream.CreateFromDiscriminatorValue).ToList(); } },
                {"metadata", (o,n) => { (o as Participant).Metadata = n.GetStringValue(); } },
                {"recordingInfo", (o,n) => { (o as Participant).RecordingInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.RecordingInfo>(ApiSdk.Models.Microsoft.Graph.RecordingInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ParticipantInfo>("info", Info);
            writer.WriteBoolValue("isInLobby", IsInLobby);
            writer.WriteBoolValue("isMuted", IsMuted);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MediaStream>("mediaStreams", MediaStreams);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.RecordingInfo>("recordingInfo", RecordingInfo);
        }
    }
}
