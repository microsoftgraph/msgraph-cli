using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class AuditLogRoot : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DirectoryAudit> DirectoryAudits { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.ProvisioningObjectSummary> Provisioning { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.RestrictedSignIn> RestrictedSignIns { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SignIn> SignIns { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AuditLogRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditLogRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"directoryAudits", (o,n) => { (o as AuditLogRoot).DirectoryAudits = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryAudit>(ApiSdk.Models.Microsoft.Graph.DirectoryAudit.CreateFromDiscriminatorValue).ToList(); } },
                {"provisioning", (o,n) => { (o as AuditLogRoot).Provisioning = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ProvisioningObjectSummary>(ApiSdk.Models.Microsoft.Graph.ProvisioningObjectSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"restrictedSignIns", (o,n) => { (o as AuditLogRoot).RestrictedSignIns = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RestrictedSignIn>(ApiSdk.Models.Microsoft.Graph.RestrictedSignIn.CreateFromDiscriminatorValue).ToList(); } },
                {"signIns", (o,n) => { (o as AuditLogRoot).SignIns = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SignIn>(ApiSdk.Models.Microsoft.Graph.SignIn.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryAudit>("directoryAudits", DirectoryAudits);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ProvisioningObjectSummary>("provisioning", Provisioning);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.RestrictedSignIn>("restrictedSignIns", RestrictedSignIns);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SignIn>("signIns", SignIns);
        }
    }
}
