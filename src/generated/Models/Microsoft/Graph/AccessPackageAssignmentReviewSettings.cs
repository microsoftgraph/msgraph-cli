using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessPackageAssignmentReviewSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public AccessReviewExpirationBehavior? ExpirationBehavior { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.SubjectSet> FallbackReviewers { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsRecommendationEnabled { get; set; }
        public bool? IsReviewerJustificationRequired { get; set; }
        public bool? IsSelfReview { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.SubjectSet> PrimaryReviewers { get; set; }
        public ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule Schedule { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageAssignmentReviewSettings and sets the default values.
        /// </summary>
        public AccessPackageAssignmentReviewSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentReviewSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentReviewSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expirationBehavior", (o,n) => { (o as AccessPackageAssignmentReviewSettings).ExpirationBehavior = n.GetEnumValue<AccessReviewExpirationBehavior>(); } },
                {"fallbackReviewers", (o,n) => { (o as AccessPackageAssignmentReviewSettings).FallbackReviewers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>(ApiSdk.Models.Microsoft.Graph.SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"isEnabled", (o,n) => { (o as AccessPackageAssignmentReviewSettings).IsEnabled = n.GetBoolValue(); } },
                {"isRecommendationEnabled", (o,n) => { (o as AccessPackageAssignmentReviewSettings).IsRecommendationEnabled = n.GetBoolValue(); } },
                {"isReviewerJustificationRequired", (o,n) => { (o as AccessPackageAssignmentReviewSettings).IsReviewerJustificationRequired = n.GetBoolValue(); } },
                {"isSelfReview", (o,n) => { (o as AccessPackageAssignmentReviewSettings).IsSelfReview = n.GetBoolValue(); } },
                {"primaryReviewers", (o,n) => { (o as AccessPackageAssignmentReviewSettings).PrimaryReviewers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>(ApiSdk.Models.Microsoft.Graph.SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"schedule", (o,n) => { (o as AccessPackageAssignmentReviewSettings).Schedule = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule>(ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessReviewExpirationBehavior>("expirationBehavior", ExpirationBehavior);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>("fallbackReviewers", FallbackReviewers);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isRecommendationEnabled", IsRecommendationEnabled);
            writer.WriteBoolValue("isReviewerJustificationRequired", IsReviewerJustificationRequired);
            writer.WriteBoolValue("isSelfReview", IsSelfReview);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>("primaryReviewers", PrimaryReviewers);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
