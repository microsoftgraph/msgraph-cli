using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SubscribedSku : Entity, IParsable {
        /// <summary>For example, 'User' or 'Company'.</summary>
        public string AppliesTo { get; set; }
        /// <summary>Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut. The capabilityStatus is Enabled if the prepaidUnits property has at least 1 unit that is enabled, and LockedOut if the customer cancelled their subscription.</summary>
        public string CapabilityStatus { get; set; }
        /// <summary>The number of licenses that have been assigned.</summary>
        public int? ConsumedUnits { get; set; }
        /// <summary>Information about the number and status of prepaid licenses.</summary>
        public LicenseUnitsDetail PrepaidUnits { get; set; }
        /// <summary>Information about the service plans that are available with the SKU. Not nullable</summary>
        public List<ServicePlanInfo> ServicePlans { get; set; }
        /// <summary>The unique identifier (GUID) for the service SKU.</summary>
        public string SkuId { get; set; }
        /// <summary>The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'. To get a list of commercial subscriptions that an organization has acquired, see List subscribedSkus.</summary>
        public string SkuPartNumber { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appliesTo", (o,n) => { (o as SubscribedSku).AppliesTo = n.GetStringValue(); } },
                {"capabilityStatus", (o,n) => { (o as SubscribedSku).CapabilityStatus = n.GetStringValue(); } },
                {"consumedUnits", (o,n) => { (o as SubscribedSku).ConsumedUnits = n.GetIntValue(); } },
                {"prepaidUnits", (o,n) => { (o as SubscribedSku).PrepaidUnits = n.GetObjectValue<LicenseUnitsDetail>(); } },
                {"servicePlans", (o,n) => { (o as SubscribedSku).ServicePlans = n.GetCollectionOfObjectValues<ServicePlanInfo>().ToList(); } },
                {"skuId", (o,n) => { (o as SubscribedSku).SkuId = n.GetStringValue(); } },
                {"skuPartNumber", (o,n) => { (o as SubscribedSku).SkuPartNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appliesTo", AppliesTo);
            writer.WriteStringValue("capabilityStatus", CapabilityStatus);
            writer.WriteIntValue("consumedUnits", ConsumedUnits);
            writer.WriteObjectValue<LicenseUnitsDetail>("prepaidUnits", PrepaidUnits);
            writer.WriteCollectionOfObjectValues<ServicePlanInfo>("servicePlans", ServicePlans);
            writer.WriteStringValue("skuId", SkuId);
            writer.WriteStringValue("skuPartNumber", SkuPartNumber);
        }
    }
}
