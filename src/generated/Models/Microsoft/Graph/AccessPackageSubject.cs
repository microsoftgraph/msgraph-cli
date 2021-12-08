using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessPackageSubject : Entity, IParsable {
        /// <summary>The connected organization of the subject. Read-only. Nullable.</summary>
        public ConnectedOrganization ConnectedOrganization { get; set; }
        /// <summary>The display name of the subject.</summary>
        public string DisplayName { get; set; }
        /// <summary>The email address of the subject.</summary>
        public string Email { get; set; }
        /// <summary>The object identifier of the subject. null if the subject is not yet a user in the tenant.</summary>
        public string ObjectId { get; set; }
        public string OnPremisesSecurityIdentifier { get; set; }
        /// <summary>The principal name, if known, of the subject.</summary>
        public string PrincipalName { get; set; }
        public AccessPackageSubjectType? SubjectType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"connectedOrganization", (o,n) => { (o as AccessPackageSubject).ConnectedOrganization = n.GetObjectValue<ConnectedOrganization>(); } },
                {"displayName", (o,n) => { (o as AccessPackageSubject).DisplayName = n.GetStringValue(); } },
                {"email", (o,n) => { (o as AccessPackageSubject).Email = n.GetStringValue(); } },
                {"objectId", (o,n) => { (o as AccessPackageSubject).ObjectId = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", (o,n) => { (o as AccessPackageSubject).OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"principalName", (o,n) => { (o as AccessPackageSubject).PrincipalName = n.GetStringValue(); } },
                {"subjectType", (o,n) => { (o as AccessPackageSubject).SubjectType = n.GetEnumValue<AccessPackageSubjectType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ConnectedOrganization>("connectedOrganization", ConnectedOrganization);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteEnumValue<AccessPackageSubjectType>("subjectType", SubjectType);
        }
    }
}
