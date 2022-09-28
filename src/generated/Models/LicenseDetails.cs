using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class LicenseDetails : Entity, IParsable {
        /// <summary>Information about the service plans assigned with the license. Read-only, Not nullable</summary>
        public List<ServicePlanInfo> ServicePlans { get; set; }
        /// <summary>Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related SubscribedSku object. Read-only</summary>
        public string SkuId { get; set; }
        /// <summary>Unique SKU display name. Equal to the skuPartNumber on the related SubscribedSku object; for example: &apos;AAD_Premium&apos;. Read-only</summary>
        public string SkuPartNumber { get; set; }
        /// <summary>
        /// Instantiates a new licenseDetails and sets the default values.
        /// </summary>
        public LicenseDetails() : base() {
            OdataType = "#microsoft.graph.licenseDetails";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new LicenseDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LicenseDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"servicePlans", n => { ServicePlans = n.GetCollectionOfObjectValues<ServicePlanInfo>(ServicePlanInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"skuId", n => { SkuId = n.GetStringValue(); } },
                {"skuPartNumber", n => { SkuPartNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ServicePlanInfo>("servicePlans", ServicePlans);
            writer.WriteStringValue("skuId", SkuId);
            writer.WriteStringValue("skuPartNumber", SkuPartNumber);
        }
    }
}
