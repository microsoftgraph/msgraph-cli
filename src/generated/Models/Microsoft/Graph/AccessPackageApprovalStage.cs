using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessPackageApprovalStage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public TimeSpan? DurationBeforeAutomaticDenial { get; set; }
        public TimeSpan? DurationBeforeEscalation { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.SubjectSet> EscalationApprovers { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.SubjectSet> FallbackEscalationApprovers { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.SubjectSet> FallbackPrimaryApprovers { get; set; }
        public bool? IsApproverJustificationRequired { get; set; }
        public bool? IsEscalationEnabled { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.SubjectSet> PrimaryApprovers { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageApprovalStage and sets the default values.
        /// </summary>
        public AccessPackageApprovalStage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AccessPackageApprovalStage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageApprovalStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"durationBeforeAutomaticDenial", (o,n) => { (o as AccessPackageApprovalStage).DurationBeforeAutomaticDenial = n.GetTimeSpanValue(); } },
                {"durationBeforeEscalation", (o,n) => { (o as AccessPackageApprovalStage).DurationBeforeEscalation = n.GetTimeSpanValue(); } },
                {"escalationApprovers", (o,n) => { (o as AccessPackageApprovalStage).EscalationApprovers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>(ApiSdk.Models.Microsoft.Graph.SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"fallbackEscalationApprovers", (o,n) => { (o as AccessPackageApprovalStage).FallbackEscalationApprovers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>(ApiSdk.Models.Microsoft.Graph.SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"fallbackPrimaryApprovers", (o,n) => { (o as AccessPackageApprovalStage).FallbackPrimaryApprovers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>(ApiSdk.Models.Microsoft.Graph.SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"isApproverJustificationRequired", (o,n) => { (o as AccessPackageApprovalStage).IsApproverJustificationRequired = n.GetBoolValue(); } },
                {"isEscalationEnabled", (o,n) => { (o as AccessPackageApprovalStage).IsEscalationEnabled = n.GetBoolValue(); } },
                {"primaryApprovers", (o,n) => { (o as AccessPackageApprovalStage).PrimaryApprovers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>(ApiSdk.Models.Microsoft.Graph.SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("durationBeforeAutomaticDenial", DurationBeforeAutomaticDenial);
            writer.WriteTimeSpanValue("durationBeforeEscalation", DurationBeforeEscalation);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>("escalationApprovers", EscalationApprovers);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>("fallbackEscalationApprovers", FallbackEscalationApprovers);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>("fallbackPrimaryApprovers", FallbackPrimaryApprovers);
            writer.WriteBoolValue("isApproverJustificationRequired", IsApproverJustificationRequired);
            writer.WriteBoolValue("isEscalationEnabled", IsEscalationEnabled);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>("primaryApprovers", PrimaryApprovers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
