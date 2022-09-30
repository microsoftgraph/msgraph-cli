using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AccessReviewStageSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicate which decisions will go to the next stage. Can be a sub-set of Approve, Deny, Recommendation, or NotReviewed. If not provided, all decisions will go to the next stage. Optional.</summary>
        public List<string> DecisionsThatWillMoveToNextStage { get; set; }
        /// <summary>Defines the sequential or parallel order of the stages and depends on the stageId. Only sequential stages are currently supported. For example, if stageId is 2, then dependsOn must be 1. If stageId is 1, do not specify dependsOn. Required if stageId is not 1.</summary>
        public List<string> DependsOn { get; set; }
        /// <summary>The duration of the stage. Required.  NOTE: The cumulative value of this property across all stages  1. Will override the instanceDurationInDays setting on the accessReviewScheduleDefinition object. 2. Cannot exceed the length of one recurrence. That is, if the review recurs weekly, the cumulative durationInDays cannot exceed 7.</summary>
        public int? DurationInDays { get; set; }
        /// <summary>If provided, the fallback reviewers are asked to complete a review if the primary reviewers do not exist. For example, if managers are selected as reviewers and a principal under review does not have a manager in Azure AD, the fallback reviewers are asked to review that principal. NOTE: The value of this property will override the corresponding setting on the accessReviewScheduleDefinition object.</summary>
        public List<AccessReviewReviewerScope> FallbackReviewers { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Indicates whether showing recommendations to reviewers is enabled. Required. NOTE: The value of this property will override override the corresponding setting on the accessReviewScheduleDefinition object.</summary>
        public bool? RecommendationsEnabled { get; set; }
        /// <summary>Defines who the reviewers are. If none are specified, the review is a self-review (users review their own access).  For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API. NOTE: The value of this property will override the corresponding setting on the accessReviewScheduleDefinition.</summary>
        public List<AccessReviewReviewerScope> Reviewers { get; set; }
        /// <summary>Unique identifier of the accessReviewStageSettings object. The stageId will be used by the dependsOn property to indicate the order of the stages. Required.</summary>
        public string StageId { get; set; }
        /// <summary>
        /// Instantiates a new accessReviewStageSettings and sets the default values.
        /// </summary>
        public AccessReviewStageSettings() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.accessReviewStageSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessReviewStageSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewStageSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"decisionsThatWillMoveToNextStage", n => { DecisionsThatWillMoveToNextStage = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"dependsOn", n => { DependsOn = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"durationInDays", n => { DurationInDays = n.GetIntValue(); } },
                {"fallbackReviewers", n => { FallbackReviewers = n.GetCollectionOfObjectValues<AccessReviewReviewerScope>(AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recommendationsEnabled", n => { RecommendationsEnabled = n.GetBoolValue(); } },
                {"reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<AccessReviewReviewerScope>(AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"stageId", n => { StageId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("decisionsThatWillMoveToNextStage", DecisionsThatWillMoveToNextStage);
            writer.WriteCollectionOfPrimitiveValues<string>("dependsOn", DependsOn);
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewerScope>("fallbackReviewers", FallbackReviewers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("recommendationsEnabled", RecommendationsEnabled);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteStringValue("stageId", StageId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
