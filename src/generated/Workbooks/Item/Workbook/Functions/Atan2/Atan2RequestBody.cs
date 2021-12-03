using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Atan2 {
    public class Atan2RequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json XNum { get; set; }
        public Json YNum { get; set; }
        /// <summary>
        /// Instantiates a new atan2RequestBody and sets the default values.
        /// </summary>
        public Atan2RequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"xNum", (o,n) => { (o as Atan2RequestBody).XNum = n.GetObjectValue<Json>(); } },
                {"yNum", (o,n) => { (o as Atan2RequestBody).YNum = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("xNum", XNum);
            writer.WriteObjectValue<Json>("yNum", YNum);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
