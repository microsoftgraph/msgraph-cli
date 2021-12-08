using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Xnpv {
    public class XnpvRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Dates { get; set; }
        public Json Rate { get; set; }
        public Json Values { get; set; }
        /// <summary>
        /// Instantiates a new xnpvRequestBody and sets the default values.
        /// </summary>
        public XnpvRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dates", (o,n) => { (o as XnpvRequestBody).Dates = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as XnpvRequestBody).Rate = n.GetObjectValue<Json>(); } },
                {"values", (o,n) => { (o as XnpvRequestBody).Values = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("dates", Dates);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
