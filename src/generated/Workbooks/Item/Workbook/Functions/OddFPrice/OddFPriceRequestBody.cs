using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.OddFPrice {
    public class OddFPriceRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json FirstCoupon { get; set; }
        public Json Frequency { get; set; }
        public Json Issue { get; set; }
        public Json Maturity { get; set; }
        public Json Rate { get; set; }
        public Json Redemption { get; set; }
        public Json Settlement { get; set; }
        public Json Yld { get; set; }
        /// <summary>
        /// Instantiates a new oddFPriceRequestBody and sets the default values.
        /// </summary>
        public OddFPriceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as OddFPriceRequestBody).Basis = n.GetObjectValue<Json>(); } },
                {"firstCoupon", (o,n) => { (o as OddFPriceRequestBody).FirstCoupon = n.GetObjectValue<Json>(); } },
                {"frequency", (o,n) => { (o as OddFPriceRequestBody).Frequency = n.GetObjectValue<Json>(); } },
                {"issue", (o,n) => { (o as OddFPriceRequestBody).Issue = n.GetObjectValue<Json>(); } },
                {"maturity", (o,n) => { (o as OddFPriceRequestBody).Maturity = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as OddFPriceRequestBody).Rate = n.GetObjectValue<Json>(); } },
                {"redemption", (o,n) => { (o as OddFPriceRequestBody).Redemption = n.GetObjectValue<Json>(); } },
                {"settlement", (o,n) => { (o as OddFPriceRequestBody).Settlement = n.GetObjectValue<Json>(); } },
                {"yld", (o,n) => { (o as OddFPriceRequestBody).Yld = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("firstCoupon", FirstCoupon);
            writer.WriteObjectValue<Json>("frequency", Frequency);
            writer.WriteObjectValue<Json>("issue", Issue);
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("redemption", Redemption);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteObjectValue<Json>("yld", Yld);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
