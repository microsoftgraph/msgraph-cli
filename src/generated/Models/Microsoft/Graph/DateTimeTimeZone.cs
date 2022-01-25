using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DateTimeTimeZone : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.</summary>
        public string DateTime { get; set; }
        /// <summary>Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.</summary>
        public string TimeZone { get; set; }
        /// <summary>
        /// Instantiates a new dateTimeTimeZone and sets the default values.
        /// </summary>
        public DateTimeTimeZone() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dateTime", (o,n) => { (o as DateTimeTimeZone).DateTime = n.GetStringValue(); } },
                {"timeZone", (o,n) => { (o as DateTimeTimeZone).TimeZone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dateTime", DateTime);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
