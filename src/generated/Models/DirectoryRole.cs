using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DirectoryRole : DirectoryObject, IParsable {
        /// <summary>The description for the directory role. Read-only. Supports $filter (eq), $search, $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name for the directory role. Read-only. Supports $filter (eq), $search, $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Users that are members of this directory role. HTTP Methods: GET, POST, DELETE. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? Members { get; set; }
#nullable restore
#else
        public List<DirectoryObject> Members { get; set; }
#endif
        /// <summary>The id of the directoryRoleTemplate that this role is based on. The property must be specified when activating a directory role in a tenant with a POST operation. After the directory role has been activated, the property is read only. Supports $filter (eq), $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleTemplateId { get; set; }
#nullable restore
#else
        public string RoleTemplateId { get; set; }
#endif
        /// <summary>Members of this directory role that are scoped to administrative units. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScopedRoleMembership>? ScopedMembers { get; set; }
#nullable restore
#else
        public List<ScopedRoleMembership> ScopedMembers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new DirectoryRole and sets the default values.
        /// </summary>
        public DirectoryRole() : base() {
            OdataType = "#microsoft.graph.directoryRole";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"members", n => { Members = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleTemplateId", n => { RoleTemplateId = n.GetStringValue(); } },
                {"scopedMembers", n => { ScopedMembers = n.GetCollectionOfObjectValues<ScopedRoleMembership>(ScopedRoleMembership.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
