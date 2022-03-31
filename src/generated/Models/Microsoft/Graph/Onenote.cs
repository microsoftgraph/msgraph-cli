using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Onenote : Entity, IParsable {
        /// <summary>The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Notebook> Notebooks { get; set; }
        /// <summary>The status of OneNote operations. Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OnenoteOperation> Operations { get; set; }
        /// <summary>The pages in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OnenotePage> Pages { get; set; }
        /// <summary>The image and other file resources in OneNote pages. Getting a resources collection is not supported, but you can get the binary content of a specific resource. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OnenoteResource> Resources { get; set; }
        /// <summary>The section groups in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SectionGroup> SectionGroups { get; set; }
        /// <summary>The sections in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OnenoteSection> Sections { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Onenote CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Onenote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"notebooks", (o,n) => { (o as Onenote).Notebooks = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Notebook>(ApiSdk.Models.Microsoft.Graph.Notebook.CreateFromDiscriminatorValue).ToList(); } },
                {"operations", (o,n) => { (o as Onenote).Operations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenoteOperation>(ApiSdk.Models.Microsoft.Graph.OnenoteOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"pages", (o,n) => { (o as Onenote).Pages = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenotePage>(ApiSdk.Models.Microsoft.Graph.OnenotePage.CreateFromDiscriminatorValue).ToList(); } },
                {"resources", (o,n) => { (o as Onenote).Resources = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenoteResource>(ApiSdk.Models.Microsoft.Graph.OnenoteResource.CreateFromDiscriminatorValue).ToList(); } },
                {"sectionGroups", (o,n) => { (o as Onenote).SectionGroups = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SectionGroup>(ApiSdk.Models.Microsoft.Graph.SectionGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"sections", (o,n) => { (o as Onenote).Sections = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenoteSection>(ApiSdk.Models.Microsoft.Graph.OnenoteSection.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Notebook>("notebooks", Notebooks);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenoteOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenotePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenoteResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnenoteSection>("sections", Sections);
        }
    }
}
