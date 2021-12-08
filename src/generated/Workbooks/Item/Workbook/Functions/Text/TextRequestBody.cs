using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Text {
    public class TextRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json FormatText { get; set; }
        public Json Value { get; set; }
        /// <summary>
        /// Instantiates a new textRequestBody and sets the default values.
        /// </summary>
        public TextRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"formatText", (o,n) => { (o as TextRequestBody).FormatText = n.GetObjectValue<Json>(); } },
                {"value", (o,n) => { (o as TextRequestBody).Value = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("formatText", FormatText);
            writer.WriteObjectValue<Json>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
