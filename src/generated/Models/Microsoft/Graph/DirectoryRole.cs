using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DirectoryRole : DirectoryObject, IParsable {
        /// <summary>The description for the directory role. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the directory role. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>Users that are members of this directory role. HTTP Methods: GET, POST, DELETE. Read-only. Nullable.</summary>
        public List<DirectoryObject> Members { get; set; }
        /// <summary>The id of the directoryRoleTemplate that this role is based on. The property must be specified when activating a directory role in a tenant with a POST operation. After the directory role has been activated, the property is read only.</summary>
        public string RoleTemplateId { get; set; }
        /// <summary>Members of this directory role that are scoped to administrative units. Read-only. Nullable.</summary>
        public List<ScopedRoleMembership> ScopedMembers { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as DirectoryRole).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DirectoryRole).DisplayName = n.GetStringValue(); } },
                {"members", (o,n) => { (o as DirectoryRole).Members = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"roleTemplateId", (o,n) => { (o as DirectoryRole).RoleTemplateId = n.GetStringValue(); } },
                {"scopedMembers", (o,n) => { (o as DirectoryRole).ScopedMembers = n.GetCollectionOfObjectValues<ScopedRoleMembership>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("members", Members);
            writer.WriteStringValue("roleTemplateId", RoleTemplateId);
            writer.WriteCollectionOfObjectValues<ScopedRoleMembership>("scopedMembers", ScopedMembers);
        }
    }
}
