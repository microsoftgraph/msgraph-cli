using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class EducationRubric : Entity, IParsable {
        /// <summary>The user who created this resource.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of this rubric.</summary>
        public EducationItemBody Description { get; set; }
        /// <summary>The name of this rubric.</summary>
        public string DisplayName { get; set; }
        /// <summary>The grading type of this rubric -- null for a no-points rubric, or educationAssignmentPointsGradeType for a points rubric.</summary>
        public EducationAssignmentGradeType Grading { get; set; }
        /// <summary>The last user to modify the resource.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>Moment in time when the resource was last modified.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The collection of levels making up this rubric.</summary>
        public List<RubricLevel> Levels { get; set; }
        /// <summary>The collection of qualities making up this rubric.</summary>
        public List<RubricQuality> Qualities { get; set; }
        /// <summary>
        /// Instantiates a new EducationRubric and sets the default values.
        /// </summary>
        public EducationRubric() : base() {
            OdataType = "#microsoft.graph.educationRubric";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationRubric CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationRubric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetObjectValue<EducationItemBody>(EducationItemBody.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"grading", n => { Grading = n.GetObjectValue<EducationAssignmentGradeType>(EducationAssignmentGradeType.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"levels", n => { Levels = n.GetCollectionOfObjectValues<RubricLevel>(RubricLevel.CreateFromDiscriminatorValue).ToList(); } },
                {"qualities", n => { Qualities = n.GetCollectionOfObjectValues<RubricQuality>(RubricQuality.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<EducationItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<EducationAssignmentGradeType>("grading", Grading);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<RubricLevel>("levels", Levels);
            writer.WriteCollectionOfObjectValues<RubricQuality>("qualities", Qualities);
        }
    }
}
