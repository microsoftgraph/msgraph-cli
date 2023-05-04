using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class EdiscoveryReviewTag : Tag, IParsable {
        /// <summary>Indicates whether a single or multiple child tags can be associated with a document. Possible values are: One, Many.  This value controls whether the UX presents the tags as checkboxes or a radio button group.</summary>
        public ApiSdk.Models.Security.ChildSelectability? ChildSelectability { get; set; }
        /// <summary>Returns the tags that are a child of a tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryReviewTag>? ChildTags { get; set; }
#nullable restore
#else
        public List<EdiscoveryReviewTag> ChildTags { get; set; }
#endif
        /// <summary>Returns the parent tag of the specified tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdiscoveryReviewTag? Parent { get; set; }
#nullable restore
#else
        public EdiscoveryReviewTag Parent { get; set; }
#endif
        /// <summary>
        /// Instantiates a new EdiscoveryReviewTag and sets the default values.
        /// </summary>
        public EdiscoveryReviewTag() : base() {
            OdataType = "#microsoft.graph.security.ediscoveryReviewTag";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoveryReviewTag CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryReviewTag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"childSelectability", n => { ChildSelectability = n.GetEnumValue<ChildSelectability>(); } },
                {"childTags", n => { ChildTags = n.GetCollectionOfObjectValues<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue)?.ToList(); } },
                {"parent", n => { Parent = n.GetObjectValue<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ChildSelectability>("childSelectability", ChildSelectability);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewTag>("childTags", ChildTags);
            writer.WriteObjectValue<EdiscoveryReviewTag>("parent", Parent);
        }
    }
}
