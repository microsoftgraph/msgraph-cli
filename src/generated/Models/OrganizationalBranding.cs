using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class OrganizationalBranding : OrganizationalBrandingProperties, IParsable {
        /// <summary>Add different branding based on a locale.</summary>
        public List<OrganizationalBrandingLocalization> Localizations { get; set; }
        /// <summary>
        /// Instantiates a new OrganizationalBranding and sets the default values.
        /// </summary>
        public OrganizationalBranding() : base() {
            OdataType = "#microsoft.graph.organizationalBranding";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OrganizationalBranding CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalBranding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"localizations", n => { Localizations = n.GetCollectionOfObjectValues<OrganizationalBrandingLocalization>(OrganizationalBrandingLocalization.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OrganizationalBrandingLocalization>("localizations", Localizations);
        }
    }
}
