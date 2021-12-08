using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.F_Inv {
    public class F_InvRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json DegFreedom1 { get; set; }
        public Json DegFreedom2 { get; set; }
        public Json Probability { get; set; }
        /// <summary>
        /// Instantiates a new f_InvRequestBody and sets the default values.
        /// </summary>
        public F_InvRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"degFreedom1", (o,n) => { (o as F_InvRequestBody).DegFreedom1 = n.GetObjectValue<Json>(); } },
                {"degFreedom2", (o,n) => { (o as F_InvRequestBody).DegFreedom2 = n.GetObjectValue<Json>(); } },
                {"probability", (o,n) => { (o as F_InvRequestBody).Probability = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("degFreedom1", DegFreedom1);
            writer.WriteObjectValue<Json>("degFreedom2", DegFreedom2);
            writer.WriteObjectValue<Json>("probability", Probability);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
