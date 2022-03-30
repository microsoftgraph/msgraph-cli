using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationRubric : Entity, IParsable {
        /// <summary>The user who created this resource.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySet CreatedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of this rubric.</summary>
        public ApiSdk.Models.Microsoft.Graph.EducationItemBody Description { get; set; }
        /// <summary>The name of this rubric.</summary>
        public string DisplayName { get; set; }
        /// <summary>The grading type of this rubric -- null for a no-points rubric, or educationAssignmentPointsGradeType for a points rubric.</summary>
        public ApiSdk.Models.Microsoft.Graph.EducationAssignmentGradeType Grading { get; set; }
        /// <summary>The last user to modify the resource.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySet LastModifiedBy { get; set; }
        /// <summary>Moment in time when the resource was last modified.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The collection of levels making up this rubric.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.RubricLevel> Levels { get; set; }
        /// <summary>The collection of qualities making up this rubric.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.RubricQuality> Qualities { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.EducationRubric CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationRubric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as EducationRubric).CreatedBy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as EducationRubric).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as EducationRubric).Description = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EducationItemBody>(ApiSdk.Models.Microsoft.Graph.EducationItemBody.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as EducationRubric).DisplayName = n.GetStringValue(); } },
                {"grading", (o,n) => { (o as EducationRubric).Grading = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EducationAssignmentGradeType>(ApiSdk.Models.Microsoft.Graph.EducationAssignmentGradeType.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", (o,n) => { (o as EducationRubric).LastModifiedBy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as EducationRubric).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"levels", (o,n) => { (o as EducationRubric).Levels = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RubricLevel>(ApiSdk.Models.Microsoft.Graph.RubricLevel.CreateFromDiscriminatorValue).ToList(); } },
                {"qualities", (o,n) => { (o as EducationRubric).Qualities = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RubricQuality>(ApiSdk.Models.Microsoft.Graph.RubricQuality.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EducationItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EducationAssignmentGradeType>("grading", Grading);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RubricLevel>("levels", Levels);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RubricQuality>("qualities", Qualities);
        }
    }
}
