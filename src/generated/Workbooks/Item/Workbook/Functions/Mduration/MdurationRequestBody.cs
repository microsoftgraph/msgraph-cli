using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Mduration {
    public class MdurationRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json Coupon { get; set; }
        public Json Frequency { get; set; }
        public Json Maturity { get; set; }
        public Json Settlement { get; set; }
        public Json Yld { get; set; }
        /// <summary>
        /// Instantiates a new mdurationRequestBody and sets the default values.
        /// </summary>
        public MdurationRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as MdurationRequestBody).Basis = n.GetObjectValue<Json>(); } },
                {"coupon", (o,n) => { (o as MdurationRequestBody).Coupon = n.GetObjectValue<Json>(); } },
                {"frequency", (o,n) => { (o as MdurationRequestBody).Frequency = n.GetObjectValue<Json>(); } },
                {"maturity", (o,n) => { (o as MdurationRequestBody).Maturity = n.GetObjectValue<Json>(); } },
                {"settlement", (o,n) => { (o as MdurationRequestBody).Settlement = n.GetObjectValue<Json>(); } },
                {"yld", (o,n) => { (o as MdurationRequestBody).Yld = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("coupon", Coupon);
            writer.WriteObjectValue<Json>("frequency", Frequency);
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteObjectValue<Json>("yld", Yld);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
