using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.DeviceManagement.DeviceCompliancePolicies.Item.ScheduleActionsForRules {
    /// <summary>Provides operations to call the scheduleActionsForRules method.</summary>
    public class ScheduleActionsForRulesRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<DeviceComplianceScheduledActionForRule> DeviceComplianceScheduledActionForRules { get; set; }
        /// <summary>
        /// Instantiates a new scheduleActionsForRulesRequestBody and sets the default values.
        /// </summary>
        public ScheduleActionsForRulesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.DeviceManagement.DeviceCompliancePolicies.Item.ScheduleActionsForRules.ScheduleActionsForRulesRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScheduleActionsForRulesRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceComplianceScheduledActionForRules", (o,n) => { (o as ScheduleActionsForRulesRequestBody).DeviceComplianceScheduledActionForRules = n.GetCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>(DeviceComplianceScheduledActionForRule.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>("deviceComplianceScheduledActionForRules", DeviceComplianceScheduledActionForRules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
