using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.TermStore {
    public class Relation : Entity, IParsable {
        /// <summary>The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].</summary>
        public ApiSdk.Models.Microsoft.Graph.TermStore.Term FromTerm { get; set; }
        /// <summary>The type of relation. Possible values are: pin, reuse.</summary>
        public RelationType? Relationship { get; set; }
        /// <summary>The [set] in which the relation is relevant.</summary>
        public ApiSdk.Models.Microsoft.Graph.TermStore.Set Set { get; set; }
        /// <summary>The to [term] of the relation. The term to which the relationship is defined.</summary>
        public ApiSdk.Models.Microsoft.Graph.TermStore.Term ToTerm { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.TermStore.Relation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Relation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"fromTerm", (o,n) => { (o as Relation).FromTerm = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Term>(ApiSdk.Models.Microsoft.Graph.TermStore.Term.CreateFromDiscriminatorValue); } },
                {"relationship", (o,n) => { (o as Relation).Relationship = n.GetEnumValue<RelationType>(); } },
                {"set", (o,n) => { (o as Relation).Set = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Set>(ApiSdk.Models.Microsoft.Graph.TermStore.Set.CreateFromDiscriminatorValue); } },
                {"toTerm", (o,n) => { (o as Relation).ToTerm = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Term>(ApiSdk.Models.Microsoft.Graph.TermStore.Term.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Term>("fromTerm", FromTerm);
            writer.WriteEnumValue<RelationType>("relationship", Relationship);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Set>("set", Set);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Term>("toTerm", ToTerm);
        }
    }
}
