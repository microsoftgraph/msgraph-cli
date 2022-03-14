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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuditLogRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditLogRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"directoryAudits", (o,n) => { (o as AuditLogRoot).DirectoryAudits = n.GetCollectionOfObjectValues<DirectoryAudit>(DirectoryAudit.CreateFromDiscriminatorValue).ToList(); } },
                {"provisioning", (o,n) => { (o as AuditLogRoot).Provisioning = n.GetCollectionOfObjectValues<ProvisioningObjectSummary>(ProvisioningObjectSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"restrictedSignIns", (o,n) => { (o as AuditLogRoot).RestrictedSignIns = n.GetCollectionOfObjectValues<RestrictedSignIn>(RestrictedSignIn.CreateFromDiscriminatorValue).ToList(); } },
                {"signIns", (o,n) => { (o as AuditLogRoot).SignIns = n.GetCollectionOfObjectValues<SignIn>(SignIn.CreateFromDiscriminatorValue).ToList(); } },
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
