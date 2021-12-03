using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Notebook : OnenoteEntityHierarchyModel, IParsable {
        /// <summary>Indicates whether this is the user's default notebook. Read-only.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.</summary>
        public bool? IsShared { get; set; }
        /// <summary>Links for opening the notebook. The oneNoteClientURL link opens the notebook in the OneNote native client if it's installed. The oneNoteWebURL link opens the notebook in OneNote on the web.</summary>
        public NotebookLinks Links { get; set; }
        /// <summary>The section groups in the notebook. Read-only. Nullable.</summary>
        public List<SectionGroup> SectionGroups { get; set; }
        /// <summary>The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.</summary>
        public string SectionGroupsUrl { get; set; }
        /// <summary>The sections in the notebook. Read-only. Nullable.</summary>
        public List<OnenoteSection> Sections { get; set; }
        /// <summary>The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.</summary>
        public string SectionsUrl { get; set; }
        /// <summary>Possible values are: Owner, Contributor, Reader, None. Owner represents owner-level access to the notebook. Contributor represents read/write access to the notebook. Reader represents read-only access to the notebook. Read-only.</summary>
        public OnenoteUserRole? UserRole { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isDefault", (o,n) => { (o as Notebook).IsDefault = n.GetBoolValue(); } },
                {"isShared", (o,n) => { (o as Notebook).IsShared = n.GetBoolValue(); } },
                {"links", (o,n) => { (o as Notebook).Links = n.GetObjectValue<NotebookLinks>(); } },
                {"sectionGroups", (o,n) => { (o as Notebook).SectionGroups = n.GetCollectionOfObjectValues<SectionGroup>().ToList(); } },
                {"sectionGroupsUrl", (o,n) => { (o as Notebook).SectionGroupsUrl = n.GetStringValue(); } },
                {"sections", (o,n) => { (o as Notebook).Sections = n.GetCollectionOfObjectValues<OnenoteSection>().ToList(); } },
                {"sectionsUrl", (o,n) => { (o as Notebook).SectionsUrl = n.GetStringValue(); } },
                {"userRole", (o,n) => { (o as Notebook).UserRole = n.GetEnumValue<OnenoteUserRole>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteObjectValue<NotebookLinks>("links", Links);
            writer.WriteCollectionOfObjectValues<SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteCollectionOfObjectValues<OnenoteSection>("sections", Sections);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
            writer.WriteEnumValue<OnenoteUserRole>("userRole", UserRole);
        }
    }
}
