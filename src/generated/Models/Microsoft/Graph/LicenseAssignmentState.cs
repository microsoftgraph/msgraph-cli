using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class LicenseAssignmentState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The id of the group that assigns this license. If the assignment is a direct-assigned license, this field will be Null. Read-Only.</summary>
        public string AssignedByGroup { get; set; }
        /// <summary>The service plans that are disabled in this assignment. Read-Only.</summary>
        public List<string> DisabledPlans { get; set; }
        /// <summary>License assignment failure error. If the license is assigned successfully, this field will be Null. Read-Only. Possible values: CountViolation, MutuallyExclusiveViolation, DependencyViolation, ProhibitedInUsageLocationViolation, UniquenessViolation, and Others. For more information on how to identify and resolve license assignment errors see here.</summary>
        public string Error { get; set; }
        /// <summary>The unique identifier for the SKU. Read-Only.</summary>
        public string SkuId { get; set; }
        /// <summary>Indicate the current state of this assignment. Read-Only. Possible values: Active, ActiveWithError, Disabled and Error.</summary>
        public string State { get; set; }
        /// <summary>
        /// Instantiates a new licenseAssignmentState and sets the default values.
        /// </summary>
        public LicenseAssignmentState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignedByGroup", (o,n) => { (o as LicenseAssignmentState).AssignedByGroup = n.GetStringValue(); } },
                {"disabledPlans", (o,n) => { (o as LicenseAssignmentState).DisabledPlans = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"error", (o,n) => { (o as LicenseAssignmentState).Error = n.GetStringValue(); } },
                {"skuId", (o,n) => { (o as LicenseAssignmentState).SkuId = n.GetStringValue(); } },
                {"state", (o,n) => { (o as LicenseAssignmentState).State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignedByGroup", AssignedByGroup);
            writer.WriteCollectionOfPrimitiveValues<string>("disabledPlans", DisabledPlans);
            writer.WriteStringValue("error", Error);
            writer.WriteStringValue("skuId", SkuId);
            writer.WriteStringValue("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
