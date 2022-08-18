using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DirectoryRole : DirectoryObject, IParsable {
        /// <summary>The description for the directory role. Read-only. Supports $filter (eq), $search, $select.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the directory role. Read-only. Supports $filter (eq), $search, $select.</summary>
        public string DisplayName { get; set; }
        /// <summary>Users that are members of this directory role. HTTP Methods: GET, POST, DELETE. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> Members { get; set; }
        /// <summary>The id of the directoryRoleTemplate that this role is based on. The property must be specified when activating a directory role in a tenant with a POST operation. After the directory role has been activated, the property is read only. Supports $filter (eq), $select.</summary>
        public string RoleTemplateId { get; set; }
        /// <summary>Members of this directory role that are scoped to administrative units. Read-only. Nullable.</summary>
        public List<ScopedRoleMembership> ScopedMembers { get; set; }
        /// <summary>
        /// Instantiates a new DirectoryRole and sets the default values.
        /// </summary>
        public DirectoryRole() : base() {
            OdataType = "#microsoft.graph.directoryRole";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DirectoryRole CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"roleTemplateId", n => { RoleTemplateId = n.GetStringValue(); } },
                {"scopedMembers", n => { ScopedMembers = n.GetCollectionOfObjectValues<ScopedRoleMembership>(ScopedRoleMembership.CreateFromDiscriminatorValue).ToList(); } },
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
