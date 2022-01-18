using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MediaStream : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The direction. The possible values are inactive, sendOnly, receiveOnly, sendReceive.</summary>
        public MediaDirection? Direction { get; set; }
        /// <summary>The media stream label.</summary>
        public string Label { get; set; }
        /// <summary>The media type. The possible value are unknown, audio, video, videoBasedScreenSharing, data.</summary>
        public Modality? MediaType { get; set; }
        /// <summary>Indicates whether the media is muted by the server.</summary>
        public bool? ServerMuted { get; set; }
        /// <summary>The source ID.</summary>
        public string SourceId { get; set; }
        /// <summary>
        /// Instantiates a new mediaStream and sets the default values.
        /// </summary>
        public MediaStream() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"direction", (o,n) => { (o as MediaStream).Direction = n.GetEnumValue<MediaDirection>(); } },
                {"label", (o,n) => { (o as MediaStream).Label = n.GetStringValue(); } },
                {"mediaType", (o,n) => { (o as MediaStream).MediaType = n.GetEnumValue<Modality>(); } },
                {"serverMuted", (o,n) => { (o as MediaStream).ServerMuted = n.GetBoolValue(); } },
                {"sourceId", (o,n) => { (o as MediaStream).SourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MediaDirection>("direction", Direction);
            writer.WriteStringValue("label", Label);
            writer.WriteEnumValue<Modality>("mediaType", MediaType);
            writer.WriteBoolValue("serverMuted", ServerMuted);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
