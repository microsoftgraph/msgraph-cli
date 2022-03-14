using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AdministrativeUnit : DirectoryObject, IParsable {
        /// <summary>An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.</summary>
        public string Description { get; set; }
        /// <summary>Display name for the administrative unit. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName { get; set; }
        /// <summary>The collection of open extensions defined for this administrative unit. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>Users and groups that are members of this administrative unit. Supports $expand.</summary>
        public List<DirectoryObject> Members { get; set; }
        /// <summary>Scoped-role members of this administrative unit.</summary>
        public List<ScopedRoleMembership> ScopedRoleMembers { get; set; }
        /// <summary>Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership or Public. If not set, default behavior is Public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.</summary>
        public string Visibility { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AdministrativeUnit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AdministrativeUnit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as AdministrativeUnit).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AdministrativeUnit).DisplayName = n.GetStringValue(); } },
                {"extensions", (o,n) => { (o as AdministrativeUnit).Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"members", (o,n) => { (o as AdministrativeUnit).Members = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"scopedRoleMembers", (o,n) => { (o as AdministrativeUnit).ScopedRoleMembers = n.GetCollectionOfObjectValues<ScopedRoleMembership>(ScopedRoleMembership.CreateFromDiscriminatorValue).ToList(); } },
                {"visibility", (o,n) => { (o as AdministrativeUnit).Visibility = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("members", Members);
            writer.WriteCollectionOfObjectValues<ScopedRoleMembership>("scopedRoleMembers", ScopedRoleMembers);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
