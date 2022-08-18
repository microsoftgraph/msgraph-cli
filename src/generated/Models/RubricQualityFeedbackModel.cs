using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class RubricQualityFeedbackModel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specific feedback for one quality of this rubric.</summary>
        public EducationItemBody Feedback { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The ID of the rubricQuality that this feedback is related to.</summary>
        public string QualityId { get; set; }
        /// <summary>
        /// Instantiates a new rubricQualityFeedbackModel and sets the default values.
        /// </summary>
        public RubricQualityFeedbackModel() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.rubricQualityFeedbackModel";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RubricQualityFeedbackModel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RubricQualityFeedbackModel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"feedback", n => { Feedback = n.GetObjectValue<EducationItemBody>(EducationItemBody.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"qualityId", n => { QualityId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<EducationItemBody>("feedback", Feedback);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("qualityId", QualityId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
