using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.CallRecords {
    public class DeviceInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the capture device driver used by the media endpoint.</summary>
        public string CaptureDeviceDriver { get; set; }
        /// <summary>Name of the capture device used by the media endpoint.</summary>
        public string CaptureDeviceName { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected the capture device was not working properly.</summary>
        public float? CaptureNotFunctioningEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected the CPU resources available were insufficient and caused poor quality of the audio sent and received.</summary>
        public float? CpuInsufficentEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected clipping in the captured audio that caused poor quality of the audio being sent.</summary>
        public float? DeviceClippingEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected glitches or gaps in the audio played or captured that caused poor quality of the audio being sent or received.</summary>
        public float? DeviceGlitchEventRatio { get; set; }
        /// <summary>Number of times during the call that the media endpoint detected howling or screeching audio.</summary>
        public int? HowlingEventCount { get; set; }
        /// <summary>The root mean square (RMS) of the incoming signal of up to the first 30 seconds of the call.</summary>
        public float? InitialSignalLevelRootMeanSquare { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected low speech level that caused poor quality of the audio being sent.</summary>
        public float? LowSpeechLevelEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected low speech to noise level that caused poor quality of the audio being sent.</summary>
        public float? LowSpeechToNoiseEventRatio { get; set; }
        /// <summary>Glitches per 5 minute interval for the media endpoint's microphone.</summary>
        public float? MicGlitchRate { get; set; }
        /// <summary>Average energy level of received audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.</summary>
        public int? ReceivedNoiseLevel { get; set; }
        /// <summary>Average energy level of received audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.</summary>
        public int? ReceivedSignalLevel { get; set; }
        /// <summary>Name of the render device driver used by the media endpoint.</summary>
        public string RenderDeviceDriver { get; set; }
        /// <summary>Name of the render device used by the media endpoint.</summary>
        public string RenderDeviceName { get; set; }
        /// <summary>Fraction of the call that media endpoint detected device render is muted.</summary>
        public float? RenderMuteEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected the render device was not working properly.</summary>
        public float? RenderNotFunctioningEventRatio { get; set; }
        /// <summary>Fraction of the call that media endpoint detected device render volume is set to 0.</summary>
        public float? RenderZeroVolumeEventRatio { get; set; }
        /// <summary>Average energy level of sent audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.</summary>
        public int? SentNoiseLevel { get; set; }
        /// <summary>Average energy level of sent audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.</summary>
        public int? SentSignalLevel { get; set; }
        /// <summary>Glitches per 5 minute internal for the media endpoint's loudspeaker.</summary>
        public float? SpeakerGlitchRate { get; set; }
        /// <summary>
        /// Instantiates a new deviceInfo and sets the default values.
        /// </summary>
        public DeviceInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"captureDeviceDriver", (o,n) => { (o as DeviceInfo).CaptureDeviceDriver = n.GetStringValue(); } },
                {"captureDeviceName", (o,n) => { (o as DeviceInfo).CaptureDeviceName = n.GetStringValue(); } },
                {"captureNotFunctioningEventRatio", (o,n) => { (o as DeviceInfo).CaptureNotFunctioningEventRatio = n.GetFloatValue(); } },
                {"cpuInsufficentEventRatio", (o,n) => { (o as DeviceInfo).CpuInsufficentEventRatio = n.GetFloatValue(); } },
                {"deviceClippingEventRatio", (o,n) => { (o as DeviceInfo).DeviceClippingEventRatio = n.GetFloatValue(); } },
                {"deviceGlitchEventRatio", (o,n) => { (o as DeviceInfo).DeviceGlitchEventRatio = n.GetFloatValue(); } },
                {"howlingEventCount", (o,n) => { (o as DeviceInfo).HowlingEventCount = n.GetIntValue(); } },
                {"initialSignalLevelRootMeanSquare", (o,n) => { (o as DeviceInfo).InitialSignalLevelRootMeanSquare = n.GetFloatValue(); } },
                {"lowSpeechLevelEventRatio", (o,n) => { (o as DeviceInfo).LowSpeechLevelEventRatio = n.GetFloatValue(); } },
                {"lowSpeechToNoiseEventRatio", (o,n) => { (o as DeviceInfo).LowSpeechToNoiseEventRatio = n.GetFloatValue(); } },
                {"micGlitchRate", (o,n) => { (o as DeviceInfo).MicGlitchRate = n.GetFloatValue(); } },
                {"receivedNoiseLevel", (o,n) => { (o as DeviceInfo).ReceivedNoiseLevel = n.GetIntValue(); } },
                {"receivedSignalLevel", (o,n) => { (o as DeviceInfo).ReceivedSignalLevel = n.GetIntValue(); } },
                {"renderDeviceDriver", (o,n) => { (o as DeviceInfo).RenderDeviceDriver = n.GetStringValue(); } },
                {"renderDeviceName", (o,n) => { (o as DeviceInfo).RenderDeviceName = n.GetStringValue(); } },
                {"renderMuteEventRatio", (o,n) => { (o as DeviceInfo).RenderMuteEventRatio = n.GetFloatValue(); } },
                {"renderNotFunctioningEventRatio", (o,n) => { (o as DeviceInfo).RenderNotFunctioningEventRatio = n.GetFloatValue(); } },
                {"renderZeroVolumeEventRatio", (o,n) => { (o as DeviceInfo).RenderZeroVolumeEventRatio = n.GetFloatValue(); } },
                {"sentNoiseLevel", (o,n) => { (o as DeviceInfo).SentNoiseLevel = n.GetIntValue(); } },
                {"sentSignalLevel", (o,n) => { (o as DeviceInfo).SentSignalLevel = n.GetIntValue(); } },
                {"speakerGlitchRate", (o,n) => { (o as DeviceInfo).SpeakerGlitchRate = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("captureDeviceDriver", CaptureDeviceDriver);
            writer.WriteStringValue("captureDeviceName", CaptureDeviceName);
            writer.WriteFloatValue("captureNotFunctioningEventRatio", CaptureNotFunctioningEventRatio);
            writer.WriteFloatValue("cpuInsufficentEventRatio", CpuInsufficentEventRatio);
            writer.WriteFloatValue("deviceClippingEventRatio", DeviceClippingEventRatio);
            writer.WriteFloatValue("deviceGlitchEventRatio", DeviceGlitchEventRatio);
            writer.WriteIntValue("howlingEventCount", HowlingEventCount);
            writer.WriteFloatValue("initialSignalLevelRootMeanSquare", InitialSignalLevelRootMeanSquare);
            writer.WriteFloatValue("lowSpeechLevelEventRatio", LowSpeechLevelEventRatio);
            writer.WriteFloatValue("lowSpeechToNoiseEventRatio", LowSpeechToNoiseEventRatio);
            writer.WriteFloatValue("micGlitchRate", MicGlitchRate);
            writer.WriteIntValue("receivedNoiseLevel", ReceivedNoiseLevel);
            writer.WriteIntValue("receivedSignalLevel", ReceivedSignalLevel);
            writer.WriteStringValue("renderDeviceDriver", RenderDeviceDriver);
            writer.WriteStringValue("renderDeviceName", RenderDeviceName);
            writer.WriteFloatValue("renderMuteEventRatio", RenderMuteEventRatio);
            writer.WriteFloatValue("renderNotFunctioningEventRatio", RenderNotFunctioningEventRatio);
            writer.WriteFloatValue("renderZeroVolumeEventRatio", RenderZeroVolumeEventRatio);
            writer.WriteIntValue("sentNoiseLevel", SentNoiseLevel);
            writer.WriteIntValue("sentSignalLevel", SentSignalLevel);
            writer.WriteFloatValue("speakerGlitchRate", SpeakerGlitchRate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
