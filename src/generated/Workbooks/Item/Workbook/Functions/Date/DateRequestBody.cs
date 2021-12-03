using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Date {
    public class DateRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Day { get; set; }
        public Json Month { get; set; }
        public Json Year { get; set; }
        /// <summary>
        /// Instantiates a new dateRequestBody and sets the default values.
        /// </summary>
        public DateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"day", (o,n) => { (o as DateRequestBody).Day = n.GetObjectValue<Json>(); } },
                {"month", (o,n) => { (o as DateRequestBody).Month = n.GetObjectValue<Json>(); } },
                {"year", (o,n) => { (o as DateRequestBody).Year = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("day", Day);
            writer.WriteObjectValue<Json>("month", Month);
            writer.WriteObjectValue<Json>("year", Year);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
