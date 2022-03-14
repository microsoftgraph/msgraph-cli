using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RubricLevel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description of this rubric level.</summary>
        public EducationItemBody Description { get; set; }
        /// <summary>The name of this rubric level.</summary>
        public string DisplayName { get; set; }
        /// <summary>Null if this is a no-points rubric; educationAssignmentPointsGradeType if it is a points rubric.</summary>
        public EducationAssignmentGradeType Grading { get; set; }
        /// <summary>The ID of this resource.</summary>
        public string LevelId { get; set; }
        /// <summary>
        /// Instantiates a new rubricLevel and sets the default values.
        /// </summary>
        public RubricLevel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RubricLevel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RubricLevel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as RubricLevel).Description = n.GetObjectValue<EducationItemBody>(EducationItemBody.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as RubricLevel).DisplayName = n.GetStringValue(); } },
                {"grading", (o,n) => { (o as RubricLevel).Grading = n.GetObjectValue<EducationAssignmentGradeType>(EducationAssignmentGradeType.CreateFromDiscriminatorValue); } },
                {"levelId", (o,n) => { (o as RubricLevel).LevelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<EducationItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<EducationAssignmentGradeType>("grading", Grading);
            writer.WriteStringValue("levelId", LevelId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
