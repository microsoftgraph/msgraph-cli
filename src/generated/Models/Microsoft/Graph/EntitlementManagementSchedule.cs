using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EntitlementManagementSchedule : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ExpirationPattern Expiration { get; set; }
        public PatternedRecurrence Recurrence { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new entitlementManagementSchedule and sets the default values.
        /// </summary>
        public EntitlementManagementSchedule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expiration", (o,n) => { (o as EntitlementManagementSchedule).Expiration = n.GetObjectValue<ExpirationPattern>(); } },
                {"recurrence", (o,n) => { (o as EntitlementManagementSchedule).Recurrence = n.GetObjectValue<PatternedRecurrence>(); } },
                {"startDateTime", (o,n) => { (o as EntitlementManagementSchedule).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ExpirationPattern>("expiration", Expiration);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
