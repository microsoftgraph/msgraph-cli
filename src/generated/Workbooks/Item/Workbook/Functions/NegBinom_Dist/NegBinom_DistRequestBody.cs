using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.NegBinom_Dist {
    public class NegBinom_DistRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cumulative { get; set; }
        public Json NumberF { get; set; }
        public Json NumberS { get; set; }
        public Json ProbabilityS { get; set; }
        /// <summary>
        /// Instantiates a new negBinom_DistRequestBody and sets the default values.
        /// </summary>
        public NegBinom_DistRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cumulative", (o,n) => { (o as NegBinom_DistRequestBody).Cumulative = n.GetObjectValue<Json>(); } },
                {"numberF", (o,n) => { (o as NegBinom_DistRequestBody).NumberF = n.GetObjectValue<Json>(); } },
                {"numberS", (o,n) => { (o as NegBinom_DistRequestBody).NumberS = n.GetObjectValue<Json>(); } },
                {"probabilityS", (o,n) => { (o as NegBinom_DistRequestBody).ProbabilityS = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("numberF", NumberF);
            writer.WriteObjectValue<Json>("numberS", NumberS);
            writer.WriteObjectValue<Json>("probabilityS", ProbabilityS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
