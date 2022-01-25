using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OAuth2PermissionGrant : Entity, IParsable {
        /// <summary>The id of the client service principal for the application which is authorized to act on behalf of a signed-in user when accessing an API. Required. Supports $filter (eq only).</summary>
        public string ClientId { get; set; }
        /// <summary>Indicates whether authorization is granted for the client application to impersonate all users or only a specific user. AllPrincipals indicates authorization to impersonate all users. Principal indicates authorization to impersonate a specific user. Consent on behalf of all users can be granted by an administrator. Non-admin users may be authorized to consent on behalf of themselves in some cases, for some delegated permissions. Required. Supports $filter (eq only).</summary>
        public string ConsentType { get; set; }
        /// <summary>The id of the user on behalf of whom the client is authorized to access the resource, when consentType is Principal. If consentType is AllPrincipals this value is null. Required when consentType is Principal.</summary>
        public string PrincipalId { get; set; }
        /// <summary>The id of the resource service principal to which access is authorized. This identifies the API which the client is authorized to attempt to call on behalf of a signed-in user.</summary>
        public string ResourceId { get; set; }
        /// <summary>A space-separated list of the claim values for delegated permissions which should be included in access tokens for the resource application (the API). For example, openid User.Read GroupMember.Read.All. Each claim value should match the value field of one of the delegated permissions defined by the API, listed in the publishedPermissionScopes property of the resource service principal.</summary>
        public string Scope { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"clientId", (o,n) => { (o as OAuth2PermissionGrant).ClientId = n.GetStringValue(); } },
                {"consentType", (o,n) => { (o as OAuth2PermissionGrant).ConsentType = n.GetStringValue(); } },
                {"principalId", (o,n) => { (o as OAuth2PermissionGrant).PrincipalId = n.GetStringValue(); } },
                {"resourceId", (o,n) => { (o as OAuth2PermissionGrant).ResourceId = n.GetStringValue(); } },
                {"scope", (o,n) => { (o as OAuth2PermissionGrant).Scope = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("consentType", ConsentType);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("scope", Scope);
        }
    }
}
