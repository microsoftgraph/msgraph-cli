using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.TermStore {
    public class Relation : Entity, IParsable {
        /// <summary>The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Term? FromTerm { get; set; }
#nullable restore
#else
        public Term FromTerm { get; set; }
#endif
        /// <summary>The type of relation. Possible values are: pin, reuse.</summary>
        public RelationType? Relationship { get; set; }
        /// <summary>The [set] in which the relation is relevant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.TermStore.Set? Set { get; set; }
#nullable restore
#else
        public ApiSdk.Models.TermStore.Set Set { get; set; }
#endif
        /// <summary>The to [term] of the relation. The term to which the relationship is defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Term? ToTerm { get; set; }
#nullable restore
#else
        public Term ToTerm { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new Relation CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new Relation CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Relation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fromTerm", n => { FromTerm = n.GetObjectValue<Term>(Term.CreateFromDiscriminatorValue); } },
                {"relationship", n => { Relationship = n.GetEnumValue<RelationType>(); } },
                {"set", n => { Set = n.GetObjectValue<ApiSdk.Models.TermStore.Set>(ApiSdk.Models.TermStore.Set.CreateFromDiscriminatorValue); } },
                {"toTerm", n => { ToTerm = n.GetObjectValue<Term>(Term.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Term>("fromTerm", FromTerm);
            writer.WriteEnumValue<RelationType>("relationship", Relationship);
            writer.WriteObjectValue<ApiSdk.Models.TermStore.Set>("set", Set);
            writer.WriteObjectValue<Term>("toTerm", ToTerm);
        }
    }
}
