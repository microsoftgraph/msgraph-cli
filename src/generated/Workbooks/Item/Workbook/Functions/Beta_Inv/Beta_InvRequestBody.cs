using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Beta_Inv {
    public class Beta_InvRequestBody : IParsable {
        public Json A { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Alpha { get; set; }
        public Json B { get; set; }
        public Json Beta { get; set; }
        public Json Probability { get; set; }
        /// <summary>
        /// Instantiates a new beta_InvRequestBody and sets the default values.
        /// </summary>
        public Beta_InvRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"a", (o,n) => { (o as Beta_InvRequestBody).A = n.GetObjectValue<Json>(); } },
                {"alpha", (o,n) => { (o as Beta_InvRequestBody).Alpha = n.GetObjectValue<Json>(); } },
                {"b", (o,n) => { (o as Beta_InvRequestBody).B = n.GetObjectValue<Json>(); } },
                {"beta", (o,n) => { (o as Beta_InvRequestBody).Beta = n.GetObjectValue<Json>(); } },
                {"probability", (o,n) => { (o as Beta_InvRequestBody).Probability = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("a", A);
            writer.WriteObjectValue<Json>("alpha", Alpha);
            writer.WriteObjectValue<Json>("b", B);
            writer.WriteObjectValue<Json>("beta", Beta);
            writer.WriteObjectValue<Json>("probability", Probability);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
