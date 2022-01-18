using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RecordingInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identities of recording initiator.</summary>
        public IdentitySet Initiator { get; set; }
        /// <summary>Possible values are: unknown, notRecording, recording, or failed.</summary>
        public RecordingStatus? RecordingStatus { get; set; }
        /// <summary>
        /// Instantiates a new recordingInfo and sets the default values.
        /// </summary>
        public RecordingInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"initiator", (o,n) => { (o as RecordingInfo).Initiator = n.GetObjectValue<IdentitySet>(); } },
                {"recordingStatus", (o,n) => { (o as RecordingInfo).RecordingStatus = n.GetEnumValue<RecordingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteEnumValue<RecordingStatus>("recordingStatus", RecordingStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
