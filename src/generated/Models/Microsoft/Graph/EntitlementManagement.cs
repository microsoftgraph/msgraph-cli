using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EntitlementManagement : Entity, IParsable {
        public List<Approval> AccessPackageAssignmentApprovals { get; set; }
        /// <summary>Represents access package objects.</summary>
        public List<AccessPackage> AccessPackages { get; set; }
        /// <summary>Represents access package assignment requests created by or on behalf of a user.</summary>
        public List<AccessPackageAssignmentRequest> AssignmentRequests { get; set; }
        /// <summary>Represents the grant of an access package to a subject (user or group).</summary>
        public List<AccessPackageAssignment> Assignments { get; set; }
        /// <summary>Represents a group of access packages.</summary>
        public List<AccessPackageCatalog> Catalogs { get; set; }
        /// <summary>Represents references to a directory or domain of another organization whose users can request access.</summary>
        public List<ConnectedOrganization> ConnectedOrganizations { get; set; }
        /// <summary>Represents the settings that control the behavior of Azure AD entitlement management.</summary>
        public EntitlementManagementSettings Settings { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EntitlementManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageAssignmentApprovals", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackages", (o,n) => { (o as EntitlementManagement).AccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue).ToList(); } },
                {"assignmentRequests", (o,n) => { (o as EntitlementManagement).AssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>(AccessPackageAssignmentRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"assignments", (o,n) => { (o as EntitlementManagement).Assignments = n.GetCollectionOfObjectValues<AccessPackageAssignment>(AccessPackageAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"catalogs", (o,n) => { (o as EntitlementManagement).Catalogs = n.GetCollectionOfObjectValues<AccessPackageCatalog>(AccessPackageCatalog.CreateFromDiscriminatorValue).ToList(); } },
                {"connectedOrganizations", (o,n) => { (o as EntitlementManagement).ConnectedOrganizations = n.GetCollectionOfObjectValues<ConnectedOrganization>(ConnectedOrganization.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", (o,n) => { (o as EntitlementManagement).Settings = n.GetObjectValue<EntitlementManagementSettings>(EntitlementManagementSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Approval>("accessPackageAssignmentApprovals", AccessPackageAssignmentApprovals);
            writer.WriteCollectionOfObjectValues<AccessPackage>("accessPackages", AccessPackages);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequest>("assignmentRequests", AssignmentRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<AccessPackageCatalog>("catalogs", Catalogs);
            writer.WriteCollectionOfObjectValues<ConnectedOrganization>("connectedOrganizations", ConnectedOrganizations);
            writer.WriteObjectValue<EntitlementManagementSettings>("settings", Settings);
        }
    }
}
