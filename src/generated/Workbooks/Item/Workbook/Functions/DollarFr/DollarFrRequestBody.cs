using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.DollarFr {
    public class DollarFrRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json DecimalDollar { get; set; }
        public Json Fraction { get; set; }
        /// <summary>
        /// Instantiates a new dollarFrRequestBody and sets the default values.
        /// </summary>
        public DollarFrRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"decimalDollar", (o,n) => { (o as DollarFrRequestBody).DecimalDollar = n.GetObjectValue<Json>(); } },
                {"fraction", (o,n) => { (o as DollarFrRequestBody).Fraction = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("decimalDollar", DecimalDollar);
            writer.WriteObjectValue<Json>("fraction", Fraction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
