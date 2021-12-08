using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceManagementTroubleshootingEvent : Entity, IParsable {
        /// <summary>Id used for tracing the failure in the service.</summary>
        public string CorrelationId { get; set; }
        /// <summary>Time when the event occurred .</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"correlationId", (o,n) => { (o as DeviceManagementTroubleshootingEvent).CorrelationId = n.GetStringValue(); } },
                {"eventDateTime", (o,n) => { (o as DeviceManagementTroubleshootingEvent).EventDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
        }
    }
}
