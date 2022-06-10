using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class UnifiedApprovalStage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of days that a request can be pending a response before it is automatically denied.</summary>
        public int? ApprovalStageTimeOutInDays { get; set; }
        /// <summary>The escalation approvers for this stage when the primary approvers don&apos;t respond.</summary>
        public List<SubjectSet> EscalationApprovers { get; set; }
        /// <summary>The time a request can be pending a response from a primary approver before it can be escalated to the escalation approvers.</summary>
        public int? EscalationTimeInMinutes { get; set; }
        /// <summary>Indicates whether the approver must provide justification for their reponse.</summary>
        public bool? IsApproverJustificationRequired { get; set; }
        /// <summary>Indicates whether escalation if enabled.</summary>
        public bool? IsEscalationEnabled { get; set; }
        /// <summary>The primary approvers of this stage.</summary>
        public List<SubjectSet> PrimaryApprovers { get; set; }
        /// <summary>
        /// Instantiates a new unifiedApprovalStage and sets the default values.
        /// </summary>
        public UnifiedApprovalStage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UnifiedApprovalStage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedApprovalStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"approvalStageTimeOutInDays", n => { ApprovalStageTimeOutInDays = n.GetIntValue(); } },
                {"escalationApprovers", n => { EscalationApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
                {"escalationTimeInMinutes", n => { EscalationTimeInMinutes = n.GetIntValue(); } },
                {"isApproverJustificationRequired", n => { IsApproverJustificationRequired = n.GetBoolValue(); } },
                {"isEscalationEnabled", n => { IsEscalationEnabled = n.GetBoolValue(); } },
                {"primaryApprovers", n => { PrimaryApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("approvalStageTimeOutInDays", ApprovalStageTimeOutInDays);
            writer.WriteCollectionOfObjectValues<SubjectSet>("escalationApprovers", EscalationApprovers);
            writer.WriteIntValue("escalationTimeInMinutes", EscalationTimeInMinutes);
            writer.WriteBoolValue("isApproverJustificationRequired", IsApproverJustificationRequired);
            writer.WriteBoolValue("isEscalationEnabled", IsEscalationEnabled);
            writer.WriteCollectionOfObjectValues<SubjectSet>("primaryApprovers", PrimaryApprovers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
