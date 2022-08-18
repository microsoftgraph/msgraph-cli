using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ApprovalSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>One of SingleStage, Serial, Parallel, NoApproval (default). NoApproval is used when isApprovalRequired is false.</summary>
        public string ApprovalMode { get; set; }
        /// <summary>If approval is required, the one or two elements of this collection define each of the stages of approval. An empty array if no approval is required.</summary>
        public List<UnifiedApprovalStage> ApprovalStages { get; set; }
        /// <summary>Indicates whether approval is required for requests in this policy.</summary>
        public bool? IsApprovalRequired { get; set; }
        /// <summary>Indicates whether approval is required for a user to extend their assignment.</summary>
        public bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary>Indicates whether the requestor is required to supply a justification in their request.</summary>
        public bool? IsRequestorJustificationRequired { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new approvalSettings and sets the default values.
        /// </summary>
        public ApprovalSettings() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.approvalSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApprovalSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApprovalSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"approvalMode", n => { ApprovalMode = n.GetStringValue(); } },
                {"approvalStages", n => { ApprovalStages = n.GetCollectionOfObjectValues<UnifiedApprovalStage>(UnifiedApprovalStage.CreateFromDiscriminatorValue).ToList(); } },
                {"isApprovalRequired", n => { IsApprovalRequired = n.GetBoolValue(); } },
                {"isApprovalRequiredForExtension", n => { IsApprovalRequiredForExtension = n.GetBoolValue(); } },
                {"isRequestorJustificationRequired", n => { IsRequestorJustificationRequired = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("approvalMode", ApprovalMode);
            writer.WriteCollectionOfObjectValues<UnifiedApprovalStage>("approvalStages", ApprovalStages);
            writer.WriteBoolValue("isApprovalRequired", IsApprovalRequired);
            writer.WriteBoolValue("isApprovalRequiredForExtension", IsApprovalRequiredForExtension);
            writer.WriteBoolValue("isRequestorJustificationRequired", IsRequestorJustificationRequired);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
