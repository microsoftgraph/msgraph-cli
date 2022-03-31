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
        public ApiSdk.Models.Microsoft.Graph.SectionLinks Links { get; set; }
        /// <summary>The collection of pages in the section.  Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OnenotePage> Pages { get; set; }
        /// <summary>The pages endpoint where you can get details for all the pages in the section. Read-only.</summary>
        public string PagesUrl { get; set; }
        /// <summary>The notebook that contains the section.  Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Notebook ParentNotebook { get; set; }
        /// <summary>The section group that contains the section.  Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SectionGroup ParentSectionGroup { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.OnenoteSection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnenoteSection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isDefault", (o,n) => { (o as OnenoteSection).IsDefault = n.GetBoolValue(); } },
                {"links", (o,n) => { (o as OnenoteSection).Links = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SectionLinks>(ApiSdk.Models.Microsoft.Graph.SectionLinks.CreateFromDiscriminatorValue); } },
                {"pages", (o,n) => { (o as OnenoteSection).Pages = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenotePage>(ApiSdk.Models.Microsoft.Graph.OnenotePage.CreateFromDiscriminatorValue).ToList(); } },
                {"pagesUrl", (o,n) => { (o as OnenoteSection).PagesUrl = n.GetStringValue(); } },
                {"parentNotebook", (o,n) => { (o as OnenoteSection).ParentNotebook = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Notebook>(ApiSdk.Models.Microsoft.Graph.Notebook.CreateFromDiscriminatorValue); } },
                {"parentSectionGroup", (o,n) => { (o as OnenoteSection).ParentSectionGroup = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SectionGroup>(ApiSdk.Models.Microsoft.Graph.SectionGroup.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SectionLinks>("links", Links);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenotePage>("pages", Pages);
            writer.WriteStringValue("pagesUrl", PagesUrl);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Notebook>("parentNotebook", ParentNotebook);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SectionGroup>("parentSectionGroup", ParentSectionGroup);
        }
    }
}
