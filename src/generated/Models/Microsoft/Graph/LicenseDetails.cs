using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class LicenseDetails : Entity, IParsable {
        /// <summary>Information about the service plans assigned with the license. Read-only, Not nullable</summary>
        public List<ServicePlanInfo> ServicePlans { get; set; }
        /// <summary>Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related SubscribedSku object. Read-only</summary>
        public string SkuId { get; set; }
        /// <summary>Unique SKU display name. Equal to the skuPartNumber on the related SubscribedSku object; for example: 'AAD_Premium'. Read-only</summary>
        public string SkuPartNumber { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"servicePlans", (o,n) => { (o as LicenseDetails).ServicePlans = n.GetCollectionOfObjectValues<ServicePlanInfo>().ToList(); } },
                {"skuId", (o,n) => { (o as LicenseDetails).SkuId = n.GetStringValue(); } },
                {"skuPartNumber", (o,n) => { (o as LicenseDetails).SkuPartNumber = n.GetStringValue(); } },
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
