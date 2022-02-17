using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.If {
    public class IfRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json LogicalTest { get; set; }
        public Json ValueIfFalse { get; set; }
        public Json ValueIfTrue { get; set; }
        /// <summary>
        /// Instantiates a new ifRequestBody and sets the default values.
        /// </summary>
        public IfRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"logicalTest", (o,n) => { (o as IfRequestBody).LogicalTest = n.GetObjectValue<Json>(); } },
                {"valueIfFalse", (o,n) => { (o as IfRequestBody).ValueIfFalse = n.GetObjectValue<Json>(); } },
                {"valueIfTrue", (o,n) => { (o as IfRequestBody).ValueIfTrue = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("logicalTest", LogicalTest);
            writer.WriteObjectValue<Json>("valueIfFalse", ValueIfFalse);
            writer.WriteObjectValue<Json>("valueIfTrue", ValueIfTrue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
