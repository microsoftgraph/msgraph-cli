using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the organizationalBranding singleton.</summary>
    public class OrganizationalBranding : OrganizationalBrandingProperties, IParsable {
        /// <summary>Add different branding based on a locale.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OrganizationalBrandingLocalization> Localizations { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.OrganizationalBranding CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalBranding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"localizations", (o,n) => { (o as OrganizationalBranding).Localizations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OrganizationalBrandingLocalization>(ApiSdk.Models.Microsoft.Graph.OrganizationalBrandingLocalization.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OrganizationalBrandingLocalization>("localizations", Localizations);
        }
    }
}
