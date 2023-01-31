using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Video : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of audio bits per sample.</summary>
        public int? AudioBitsPerSample { get; set; }
        /// <summary>Number of audio channels.</summary>
        public int? AudioChannels { get; set; }
        /// <summary>Name of the audio format (AAC, MP3, etc.).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AudioFormat { get; set; }
#nullable restore
#else
        public string AudioFormat { get; set; }
#endif
        /// <summary>Number of audio samples per second.</summary>
        public int? AudioSamplesPerSecond { get; set; }
        /// <summary>Bit rate of the video in bits per second.</summary>
        public int? Bitrate { get; set; }
        /// <summary>Duration of the file in milliseconds.</summary>
        public long? Duration { get; set; }
        /// <summary>&apos;Four character code&apos; name of the video format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FourCC { get; set; }
#nullable restore
#else
        public string FourCC { get; set; }
#endif
        /// <summary>Frame rate of the video.</summary>
        public double? FrameRate { get; set; }
        /// <summary>Height of the video, in pixels.</summary>
        public int? Height { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Width of the video, in pixels.</summary>
        public int? Width { get; set; }
        /// <summary>
        /// Instantiates a new video and sets the default values.
        /// </summary>
        public Video() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static Video CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static Video CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Video();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"audioBitsPerSample", n => { AudioBitsPerSample = n.GetIntValue(); } },
                {"audioChannels", n => { AudioChannels = n.GetIntValue(); } },
                {"audioFormat", n => { AudioFormat = n.GetStringValue(); } },
                {"audioSamplesPerSecond", n => { AudioSamplesPerSecond = n.GetIntValue(); } },
                {"bitrate", n => { Bitrate = n.GetIntValue(); } },
                {"duration", n => { Duration = n.GetLongValue(); } },
                {"fourCC", n => { FourCC = n.GetStringValue(); } },
                {"frameRate", n => { FrameRate = n.GetDoubleValue(); } },
                {"height", n => { Height = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("audioBitsPerSample", AudioBitsPerSample);
            writer.WriteIntValue("audioChannels", AudioChannels);
            writer.WriteStringValue("audioFormat", AudioFormat);
            writer.WriteIntValue("audioSamplesPerSecond", AudioSamplesPerSecond);
            writer.WriteIntValue("bitrate", Bitrate);
            writer.WriteLongValue("duration", Duration);
            writer.WriteStringValue("fourCC", FourCC);
            writer.WriteDoubleValue("frameRate", FrameRate);
            writer.WriteIntValue("height", Height);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
