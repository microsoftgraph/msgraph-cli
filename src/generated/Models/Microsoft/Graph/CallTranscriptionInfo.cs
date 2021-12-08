using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class CallTranscriptionInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The state modified time in UTC.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Possible values are: notStarted, active, inactive.</summary>
        public CallTranscriptionState? State { get; set; }
        /// <summary>
        /// Instantiates a new callTranscriptionInfo and sets the default values.
        /// </summary>
        public CallTranscriptionInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"lastModifiedDateTime", (o,n) => { (o as CallTranscriptionInfo).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", (o,n) => { (o as CallTranscriptionInfo).State = n.GetEnumValue<CallTranscriptionState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<CallTranscriptionState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
