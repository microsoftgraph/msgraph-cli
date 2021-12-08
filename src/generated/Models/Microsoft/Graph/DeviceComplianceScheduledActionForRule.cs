using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceComplianceScheduledActionForRule : Entity, IParsable {
        /// <summary>Name of the rule which this scheduled action applies to. Currently scheduled actions are created per policy instead of per rule, thus RuleName is always set to default value PasswordRequired.</summary>
        public string RuleName { get; set; }
        /// <summary>The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.</summary>
        public List<DeviceComplianceActionItem> ScheduledActionConfigurations { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"ruleName", (o,n) => { (o as DeviceComplianceScheduledActionForRule).RuleName = n.GetStringValue(); } },
                {"scheduledActionConfigurations", (o,n) => { (o as DeviceComplianceScheduledActionForRule).ScheduledActionConfigurations = n.GetCollectionOfObjectValues<DeviceComplianceActionItem>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("ruleName", RuleName);
            writer.WriteCollectionOfObjectValues<DeviceComplianceActionItem>("scheduledActionConfigurations", ScheduledActionConfigurations);
        }
    }
}
