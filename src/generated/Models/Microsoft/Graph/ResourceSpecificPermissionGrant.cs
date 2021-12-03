using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ResourceSpecificPermissionGrant : DirectoryObject, IParsable {
        /// <summary>ID of the service principal of the Azure AD app that has been granted access. Read-only.</summary>
        public string ClientAppId { get; set; }
        /// <summary>ID of the Azure AD app that has been granted access. Read-only.</summary>
        public string ClientId { get; set; }
        /// <summary>The name of the resource-specific permission. Read-only.</summary>
        public string Permission { get; set; }
        /// <summary>The type of permission. Possible values are: Application, Delegated. Read-only.</summary>
        public string PermissionType { get; set; }
        /// <summary>ID of the Azure AD app that is hosting the resource. Read-only.</summary>
        public string ResourceAppId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"clientAppId", (o,n) => { (o as ResourceSpecificPermissionGrant).ClientAppId = n.GetStringValue(); } },
                {"clientId", (o,n) => { (o as ResourceSpecificPermissionGrant).ClientId = n.GetStringValue(); } },
                {"permission", (o,n) => { (o as ResourceSpecificPermissionGrant).Permission = n.GetStringValue(); } },
                {"permissionType", (o,n) => { (o as ResourceSpecificPermissionGrant).PermissionType = n.GetStringValue(); } },
                {"resourceAppId", (o,n) => { (o as ResourceSpecificPermissionGrant).ResourceAppId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clientAppId", ClientAppId);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("permission", Permission);
            writer.WriteStringValue("permissionType", PermissionType);
            writer.WriteStringValue("resourceAppId", ResourceAppId);
        }
    }
}
