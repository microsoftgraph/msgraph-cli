using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.@Add {
    public class AddRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Address { get; set; }
        public bool? HasHeaders { get; set; }
        /// <summary>
        /// Instantiates a new addRequestBody and sets the default values.
        /// </summary>
        public AddRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"address", (o,n) => { (o as AddRequestBody).Address = n.GetStringValue(); } },
                {"hasHeaders", (o,n) => { (o as AddRequestBody).HasHeaders = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteBoolValue("hasHeaders", HasHeaders);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
