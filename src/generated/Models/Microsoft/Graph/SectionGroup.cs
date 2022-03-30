using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SectionGroup : OnenoteEntityHierarchyModel, IParsable {
        /// <summary>The notebook that contains the section group. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Notebook ParentNotebook { get; set; }
        /// <summary>The section group that contains the section group. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SectionGroup ParentSectionGroup { get; set; }
        /// <summary>The section groups in the section. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SectionGroup> SectionGroups { get; set; }
        /// <summary>The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.</summary>
        public string SectionGroupsUrl { get; set; }
        /// <summary>The sections in the section group. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OnenoteSection> Sections { get; set; }
        /// <summary>The URL for the sections navigation property, which returns all the sections in the section group. Read-only.</summary>
        public string SectionsUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.SectionGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SectionGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"parentNotebook", (o,n) => { (o as SectionGroup).ParentNotebook = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Notebook>(ApiSdk.Models.Microsoft.Graph.Notebook.CreateFromDiscriminatorValue); } },
                {"parentSectionGroup", (o,n) => { (o as SectionGroup).ParentSectionGroup = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SectionGroup>(ApiSdk.Models.Microsoft.Graph.SectionGroup.CreateFromDiscriminatorValue); } },
                {"sectionGroups", (o,n) => { (o as SectionGroup).SectionGroups = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SectionGroup>(ApiSdk.Models.Microsoft.Graph.SectionGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"sectionGroupsUrl", (o,n) => { (o as SectionGroup).SectionGroupsUrl = n.GetStringValue(); } },
                {"sections", (o,n) => { (o as SectionGroup).Sections = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenoteSection>(ApiSdk.Models.Microsoft.Graph.OnenoteSection.CreateFromDiscriminatorValue).ToList(); } },
                {"sectionsUrl", (o,n) => { (o as SectionGroup).SectionsUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Notebook>("parentNotebook", ParentNotebook);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SectionGroup>("parentSectionGroup", ParentSectionGroup);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenoteSection>("sections", Sections);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
        }
    }
}
