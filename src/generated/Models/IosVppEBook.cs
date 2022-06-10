using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class IosVppEBook : ManagedEBook, IParsable {
        /// <summary>The Apple ID associated with Vpp token.</summary>
        public string AppleId { get; set; }
        /// <summary>Genres.</summary>
        public List<string> Genres { get; set; }
        /// <summary>Language.</summary>
        public string Language { get; set; }
        /// <summary>Seller.</summary>
        public string Seller { get; set; }
        /// <summary>Total license count.</summary>
        public int? TotalLicenseCount { get; set; }
        /// <summary>Used license count.</summary>
        public int? UsedLicenseCount { get; set; }
        /// <summary>The Vpp token&apos;s organization name.</summary>
        public string VppOrganizationName { get; set; }
        /// <summary>The Vpp token ID.</summary>
        public string VppTokenId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosVppEBook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosVppEBook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleId", n => { AppleId = n.GetStringValue(); } },
                {"genres", n => { Genres = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"seller", n => { Seller = n.GetStringValue(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                {"vppOrganizationName", n => { VppOrganizationName = n.GetStringValue(); } },
                {"vppTokenId", n => { VppTokenId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteCollectionOfPrimitiveValues<string>("genres", Genres);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("seller", Seller);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteStringValue("vppOrganizationName", VppOrganizationName);
            writer.WriteStringValue("vppTokenId", VppTokenId);
        }
    }
}
