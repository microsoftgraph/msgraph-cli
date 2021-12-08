using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Convert {
    public class ConvertRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json FromUnit { get; set; }
        public Json Number { get; set; }
        public Json ToUnit { get; set; }
        /// <summary>
        /// Instantiates a new convertRequestBody and sets the default values.
        /// </summary>
        public ConvertRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fromUnit", (o,n) => { (o as ConvertRequestBody).FromUnit = n.GetObjectValue<Json>(); } },
                {"number", (o,n) => { (o as ConvertRequestBody).Number = n.GetObjectValue<Json>(); } },
                {"toUnit", (o,n) => { (o as ConvertRequestBody).ToUnit = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fromUnit", FromUnit);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("toUnit", ToUnit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
