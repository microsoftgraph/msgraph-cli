using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SubjectRightsRequestHistory : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identity of the user who changed the  subject rights request.</summary>
        public IdentitySet ChangedBy { get; set; }
        /// <summary>Data and time when the entity was changed.</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>The stage when the entity was changed. Possible values are: contentRetrieval, contentReview, generateReport, contentDeletion, caseResolved, unknownFutureValue.</summary>
        public SubjectRightsRequestStage? Stage { get; set; }
        /// <summary>The status of the stage when the entity was changed. Possible values are: notStarted, current, completed, failed, unknownFutureValue.</summary>
        public SubjectRightsRequestStageStatus? StageStatus { get; set; }
        /// <summary>Type of history.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new subjectRightsRequestHistory and sets the default values.
        /// </summary>
        public SubjectRightsRequestHistory() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SubjectRightsRequestHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"changedBy", (o,n) => { (o as SubjectRightsRequestHistory).ChangedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"eventDateTime", (o,n) => { (o as SubjectRightsRequestHistory).EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"stage", (o,n) => { (o as SubjectRightsRequestHistory).Stage = n.GetEnumValue<SubjectRightsRequestStage>(); } },
                {"stageStatus", (o,n) => { (o as SubjectRightsRequestHistory).StageStatus = n.GetEnumValue<SubjectRightsRequestStageStatus>(); } },
                {"type", (o,n) => { (o as SubjectRightsRequestHistory).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("changedBy", ChangedBy);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteEnumValue<SubjectRightsRequestStage>("stage", Stage);
            writer.WriteEnumValue<SubjectRightsRequestStageStatus>("stageStatus", StageStatus);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
