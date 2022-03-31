using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.TermStore {
    public class Term : Entity, IParsable {
        /// <summary>Children of current term.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TermStore.Term> Children { get; set; }
        /// <summary>Date and time of term creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description about term that is dependent on the languageTag.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TermStore.LocalizedDescription> Descriptions { get; set; }
        /// <summary>Label metadata for a term.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TermStore.LocalizedLabel> Labels { get; set; }
        /// <summary>Last date and time of term modification. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Collection of properties on the term.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.KeyValue> Properties { get; set; }
        /// <summary>To indicate which terms are related to the current term as either pinned or reused.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TermStore.Relation> Relations { get; set; }
        /// <summary>The [set] in which the term is created.</summary>
        public ApiSdk.Models.Microsoft.Graph.TermStore.Set Set { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.TermStore.Term CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Term();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"children", (o,n) => { (o as Term).Children = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermStore.Term>(ApiSdk.Models.Microsoft.Graph.TermStore.Term.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as Term).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"descriptions", (o,n) => { (o as Term).Descriptions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermStore.LocalizedDescription>(ApiSdk.Models.Microsoft.Graph.TermStore.LocalizedDescription.CreateFromDiscriminatorValue).ToList(); } },
                {"labels", (o,n) => { (o as Term).Labels = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermStore.LocalizedLabel>(ApiSdk.Models.Microsoft.Graph.TermStore.LocalizedLabel.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Term).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"properties", (o,n) => { (o as Term).Properties = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.KeyValue>(ApiSdk.Models.Microsoft.Graph.KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"relations", (o,n) => { (o as Term).Relations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermStore.Relation>(ApiSdk.Models.Microsoft.Graph.TermStore.Relation.CreateFromDiscriminatorValue).ToList(); } },
                {"set", (o,n) => { (o as Term).Set = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Set>(ApiSdk.Models.Microsoft.Graph.TermStore.Set.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermStore.Term>("children", Children);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermStore.LocalizedDescription>("descriptions", Descriptions);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermStore.LocalizedLabel>("labels", Labels);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.KeyValue>("properties", Properties);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TermStore.Relation>("relations", Relations);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Set>("set", Set);
        }
    }
}
