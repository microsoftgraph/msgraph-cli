using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.AccrInt {
    public class AccrIntRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json CalcMethod { get; set; }
        public Json FirstInterest { get; set; }
        public Json Frequency { get; set; }
        public Json Issue { get; set; }
        public Json Par { get; set; }
        public Json Rate { get; set; }
        public Json Settlement { get; set; }
        /// <summary>
        /// Instantiates a new accrIntRequestBody and sets the default values.
        /// </summary>
        public AccrIntRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as AccrIntRequestBody).Basis = n.GetObjectValue<Json>(); } },
                {"calcMethod", (o,n) => { (o as AccrIntRequestBody).CalcMethod = n.GetObjectValue<Json>(); } },
                {"firstInterest", (o,n) => { (o as AccrIntRequestBody).FirstInterest = n.GetObjectValue<Json>(); } },
                {"frequency", (o,n) => { (o as AccrIntRequestBody).Frequency = n.GetObjectValue<Json>(); } },
                {"issue", (o,n) => { (o as AccrIntRequestBody).Issue = n.GetObjectValue<Json>(); } },
                {"par", (o,n) => { (o as AccrIntRequestBody).Par = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as AccrIntRequestBody).Rate = n.GetObjectValue<Json>(); } },
                {"settlement", (o,n) => { (o as AccrIntRequestBody).Settlement = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("calcMethod", CalcMethod);
            writer.WriteObjectValue<Json>("firstInterest", FirstInterest);
            writer.WriteObjectValue<Json>("frequency", Frequency);
            writer.WriteObjectValue<Json>("issue", Issue);
            writer.WriteObjectValue<Json>("par", Par);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
