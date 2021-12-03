using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SecureScore : Entity, IParsable {
        /// <summary>Active user count of the given tenant.</summary>
        public int? ActiveUserCount { get; set; }
        /// <summary>Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.</summary>
        public List<AverageComparativeScore> AverageComparativeScores { get; set; }
        /// <summary>GUID string for tenant ID.</summary>
        public string AzureTenantId { get; set; }
        /// <summary>Contains tenant scores for a set of controls.</summary>
        public List<ControlScore> ControlScores { get; set; }
        /// <summary>The date when the entity is created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Tenant current attained score on specified date.</summary>
        public double? CurrentScore { get; set; }
        /// <summary>Microsoft-provided services for the tenant (for example, Exchange online, Skype, Sharepoint).</summary>
        public List<string> EnabledServices { get; set; }
        /// <summary>Licensed user count of the given tenant.</summary>
        public int? LicensedUserCount { get; set; }
        /// <summary>Tenant maximum possible score on specified date.</summary>
        public double? MaxScore { get; set; }
        /// <summary>Complex type containing details about the security product/service vendor, provider, and subprovider (for example, vendor=Microsoft; provider=SecureScore). Required.</summary>
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activeUserCount", (o,n) => { (o as SecureScore).ActiveUserCount = n.GetIntValue(); } },
                {"averageComparativeScores", (o,n) => { (o as SecureScore).AverageComparativeScores = n.GetCollectionOfObjectValues<AverageComparativeScore>().ToList(); } },
                {"azureTenantId", (o,n) => { (o as SecureScore).AzureTenantId = n.GetStringValue(); } },
                {"controlScores", (o,n) => { (o as SecureScore).ControlScores = n.GetCollectionOfObjectValues<ControlScore>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as SecureScore).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"currentScore", (o,n) => { (o as SecureScore).CurrentScore = n.GetDoubleValue(); } },
                {"enabledServices", (o,n) => { (o as SecureScore).EnabledServices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"licensedUserCount", (o,n) => { (o as SecureScore).LicensedUserCount = n.GetIntValue(); } },
                {"maxScore", (o,n) => { (o as SecureScore).MaxScore = n.GetDoubleValue(); } },
                {"vendorInformation", (o,n) => { (o as SecureScore).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeUserCount", ActiveUserCount);
            writer.WriteCollectionOfObjectValues<AverageComparativeScore>("averageComparativeScores", AverageComparativeScores);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteCollectionOfObjectValues<ControlScore>("controlScores", ControlScores);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDoubleValue("currentScore", CurrentScore);
            writer.WriteCollectionOfPrimitiveValues<string>("enabledServices", EnabledServices);
            writer.WriteIntValue("licensedUserCount", LicensedUserCount);
            writer.WriteDoubleValue("maxScore", MaxScore);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
