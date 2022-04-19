using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MediaStream : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The direction. The possible values are inactive, sendOnly, receiveOnly, sendReceive.</summary>
        public MediaDirection? Direction { get; set; }
        /// <summary>The media stream label.</summary>
        public string Label { get; set; }
        /// <summary>The media type. The possible value are unknown, audio, video, videoBasedScreenSharing, data.</summary>
        public Modality? MediaType { get; set; }
        /// <summary>If the media is muted by the server.</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MediaStream CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaStream();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"direction", n => { Direction = n.GetEnumValue<MediaDirection>(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"mediaType", n => { MediaType = n.GetEnumValue<Modality>(); } },
                {"serverMuted", n => { ServerMuted = n.GetBoolValue(); } },
                {"sourceId", n => { SourceId = n.GetStringValue(); } },
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
