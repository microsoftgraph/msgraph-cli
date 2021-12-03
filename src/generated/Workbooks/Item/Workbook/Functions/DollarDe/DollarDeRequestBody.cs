using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.DollarDe {
    public class DollarDeRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Fraction { get; set; }
        public Json FractionalDollar { get; set; }
        /// <summary>
        /// Instantiates a new dollarDeRequestBody and sets the default values.
        /// </summary>
        public DollarDeRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fraction", (o,n) => { (o as DollarDeRequestBody).Fraction = n.GetObjectValue<Json>(); } },
                {"fractionalDollar", (o,n) => { (o as DollarDeRequestBody).FractionalDollar = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fraction", Fraction);
            writer.WriteObjectValue<Json>("fractionalDollar", FractionalDollar);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
