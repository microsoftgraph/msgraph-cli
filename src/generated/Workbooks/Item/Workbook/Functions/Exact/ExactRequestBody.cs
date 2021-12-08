using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Exact {
    public class ExactRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Text1 { get; set; }
        public Json Text2 { get; set; }
        /// <summary>
        /// Instantiates a new exactRequestBody and sets the default values.
        /// </summary>
        public ExactRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"text1", (o,n) => { (o as ExactRequestBody).Text1 = n.GetObjectValue<Json>(); } },
                {"text2", (o,n) => { (o as ExactRequestBody).Text2 = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("text1", Text1);
            writer.WriteObjectValue<Json>("text2", Text2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
