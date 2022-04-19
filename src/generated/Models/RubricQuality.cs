using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class RubricQuality : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The collection of criteria for this rubric quality.</summary>
        public List<RubricCriterion> Criteria { get; set; }
        /// <summary>The description of this rubric quality.</summary>
        public EducationItemBody Description { get; set; }
        /// <summary>The name of this rubric quality.</summary>
        public string DisplayName { get; set; }
        /// <summary>The ID of this resource.</summary>
        public string QualityId { get; set; }
        /// <summary>If present, a numerical weight for this quality.  Weights must add up to 100.</summary>
        public float? Weight { get; set; }
        /// <summary>
        /// Instantiates a new rubricQuality and sets the default values.
        /// </summary>
        public RubricQuality() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RubricQuality CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RubricQuality();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"criteria", n => { Criteria = n.GetCollectionOfObjectValues<RubricCriterion>(RubricCriterion.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetObjectValue<EducationItemBody>(EducationItemBody.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"qualityId", n => { QualityId = n.GetStringValue(); } },
                {"weight", n => { Weight = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<RubricCriterion>("criteria", Criteria);
            writer.WriteObjectValue<EducationItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("qualityId", QualityId);
            writer.WriteFloatValue("weight", Weight);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
