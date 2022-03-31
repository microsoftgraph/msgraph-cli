using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class BroadcastMeetingSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines who can join the Teams live event. Possible values are listed in the following table.</summary>
        public BroadcastMeetingAudience? AllowedAudience { get; set; }
        /// <summary>Indicates whether attendee report is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsAttendeeReportEnabled { get; set; }
        /// <summary>Indicates whether Q&A is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsQuestionAndAnswerEnabled { get; set; }
        /// <summary>Indicates whether recording is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsRecordingEnabled { get; set; }
        /// <summary>Indicates whether video on demand is enabled for this Teams live event. Default value is false.</summary>
        public bool? IsVideoOnDemandEnabled { get; set; }
        /// <summary>
        /// Instantiates a new broadcastMeetingSettings and sets the default values.
        /// </summary>
        public BroadcastMeetingSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.BroadcastMeetingSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BroadcastMeetingSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowedAudience", (o,n) => { (o as BroadcastMeetingSettings).AllowedAudience = n.GetEnumValue<BroadcastMeetingAudience>(); } },
                {"isAttendeeReportEnabled", (o,n) => { (o as BroadcastMeetingSettings).IsAttendeeReportEnabled = n.GetBoolValue(); } },
                {"isQuestionAndAnswerEnabled", (o,n) => { (o as BroadcastMeetingSettings).IsQuestionAndAnswerEnabled = n.GetBoolValue(); } },
                {"isRecordingEnabled", (o,n) => { (o as BroadcastMeetingSettings).IsRecordingEnabled = n.GetBoolValue(); } },
                {"isVideoOnDemandEnabled", (o,n) => { (o as BroadcastMeetingSettings).IsVideoOnDemandEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<BroadcastMeetingAudience>("allowedAudience", AllowedAudience);
            writer.WriteBoolValue("isAttendeeReportEnabled", IsAttendeeReportEnabled);
            writer.WriteBoolValue("isQuestionAndAnswerEnabled", IsQuestionAndAnswerEnabled);
            writer.WriteBoolValue("isRecordingEnabled", IsRecordingEnabled);
            writer.WriteBoolValue("isVideoOnDemandEnabled", IsVideoOnDemandEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
