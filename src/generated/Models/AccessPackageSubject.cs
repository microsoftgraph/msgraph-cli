using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AccessPackageSubject : Entity, IParsable {
        /// <summary>The connected organization of the subject. Read-only. Nullable.</summary>
        public ApiSdk.Models.ConnectedOrganization ConnectedOrganization { get; set; }
        /// <summary>The display name of the subject.</summary>
        public string DisplayName { get; set; }
        /// <summary>The email address of the subject.</summary>
        public string Email { get; set; }
        /// <summary>The object identifier of the subject. null if the subject is not yet a user in the tenant.</summary>
        public string ObjectId { get; set; }
        /// <summary>A string representation of the principal&apos;s security identifier, if known, or null if the subject does not have a security identifier.</summary>
        public string OnPremisesSecurityIdentifier { get; set; }
        /// <summary>The principal name, if known, of the subject.</summary>
        public string PrincipalName { get; set; }
        /// <summary>The resource type of the subject. The possible values are: notSpecified, user, servicePrincipal, unknownFutureValue.</summary>
        public AccessPackageSubjectType? SubjectType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageSubject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectedOrganization", n => { ConnectedOrganization = n.GetObjectValue<ApiSdk.Models.ConnectedOrganization>(ApiSdk.Models.ConnectedOrganization.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"objectId", n => { ObjectId = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"principalName", n => { PrincipalName = n.GetStringValue(); } },
                {"subjectType", n => { SubjectType = n.GetEnumValue<AccessPackageSubjectType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.ConnectedOrganization>("connectedOrganization", ConnectedOrganization);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteEnumValue<AccessPackageSubjectType>("subjectType", SubjectType);
        }
    }
}
