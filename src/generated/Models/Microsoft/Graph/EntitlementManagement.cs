using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EntitlementManagement : Entity, IParsable {
        /// <summary>Approval stages for assignment requests.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Approval> AccessPackageAssignmentApprovals { get; set; }
        /// <summary>Represents access package objects.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AccessPackage> AccessPackages { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy> AssignmentPolicies { get; set; }
        /// <summary>Represents access package assignment requests created by or on behalf of a user.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentRequest> AssignmentRequests { get; set; }
        /// <summary>Represents the grant of an access package to a subject (user or group).</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignment> Assignments { get; set; }
        /// <summary>Represents a group of access packages.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog> Catalogs { get; set; }
        /// <summary>Represents references to a directory or domain of another organization whose users can request access.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ConnectedOrganization> ConnectedOrganizations { get; set; }
        /// <summary>Represents the settings that control the behavior of Azure AD entitlement management.</summary>
        public ApiSdk.Models.Microsoft.Graph.EntitlementManagementSettings Settings { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.EntitlementManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageAssignmentApprovals", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Approval>(ApiSdk.Models.Microsoft.Graph.Approval.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackages", (o,n) => { (o as EntitlementManagement).AccessPackages = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackage>(ApiSdk.Models.Microsoft.Graph.AccessPackage.CreateFromDiscriminatorValue).ToList(); } },
                {"assignmentPolicies", (o,n) => { (o as EntitlementManagement).AssignmentPolicies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>(ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"assignmentRequests", (o,n) => { (o as EntitlementManagement).AssignmentRequests = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentRequest>(ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"assignments", (o,n) => { (o as EntitlementManagement).Assignments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignment>(ApiSdk.Models.Microsoft.Graph.AccessPackageAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"catalogs", (o,n) => { (o as EntitlementManagement).Catalogs = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog>(ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog.CreateFromDiscriminatorValue).ToList(); } },
                {"connectedOrganizations", (o,n) => { (o as EntitlementManagement).ConnectedOrganizations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ConnectedOrganization>(ApiSdk.Models.Microsoft.Graph.ConnectedOrganization.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", (o,n) => { (o as EntitlementManagement).Settings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagementSettings>(ApiSdk.Models.Microsoft.Graph.EntitlementManagementSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Approval>("accessPackageAssignmentApprovals", AccessPackageAssignmentApprovals);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackage>("accessPackages", AccessPackages);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>("assignmentPolicies", AssignmentPolicies);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentRequest>("assignmentRequests", AssignmentRequests);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog>("catalogs", Catalogs);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ConnectedOrganization>("connectedOrganizations", ConnectedOrganizations);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagementSettings>("settings", Settings);
        }
    }
}
