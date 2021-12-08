using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EntitlementManagement : Entity, IParsable {
        public List<ApiSdk.Models.Microsoft.Graph.Approval> AccessPackageAssignmentApprovals { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.AccessPackage> AccessPackages { get; set; }
        public List<AccessPackageAssignmentRequest> AssignmentRequests { get; set; }
        public List<AccessPackageAssignment> Assignments { get; set; }
        public List<AccessPackageCatalog> Catalogs { get; set; }
        public List<ConnectedOrganization> ConnectedOrganizations { get; set; }
        public EntitlementManagementSettings Settings { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageAssignmentApprovals", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Approval>().ToList(); } },
                {"accessPackages", (o,n) => { (o as EntitlementManagement).AccessPackages = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackage>().ToList(); } },
                {"assignmentRequests", (o,n) => { (o as EntitlementManagement).AssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>().ToList(); } },
                {"assignments", (o,n) => { (o as EntitlementManagement).Assignments = n.GetCollectionOfObjectValues<AccessPackageAssignment>().ToList(); } },
                {"catalogs", (o,n) => { (o as EntitlementManagement).Catalogs = n.GetCollectionOfObjectValues<AccessPackageCatalog>().ToList(); } },
                {"connectedOrganizations", (o,n) => { (o as EntitlementManagement).ConnectedOrganizations = n.GetCollectionOfObjectValues<ConnectedOrganization>().ToList(); } },
                {"settings", (o,n) => { (o as EntitlementManagement).Settings = n.GetObjectValue<EntitlementManagementSettings>(); } },
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
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequest>("assignmentRequests", AssignmentRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<AccessPackageCatalog>("catalogs", Catalogs);
            writer.WriteCollectionOfObjectValues<ConnectedOrganization>("connectedOrganizations", ConnectedOrganizations);
            writer.WriteObjectValue<EntitlementManagementSettings>("settings", Settings);
        }
    }
}
