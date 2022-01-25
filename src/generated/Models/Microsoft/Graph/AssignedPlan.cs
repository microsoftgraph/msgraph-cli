using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AssignedPlan : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time at which the plan was assigned; for example: 2013-01-02T19:32:30Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? AssignedDateTime { get; set; }
        /// <summary>Condition of the capability assignment. The possible values are Enabled, Warning, Suspended, Deleted, LockedOut.</summary>
        public string CapabilityStatus { get; set; }
        /// <summary>The name of the service; for example, 'Exchange'.</summary>
        public string Service { get; set; }
        /// <summary>A GUID that identifies the service plan.</summary>
        public string ServicePlanId { get; set; }
        /// <summary>
        /// Instantiates a new assignedPlan and sets the default values.
        /// </summary>
        public AssignedPlan() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignedDateTime", (o,n) => { (o as AssignedPlan).AssignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"capabilityStatus", (o,n) => { (o as AssignedPlan).CapabilityStatus = n.GetStringValue(); } },
                {"service", (o,n) => { (o as AssignedPlan).Service = n.GetStringValue(); } },
                {"servicePlanId", (o,n) => { (o as AssignedPlan).ServicePlanId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("assignedDateTime", AssignedDateTime);
            writer.WriteStringValue("capabilityStatus", CapabilityStatus);
            writer.WriteStringValue("service", Service);
            writer.WriteStringValue("servicePlanId", ServicePlanId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
