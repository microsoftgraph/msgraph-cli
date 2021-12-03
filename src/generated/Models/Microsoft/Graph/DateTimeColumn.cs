using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DateTimeColumn : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How the value should be presented in the UX. Must be one of default, friendly, or standard. See below for more details. If unspecified, treated as default.</summary>
        public string DisplayAs { get; set; }
        /// <summary>Indicates whether the value should be presented as a date only or a date and time. Must be one of dateOnly or dateTime</summary>
        public string Format { get; set; }
        /// <summary>
        /// Instantiates a new dateTimeColumn and sets the default values.
        /// </summary>
        public DateTimeColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayAs", (o,n) => { (o as DateTimeColumn).DisplayAs = n.GetStringValue(); } },
                {"format", (o,n) => { (o as DateTimeColumn).Format = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayAs", DisplayAs);
            writer.WriteStringValue("format", Format);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
