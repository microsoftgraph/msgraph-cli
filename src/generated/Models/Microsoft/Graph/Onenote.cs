using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Onenote : Entity, IParsable {
        /// <summary>The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.</summary>
        public List<Notebook> Notebooks { get; set; }
        /// <summary>The status of OneNote operations. Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.</summary>
        public List<OnenoteOperation> Operations { get; set; }
        /// <summary>The pages in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
        public List<OnenotePage> Pages { get; set; }
        /// <summary>The image and other file resources in OneNote pages. Getting a resources collection is not supported, but you can get the binary content of a specific resource. Read-only. Nullable.</summary>
        public List<OnenoteResource> Resources { get; set; }
        /// <summary>The section groups in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
        public List<SectionGroup> SectionGroups { get; set; }
        /// <summary>The sections in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
        public List<OnenoteSection> Sections { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"notebooks", (o,n) => { (o as Onenote).Notebooks = n.GetCollectionOfObjectValues<Notebook>().ToList(); } },
                {"operations", (o,n) => { (o as Onenote).Operations = n.GetCollectionOfObjectValues<OnenoteOperation>().ToList(); } },
                {"pages", (o,n) => { (o as Onenote).Pages = n.GetCollectionOfObjectValues<OnenotePage>().ToList(); } },
                {"resources", (o,n) => { (o as Onenote).Resources = n.GetCollectionOfObjectValues<OnenoteResource>().ToList(); } },
                {"sectionGroups", (o,n) => { (o as Onenote).SectionGroups = n.GetCollectionOfObjectValues<SectionGroup>().ToList(); } },
                {"sections", (o,n) => { (o as Onenote).Sections = n.GetCollectionOfObjectValues<OnenoteSection>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Notebook>("notebooks", Notebooks);
            writer.WriteCollectionOfObjectValues<OnenoteOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<OnenotePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<OnenoteResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteCollectionOfObjectValues<OnenoteSection>("sections", Sections);
        }
    }
}
