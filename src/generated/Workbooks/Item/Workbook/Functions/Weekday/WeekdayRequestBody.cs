using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Weekday {
    public class WeekdayRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json ReturnType { get; set; }
        public Json SerialNumber { get; set; }
        /// <summary>
        /// Instantiates a new weekdayRequestBody and sets the default values.
        /// </summary>
        public WeekdayRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"returnType", (o,n) => { (o as WeekdayRequestBody).ReturnType = n.GetObjectValue<Json>(); } },
                {"serialNumber", (o,n) => { (o as WeekdayRequestBody).SerialNumber = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("returnType", ReturnType);
            writer.WriteObjectValue<Json>("serialNumber", SerialNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
