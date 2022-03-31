using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EntitlementManagementSchedule : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>When the access should expire.</summary>
        public ApiSdk.Models.Microsoft.Graph.ExpirationPattern Expiration { get; set; }
        /// <summary>For recurring access. Not used at present.</summary>
        public ApiSdk.Models.Microsoft.Graph.PatternedRecurrence Recurrence { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new entitlementManagementSchedule and sets the default values.
        /// </summary>
        public EntitlementManagementSchedule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagementSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expiration", (o,n) => { (o as EntitlementManagementSchedule).Expiration = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ExpirationPattern>(ApiSdk.Models.Microsoft.Graph.ExpirationPattern.CreateFromDiscriminatorValue); } },
                {"recurrence", (o,n) => { (o as EntitlementManagementSchedule).Recurrence = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PatternedRecurrence>(ApiSdk.Models.Microsoft.Graph.PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"startDateTime", (o,n) => { (o as EntitlementManagementSchedule).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ExpirationPattern>("expiration", Expiration);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
