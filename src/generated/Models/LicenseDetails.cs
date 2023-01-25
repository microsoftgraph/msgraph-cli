using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class LicenseDetails : Entity, IParsable {
        /// <summary>Information about the service plans assigned with the license. Read-only, Not nullable</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServicePlanInfo>? ServicePlans { get; set; }
#nullable restore
#else
        public List<ServicePlanInfo> ServicePlans { get; set; }
#endif
        /// <summary>Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related SubscribedSku object. Read-only</summary>
        public Guid? SkuId { get; set; }
        /// <summary>Unique SKU display name. Equal to the skuPartNumber on the related SubscribedSku object; for example: &apos;AAD_Premium&apos;. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuPartNumber { get; set; }
#nullable restore
#else
        public string SkuPartNumber { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"skuId", n => { SkuId = n.GetGuidValue(); } },
                {"skuPartNumber", n => { SkuPartNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ServicePlanInfo>("servicePlans", ServicePlans);
            writer.WriteGuidValue("skuId", SkuId);
            writer.WriteStringValue("skuPartNumber", SkuPartNumber);
        }
    }
}
