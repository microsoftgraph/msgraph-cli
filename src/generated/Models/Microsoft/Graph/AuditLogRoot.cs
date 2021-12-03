using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AuditLogRoot : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public List<DirectoryAudit> DirectoryAudits { get; set; }
        public List<ProvisioningObjectSummary> Provisioning { get; set; }
        public List<RestrictedSignIn> RestrictedSignIns { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<SignIn> SignIns { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"directoryAudits", (o,n) => { (o as AuditLogRoot).DirectoryAudits = n.GetCollectionOfObjectValues<DirectoryAudit>().ToList(); } },
                {"provisioning", (o,n) => { (o as AuditLogRoot).Provisioning = n.GetCollectionOfObjectValues<ProvisioningObjectSummary>().ToList(); } },
                {"restrictedSignIns", (o,n) => { (o as AuditLogRoot).RestrictedSignIns = n.GetCollectionOfObjectValues<RestrictedSignIn>().ToList(); } },
                {"signIns", (o,n) => { (o as AuditLogRoot).SignIns = n.GetCollectionOfObjectValues<SignIn>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryAudit>("directoryAudits", DirectoryAudits);
            writer.WriteCollectionOfObjectValues<ProvisioningObjectSummary>("provisioning", Provisioning);
            writer.WriteCollectionOfObjectValues<RestrictedSignIn>("restrictedSignIns", RestrictedSignIns);
            writer.WriteCollectionOfObjectValues<SignIn>("signIns", SignIns);
        }
    }
}
