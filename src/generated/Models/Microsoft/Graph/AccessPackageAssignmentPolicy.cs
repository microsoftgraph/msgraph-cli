using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessPackageAssignmentPolicy : Entity, IParsable {
        /// <summary>The access package with this policy. Read-only. Nullable. Supports $expand.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackage AccessPackage { get; set; }
        public ApiSdk.Models.Microsoft.Graph.AllowedTargetScope? AllowedTargetScope { get; set; }
        public ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog Catalog { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the policy.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the policy. Supports $filter (eq).</summary>
        public string DisplayName { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ExpirationPattern Expiration { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Who must approve requests for access package in this policy.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentApprovalSettings RequestApprovalSettings { get; set; }
        /// <summary>Who can request this access package from this policy.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentRequestorSettings RequestorSettings { get; set; }
        public ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentReviewSettings ReviewSettings { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.SubjectSet> SpecificAllowedTargets { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackage", (o,n) => { (o as AccessPackageAssignmentPolicy).AccessPackage = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackage>(ApiSdk.Models.Microsoft.Graph.AccessPackage.CreateFromDiscriminatorValue); } },
                {"allowedTargetScope", (o,n) => { (o as AccessPackageAssignmentPolicy).AllowedTargetScope = n.GetEnumValue<AllowedTargetScope>(); } },
                {"catalog", (o,n) => { (o as AccessPackageAssignmentPolicy).Catalog = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog>(ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as AccessPackageAssignmentPolicy).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as AccessPackageAssignmentPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackageAssignmentPolicy).DisplayName = n.GetStringValue(); } },
                {"expiration", (o,n) => { (o as AccessPackageAssignmentPolicy).Expiration = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ExpirationPattern>(ApiSdk.Models.Microsoft.Graph.ExpirationPattern.CreateFromDiscriminatorValue); } },
                {"modifiedDateTime", (o,n) => { (o as AccessPackageAssignmentPolicy).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestApprovalSettings", (o,n) => { (o as AccessPackageAssignmentPolicy).RequestApprovalSettings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentApprovalSettings>(ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentApprovalSettings.CreateFromDiscriminatorValue); } },
                {"requestorSettings", (o,n) => { (o as AccessPackageAssignmentPolicy).RequestorSettings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentRequestorSettings>(ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentRequestorSettings.CreateFromDiscriminatorValue); } },
                {"reviewSettings", (o,n) => { (o as AccessPackageAssignmentPolicy).ReviewSettings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentReviewSettings>(ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentReviewSettings.CreateFromDiscriminatorValue); } },
                {"specificAllowedTargets", (o,n) => { (o as AccessPackageAssignmentPolicy).SpecificAllowedTargets = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>(ApiSdk.Models.Microsoft.Graph.SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteEnumValue<AllowedTargetScope>("allowedTargetScope", AllowedTargetScope);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog>("catalog", Catalog);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ExpirationPattern>("expiration", Expiration);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentApprovalSettings>("requestApprovalSettings", RequestApprovalSettings);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentRequestorSettings>("requestorSettings", RequestorSettings);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentReviewSettings>("reviewSettings", ReviewSettings);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SubjectSet>("specificAllowedTargets", SpecificAllowedTargets);
        }
    }
}
