using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class SecureScoreControlProfile : Entity, IParsable {
        /// <summary>Control action type (Config, Review, Behavior).</summary>
        public string ActionType { get; set; }
        /// <summary>URL to where the control can be actioned.</summary>
        public string ActionUrl { get; set; }
        /// <summary>GUID string for tenant ID.</summary>
        public string AzureTenantId { get; set; }
        /// <summary>The complianceInformation property</summary>
        public List<ApiSdk.Models.ComplianceInformation> ComplianceInformation { get; set; }
        /// <summary>Control action category (Identity, Data, Device, Apps, Infrastructure).</summary>
        public string ControlCategory { get; set; }
        /// <summary>The controlStateUpdates property</summary>
        public List<SecureScoreControlStateUpdate> ControlStateUpdates { get; set; }
        /// <summary>Flag to indicate if a control is depreciated.</summary>
        public bool? Deprecated { get; set; }
        /// <summary>Resource cost of implemmentating control (low, moderate, high).</summary>
        public string ImplementationCost { get; set; }
        /// <summary>Time at which the control profile entity was last modified. The Timestamp type represents date and time</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>max attainable score for the control.</summary>
        public double? MaxScore { get; set; }
        /// <summary>Microsoft&apos;s stack ranking of control.</summary>
        public int? Rank { get; set; }
        /// <summary>Description of what the control will help remediate.</summary>
        public string Remediation { get; set; }
        /// <summary>Description of the impact on users of the remediation.</summary>
        public string RemediationImpact { get; set; }
        /// <summary>Service that owns the control (Exchange, Sharepoint, Azure AD).</summary>
        public string Service { get; set; }
        /// <summary>List of threats the control mitigates (accountBreach,dataDeletion,dataExfiltration,dataSpillage,</summary>
        public List<string> Threats { get; set; }
        /// <summary>The tier property</summary>
        public string Tier { get; set; }
        /// <summary>Title of the control.</summary>
        public string Title { get; set; }
        /// <summary>The userImpact property</summary>
        public string UserImpact { get; set; }
        /// <summary>The vendorInformation property</summary>
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>
        /// Instantiates a new secureScoreControlProfile and sets the default values.
        /// </summary>
        public SecureScoreControlProfile() : base() {
            OdataType = "#microsoft.graph.secureScoreControlProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SecureScoreControlProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecureScoreControlProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionType", n => { ActionType = n.GetStringValue(); } },
                {"actionUrl", n => { ActionUrl = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"complianceInformation", n => { ComplianceInformation = n.GetCollectionOfObjectValues<ApiSdk.Models.ComplianceInformation>(ApiSdk.Models.ComplianceInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"controlCategory", n => { ControlCategory = n.GetStringValue(); } },
                {"controlStateUpdates", n => { ControlStateUpdates = n.GetCollectionOfObjectValues<SecureScoreControlStateUpdate>(SecureScoreControlStateUpdate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deprecated", n => { Deprecated = n.GetBoolValue(); } },
                {"implementationCost", n => { ImplementationCost = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"maxScore", n => { MaxScore = n.GetDoubleValue(); } },
                {"rank", n => { Rank = n.GetIntValue(); } },
                {"remediation", n => { Remediation = n.GetStringValue(); } },
                {"remediationImpact", n => { RemediationImpact = n.GetStringValue(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"threats", n => { Threats = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tier", n => { Tier = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"userImpact", n => { UserImpact = n.GetStringValue(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionType", ActionType);
            writer.WriteStringValue("actionUrl", ActionUrl);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.ComplianceInformation>("complianceInformation", ComplianceInformation);
            writer.WriteStringValue("controlCategory", ControlCategory);
            writer.WriteCollectionOfObjectValues<SecureScoreControlStateUpdate>("controlStateUpdates", ControlStateUpdates);
            writer.WriteBoolValue("deprecated", Deprecated);
            writer.WriteStringValue("implementationCost", ImplementationCost);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDoubleValue("maxScore", MaxScore);
            writer.WriteIntValue("rank", Rank);
            writer.WriteStringValue("remediation", Remediation);
            writer.WriteStringValue("remediationImpact", RemediationImpact);
            writer.WriteStringValue("service", Service);
            writer.WriteCollectionOfPrimitiveValues<string>("threats", Threats);
            writer.WriteStringValue("tier", Tier);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("userImpact", UserImpact);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
