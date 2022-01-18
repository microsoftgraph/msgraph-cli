using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SecureScoreControlProfile : Entity, IParsable {
        /// <summary>Control action type (Config, Review, Behavior).</summary>
        public string ActionType { get; set; }
        /// <summary>URL to where the control can be actioned.</summary>
        public string ActionUrl { get; set; }
        /// <summary>GUID string for tenant ID.</summary>
        public string AzureTenantId { get; set; }
        /// <summary>The collection of compliance information associated with secure score control</summary>
        public List<ComplianceInformation> ComplianceInformation { get; set; }
        /// <summary>Control action category (Account, Data, Device, Apps, Infrastructure).</summary>
        public string ControlCategory { get; set; }
        /// <summary>Flag to indicate where the tenant has marked a control (ignore, thirdParty, reviewed) (supports update).</summary>
        public List<SecureScoreControlStateUpdate> ControlStateUpdates { get; set; }
        /// <summary>Flag to indicate if a control is depreciated.</summary>
        public bool? Deprecated { get; set; }
        /// <summary>Resource cost of implemmentating control (low, moderate, high).</summary>
        public string ImplementationCost { get; set; }
        /// <summary>Time at which the control profile entity was last modified. The Timestamp type represents date and time</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Current obtained max score on specified date.</summary>
        public double? MaxScore { get; set; }
        /// <summary>Microsoft's stack ranking of control.</summary>
        public int? Rank { get; set; }
        /// <summary>Description of what the control will help remediate.</summary>
        public string Remediation { get; set; }
        /// <summary>Description of the impact on users of the remediation.</summary>
        public string RemediationImpact { get; set; }
        /// <summary>Service that owns the control (Exchange, Sharepoint, Azure AD).</summary>
        public string Service { get; set; }
        /// <summary>List of threats the control mitigates (accountBreach,dataDeletion,dataExfiltration,dataSpillage,elevationOfPrivilege,maliciousInsider,passwordCracking,phishingOrWhaling,spoofing).</summary>
        public List<string> Threats { get; set; }
        /// <summary>Control tier (Core, Defense in Depth, Advanced.)</summary>
        public string Tier { get; set; }
        /// <summary>Title of the control.</summary>
        public string Title { get; set; }
        /// <summary>User impact of implementing control (low, moderate, high).</summary>
        public string UserImpact { get; set; }
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actionType", (o,n) => { (o as SecureScoreControlProfile).ActionType = n.GetStringValue(); } },
                {"actionUrl", (o,n) => { (o as SecureScoreControlProfile).ActionUrl = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as SecureScoreControlProfile).AzureTenantId = n.GetStringValue(); } },
                {"complianceInformation", (o,n) => { (o as SecureScoreControlProfile).ComplianceInformation = n.GetCollectionOfObjectValues<ComplianceInformation>().ToList(); } },
                {"controlCategory", (o,n) => { (o as SecureScoreControlProfile).ControlCategory = n.GetStringValue(); } },
                {"controlStateUpdates", (o,n) => { (o as SecureScoreControlProfile).ControlStateUpdates = n.GetCollectionOfObjectValues<SecureScoreControlStateUpdate>().ToList(); } },
                {"deprecated", (o,n) => { (o as SecureScoreControlProfile).Deprecated = n.GetBoolValue(); } },
                {"implementationCost", (o,n) => { (o as SecureScoreControlProfile).ImplementationCost = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as SecureScoreControlProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"maxScore", (o,n) => { (o as SecureScoreControlProfile).MaxScore = n.GetDoubleValue(); } },
                {"rank", (o,n) => { (o as SecureScoreControlProfile).Rank = n.GetIntValue(); } },
                {"remediation", (o,n) => { (o as SecureScoreControlProfile).Remediation = n.GetStringValue(); } },
                {"remediationImpact", (o,n) => { (o as SecureScoreControlProfile).RemediationImpact = n.GetStringValue(); } },
                {"service", (o,n) => { (o as SecureScoreControlProfile).Service = n.GetStringValue(); } },
                {"threats", (o,n) => { (o as SecureScoreControlProfile).Threats = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tier", (o,n) => { (o as SecureScoreControlProfile).Tier = n.GetStringValue(); } },
                {"title", (o,n) => { (o as SecureScoreControlProfile).Title = n.GetStringValue(); } },
                {"userImpact", (o,n) => { (o as SecureScoreControlProfile).UserImpact = n.GetStringValue(); } },
                {"vendorInformation", (o,n) => { (o as SecureScoreControlProfile).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(); } },
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
            writer.WriteCollectionOfObjectValues<ComplianceInformation>("complianceInformation", ComplianceInformation);
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
