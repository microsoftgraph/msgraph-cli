using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Onenote : Entity, IParsable {
        /// <summary>The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Notebook>? Notebooks { get; set; }
#nullable restore
#else
        public List<Notebook> Notebooks { get; set; }
#endif
        /// <summary>The status of OneNote operations. Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenoteOperation>? Operations { get; set; }
#nullable restore
#else
        public List<OnenoteOperation> Operations { get; set; }
#endif
        /// <summary>The pages in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenotePage>? Pages { get; set; }
#nullable restore
#else
        public List<OnenotePage> Pages { get; set; }
#endif
        /// <summary>The image and other file resources in OneNote pages. Getting a resources collection is not supported, but you can get the binary content of a specific resource. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenoteResource>? Resources { get; set; }
#nullable restore
#else
        public List<OnenoteResource> Resources { get; set; }
#endif
        /// <summary>The section groups in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SectionGroup>? SectionGroups { get; set; }
#nullable restore
#else
        public List<SectionGroup> SectionGroups { get; set; }
#endif
        /// <summary>The sections in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenoteSection>? Sections { get; set; }
#nullable restore
#else
        public List<OnenoteSection> Sections { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new Onenote CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new Onenote CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Onenote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"notebooks", n => { Notebooks = n.GetCollectionOfObjectValues<Notebook>(Notebook.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<OnenoteOperation>(OnenoteOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pages", n => { Pages = n.GetCollectionOfObjectValues<OnenotePage>(OnenotePage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<OnenoteResource>(OnenoteResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sectionGroups", n => { SectionGroups = n.GetCollectionOfObjectValues<SectionGroup>(SectionGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sections", n => { Sections = n.GetCollectionOfObjectValues<OnenoteSection>(OnenoteSection.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
