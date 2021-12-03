using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.SeriesSum {
    public class SeriesSumRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Coefficients { get; set; }
        public Json M { get; set; }
        public Json N { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new seriesSumRequestBody and sets the default values.
        /// </summary>
        public SeriesSumRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"coefficients", (o,n) => { (o as SeriesSumRequestBody).Coefficients = n.GetObjectValue<Json>(); } },
                {"m", (o,n) => { (o as SeriesSumRequestBody).M = n.GetObjectValue<Json>(); } },
                {"n", (o,n) => { (o as SeriesSumRequestBody).N = n.GetObjectValue<Json>(); } },
                {"x", (o,n) => { (o as SeriesSumRequestBody).X = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("coefficients", Coefficients);
            writer.WriteObjectValue<Json>("m", M);
            writer.WriteObjectValue<Json>("n", N);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
