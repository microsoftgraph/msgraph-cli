using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ContactFolder : Entity, IParsable {
        /// <summary>The collection of child folders in the folder. Navigation property. Read-only. Nullable.</summary>
        public List<ContactFolder> ChildFolders { get; set; }
        /// <summary>The contacts in the folder. Navigation property. Read-only. Nullable.</summary>
        public List<Contact> Contacts { get; set; }
        /// <summary>The folder's display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>The ID of the folder's parent folder.</summary>
        public string ParentFolderId { get; set; }
        /// <summary>The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"childFolders", (o,n) => { (o as ContactFolder).ChildFolders = n.GetCollectionOfObjectValues<ContactFolder>().ToList(); } },
                {"contacts", (o,n) => { (o as ContactFolder).Contacts = n.GetCollectionOfObjectValues<Contact>().ToList(); } },
                {"displayName", (o,n) => { (o as ContactFolder).DisplayName = n.GetStringValue(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as ContactFolder).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>().ToList(); } },
                {"parentFolderId", (o,n) => { (o as ContactFolder).ParentFolderId = n.GetStringValue(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as ContactFolder).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ContactFolder>("childFolders", ChildFolders);
            writer.WriteCollectionOfObjectValues<Contact>("contacts", Contacts);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
