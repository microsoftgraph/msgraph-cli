using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SubjectRightsRequestHistory : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identity of the user who changed the  subject rights request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? ChangedBy { get; set; }
#nullable restore
#else
        public IdentitySet ChangedBy { get; set; }
#endif
        /// <summary>Data and time when the entity was changed.</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The stage when the entity was changed. Possible values are: contentRetrieval, contentReview, generateReport, contentDeletion, caseResolved, unknownFutureValue.</summary>
        public SubjectRightsRequestStage? Stage { get; set; }
        /// <summary>The status of the stage when the entity was changed. Possible values are: notStarted, current, completed, failed, unknownFutureValue.</summary>
        public SubjectRightsRequestStageStatus? StageStatus { get; set; }
        /// <summary>Type of history.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new subjectRightsRequestHistory and sets the default values.
        /// </summary>
        public SubjectRightsRequestHistory() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SubjectRightsRequestHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"changedBy", n => { ChangedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"stage", n => { Stage = n.GetEnumValue<SubjectRightsRequestStage>(); } },
                {"stageStatus", n => { StageStatus = n.GetEnumValue<SubjectRightsRequestStageStatus>(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("changedBy", ChangedBy);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<SubjectRightsRequestStage>("stage", Stage);
            writer.WriteEnumValue<SubjectRightsRequestStageStatus>("stageStatus", StageStatus);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
