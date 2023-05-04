using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PrincipalResourceMembershipsScope : AccessReviewScope, IParsable {
        /// <summary>Defines the scopes of the principals whose access to resources are reviewed in the access review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewScope>? PrincipalScopes { get; set; }
#nullable restore
#else
        public List<AccessReviewScope> PrincipalScopes { get; set; }
#endif
        /// <summary>Defines the scopes of the resources for which access is reviewed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewScope>? ResourceScopes { get; set; }
#nullable restore
#else
        public List<AccessReviewScope> ResourceScopes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new PrincipalResourceMembershipsScope and sets the default values.
        /// </summary>
        public PrincipalResourceMembershipsScope() : base() {
            OdataType = "#microsoft.graph.principalResourceMembershipsScope";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrincipalResourceMembershipsScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrincipalResourceMembershipsScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"principalScopes", n => { PrincipalScopes = n.GetCollectionOfObjectValues<AccessReviewScope>(AccessReviewScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resourceScopes", n => { ResourceScopes = n.GetCollectionOfObjectValues<AccessReviewScope>(AccessReviewScope.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessReviewScope>("principalScopes", PrincipalScopes);
            writer.WriteCollectionOfObjectValues<AccessReviewScope>("resourceScopes", ResourceScopes);
        }
    }
}
