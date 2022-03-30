using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessRoot : Entity, IParsable {
        /// <summary>Read-only. Nullable. Returns a collection of the specified named locations.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.NamedLocation> NamedLocations { get; set; }
        /// <summary>Read-only. Nullable. Returns a collection of the specified Conditional Access (CA) policies.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ConditionalAccessPolicy> Policies { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ConditionalAccessRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"namedLocations", (o,n) => { (o as ConditionalAccessRoot).NamedLocations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.NamedLocation>(ApiSdk.Models.Microsoft.Graph.NamedLocation.CreateFromDiscriminatorValue).ToList(); } },
                {"policies", (o,n) => { (o as ConditionalAccessRoot).Policies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ConditionalAccessPolicy>(ApiSdk.Models.Microsoft.Graph.ConditionalAccessPolicy.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.NamedLocation>("namedLocations", NamedLocations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ConditionalAccessPolicy>("policies", Policies);
        }
    }
}
