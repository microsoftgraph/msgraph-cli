using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RecordOperation : CommsOperation, IParsable {
        /// <summary>The access token required to retrieve the recording.</summary>
        public string RecordingAccessToken { get; set; }
        /// <summary>The location where the recording is located.</summary>
        public string RecordingLocation { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"recordingAccessToken", (o,n) => { (o as RecordOperation).RecordingAccessToken = n.GetStringValue(); } },
                {"recordingLocation", (o,n) => { (o as RecordOperation).RecordingLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("recordingAccessToken", RecordingAccessToken);
            writer.WriteStringValue("recordingLocation", RecordingLocation);
        }
    }
}
