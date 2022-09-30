using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class BroadcastMeetingSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines who can join the Teams live event. Possible values are listed in the following table.</summary>
        public BroadcastMeetingAudience? AllowedAudience { get; set; }
        /// <summary>Caption settings of a Teams live event.</summary>
        public BroadcastMeetingCaptionSettings Captions { get; set; }
        /// <summary>Indicates whether attendee report is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsAttendeeReportEnabled { get; set; }
        /// <summary>Indicates whether Q&amp;A is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsQuestionAndAnswerEnabled { get; set; }
        /// <summary>Indicates whether recording is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsRecordingEnabled { get; set; }
        /// <summary>Indicates whether video on demand is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsVideoOnDemandEnabled { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new broadcastMeetingSettings and sets the default values.
        /// </summary>
        public BroadcastMeetingSettings() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.broadcastMeetingSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BroadcastMeetingSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BroadcastMeetingSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedAudience", n => { AllowedAudience = n.GetEnumValue<BroadcastMeetingAudience>(); } },
                {"captions", n => { Captions = n.GetObjectValue<BroadcastMeetingCaptionSettings>(BroadcastMeetingCaptionSettings.CreateFromDiscriminatorValue); } },
                {"isAttendeeReportEnabled", n => { IsAttendeeReportEnabled = n.GetBoolValue(); } },
                {"isQuestionAndAnswerEnabled", n => { IsQuestionAndAnswerEnabled = n.GetBoolValue(); } },
                {"isRecordingEnabled", n => { IsRecordingEnabled = n.GetBoolValue(); } },
                {"isVideoOnDemandEnabled", n => { IsVideoOnDemandEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<BroadcastMeetingAudience>("allowedAudience", AllowedAudience);
            writer.WriteObjectValue<BroadcastMeetingCaptionSettings>("captions", Captions);
            writer.WriteBoolValue("isAttendeeReportEnabled", IsAttendeeReportEnabled);
            writer.WriteBoolValue("isQuestionAndAnswerEnabled", IsQuestionAndAnswerEnabled);
            writer.WriteBoolValue("isRecordingEnabled", IsRecordingEnabled);
            writer.WriteBoolValue("isVideoOnDemandEnabled", IsVideoOnDemandEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
