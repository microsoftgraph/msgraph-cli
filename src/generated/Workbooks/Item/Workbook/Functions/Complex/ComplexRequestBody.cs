using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Complex {
    public class ComplexRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json INum { get; set; }
        public Json RealNum { get; set; }
        public Json Suffix { get; set; }
        /// <summary>
        /// Instantiates a new complexRequestBody and sets the default values.
        /// </summary>
        public ComplexRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"iNum", (o,n) => { (o as ComplexRequestBody).INum = n.GetObjectValue<Json>(); } },
                {"realNum", (o,n) => { (o as ComplexRequestBody).RealNum = n.GetObjectValue<Json>(); } },
                {"suffix", (o,n) => { (o as ComplexRequestBody).Suffix = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("iNum", INum);
            writer.WriteObjectValue<Json>("realNum", RealNum);
            writer.WriteObjectValue<Json>("suffix", Suffix);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
