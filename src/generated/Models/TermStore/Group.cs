using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.TermStore {
    public class Group : Entity, IParsable {
        /// <summary>Date and time of the group creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description that gives details on the term usage.</summary>
        public string Description { get; set; }
        /// <summary>Name of the group.</summary>
        public string DisplayName { get; set; }
        /// <summary>ID of the parent site of this group.</summary>
        public string ParentSiteId { get; set; }
        /// <summary>Returns the type of the group. Possible values are global, system, and siteCollection.</summary>
        public TermGroupScope? Scope { get; set; }
        /// <summary>All sets under the group in a term [store].</summary>
        public List<Set> Sets { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Group CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Group();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"parentSiteId", n => { ParentSiteId = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetEnumValue<TermGroupScope>(); } },
                {"sets", n => { Sets = n.GetCollectionOfObjectValues<Set>(Set.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("parentSiteId", ParentSiteId);
            writer.WriteEnumValue<TermGroupScope>("scope", Scope);
            writer.WriteCollectionOfObjectValues<Set>("sets", Sets);
        }
    }
}
