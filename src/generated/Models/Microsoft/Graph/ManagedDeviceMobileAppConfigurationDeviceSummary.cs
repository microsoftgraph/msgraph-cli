using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedDeviceMobileAppConfigurationDeviceSummary : Entity, IParsable {
        /// <summary>Version of the policy for that overview</summary>
        public int? ConfigurationVersion { get; set; }
        /// <summary>Number of error devices</summary>
        public int? ErrorCount { get; set; }
        /// <summary>Number of failed devices</summary>
        public int? FailedCount { get; set; }
        /// <summary>Last update time</summary>
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableCount { get; set; }
        /// <summary>Number of pending devices</summary>
        public int? PendingCount { get; set; }
        /// <summary>Number of succeeded devices</summary>
        public int? SuccessCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configurationVersion", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceSummary).ConfigurationVersion = n.GetIntValue(); } },
                {"errorCount", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceSummary).ErrorCount = n.GetIntValue(); } },
                {"failedCount", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceSummary).FailedCount = n.GetIntValue(); } },
                {"lastUpdateDateTime", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceSummary).LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"notApplicableCount", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceSummary).NotApplicableCount = n.GetIntValue(); } },
                {"pendingCount", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceSummary).PendingCount = n.GetIntValue(); } },
                {"successCount", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceSummary).SuccessCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("configurationVersion", ConfigurationVersion);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("failedCount", FailedCount);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("pendingCount", PendingCount);
            writer.WriteIntValue("successCount", SuccessCount);
        }
    }
}
