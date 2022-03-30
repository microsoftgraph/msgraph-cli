using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SubjectRightsRequestStageDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Describes the error, if any, for the current stage.</summary>
        public ApiSdk.Models.Microsoft.Graph.PublicError Error { get; set; }
        /// <summary>The stage of the subject rights request. Possible values are: contentRetrieval, contentReview, generateReport, contentDeletion, caseResolved, unknownFutureValue.</summary>
        public SubjectRightsRequestStage? Stage { get; set; }
        /// <summary>Status of the current stage. Possible values are: notStarted, current, completed, failed, unknownFutureValue.</summary>
        public SubjectRightsRequestStageStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new subjectRightsRequestStageDetail and sets the default values.
        /// </summary>
        public SubjectRightsRequestStageDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.SubjectRightsRequestStageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestStageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"error", (o,n) => { (o as SubjectRightsRequestStageDetail).Error = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PublicError>(ApiSdk.Models.Microsoft.Graph.PublicError.CreateFromDiscriminatorValue); } },
                {"stage", (o,n) => { (o as SubjectRightsRequestStageDetail).Stage = n.GetEnumValue<SubjectRightsRequestStage>(); } },
                {"status", (o,n) => { (o as SubjectRightsRequestStageDetail).Status = n.GetEnumValue<SubjectRightsRequestStageStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PublicError>("error", Error);
            writer.WriteEnumValue<SubjectRightsRequestStage>("stage", Stage);
            writer.WriteEnumValue<SubjectRightsRequestStageStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
