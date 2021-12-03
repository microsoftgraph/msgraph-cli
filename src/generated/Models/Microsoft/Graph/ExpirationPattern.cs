using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ExpirationPattern : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.</summary>
        public string Duration { get; set; }
        /// <summary>Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The requestor's desired expiration pattern type.</summary>
        public ExpirationPatternType? Type { get; set; }
        /// <summary>
        /// Instantiates a new expirationPattern and sets the default values.
        /// </summary>
        public ExpirationPattern() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"duration", (o,n) => { (o as ExpirationPattern).Duration = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as ExpirationPattern).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"type", (o,n) => { (o as ExpirationPattern).Type = n.GetEnumValue<ExpirationPatternType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("duration", Duration);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteEnumValue<ExpirationPatternType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
