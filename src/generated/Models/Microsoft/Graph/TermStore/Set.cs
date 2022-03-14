using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.TermStore {
    public class Set : Entity, IParsable {
        /// <summary>Children terms of set in term [store].</summary>
        public List<Term> Children { get; set; }
        /// <summary>Date and time of set creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description giving details on the term usage.</summary>
        public string Description { get; set; }
        /// <summary>Name of the set for each languageTag.</summary>
        public List<LocalizedName> LocalizedNames { get; set; }
        public Group ParentGroup { get; set; }
        /// <summary>Custom properties for the set.</summary>
        public List<KeyValue> Properties { get; set; }
        /// <summary>Indicates which terms have been pinned or reused directly under the set.</summary>
        public List<Relation> Relations { get; set; }
        /// <summary>All the terms under the set.</summary>
        public List<Term> Terms { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Set CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Set();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"children", (o,n) => { (o as Set).Children = n.GetCollectionOfObjectValues<Term>(Term.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as Set).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as Set).Description = n.GetStringValue(); } },
                {"localizedNames", (o,n) => { (o as Set).LocalizedNames = n.GetCollectionOfObjectValues<LocalizedName>(LocalizedName.CreateFromDiscriminatorValue).ToList(); } },
                {"parentGroup", (o,n) => { (o as Set).ParentGroup = n.GetObjectValue<Group>(Group.CreateFromDiscriminatorValue); } },
                {"properties", (o,n) => { (o as Set).Properties = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"relations", (o,n) => { (o as Set).Relations = n.GetCollectionOfObjectValues<Relation>(Relation.CreateFromDiscriminatorValue).ToList(); } },
                {"terms", (o,n) => { (o as Set).Terms = n.GetCollectionOfObjectValues<Term>(Term.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Term>("children", Children);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<LocalizedName>("localizedNames", LocalizedNames);
            writer.WriteObjectValue<Group>("parentGroup", ParentGroup);
            writer.WriteCollectionOfObjectValues<KeyValue>("properties", Properties);
            writer.WriteCollectionOfObjectValues<Relation>("relations", Relations);
            writer.WriteCollectionOfObjectValues<Term>("terms", Terms);
        }
    }
}
