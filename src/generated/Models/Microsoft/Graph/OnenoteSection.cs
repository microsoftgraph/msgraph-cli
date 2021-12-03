using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnenoteSection : OnenoteEntityHierarchyModel, IParsable {
        /// <summary>Indicates whether this is the user's default section. Read-only.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Links for opening the section. The oneNoteClientURL link opens the section in the OneNote native client if it's installed. The oneNoteWebURL link opens the section in OneNote on the web.</summary>
        public SectionLinks Links { get; set; }
        /// <summary>The collection of pages in the section.  Read-only. Nullable.</summary>
        public List<OnenotePage> Pages { get; set; }
        /// <summary>The pages endpoint where you can get details for all the pages in the section. Read-only.</summary>
        public string PagesUrl { get; set; }
        /// <summary>The notebook that contains the section.  Read-only.</summary>
        public Notebook ParentNotebook { get; set; }
        /// <summary>The section group that contains the section.  Read-only.</summary>
        public SectionGroup ParentSectionGroup { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isDefault", (o,n) => { (o as OnenoteSection).IsDefault = n.GetBoolValue(); } },
                {"links", (o,n) => { (o as OnenoteSection).Links = n.GetObjectValue<SectionLinks>(); } },
                {"pages", (o,n) => { (o as OnenoteSection).Pages = n.GetCollectionOfObjectValues<OnenotePage>().ToList(); } },
                {"pagesUrl", (o,n) => { (o as OnenoteSection).PagesUrl = n.GetStringValue(); } },
                {"parentNotebook", (o,n) => { (o as OnenoteSection).ParentNotebook = n.GetObjectValue<Notebook>(); } },
                {"parentSectionGroup", (o,n) => { (o as OnenoteSection).ParentSectionGroup = n.GetObjectValue<SectionGroup>(); } },
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
            writer.WriteObjectValue<SectionLinks>("links", Links);
            writer.WriteCollectionOfObjectValues<OnenotePage>("pages", Pages);
            writer.WriteStringValue("pagesUrl", PagesUrl);
            writer.WriteObjectValue<Notebook>("parentNotebook", ParentNotebook);
            writer.WriteObjectValue<SectionGroup>("parentSectionGroup", ParentSectionGroup);
        }
    }
}
