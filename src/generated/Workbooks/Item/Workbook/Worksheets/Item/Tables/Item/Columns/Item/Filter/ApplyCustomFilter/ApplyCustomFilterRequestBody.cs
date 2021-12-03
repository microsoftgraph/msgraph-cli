using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.Filter.ApplyCustomFilter {
    public class ApplyCustomFilterRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Criteria1 { get; set; }
        public string Criteria2 { get; set; }
        public string Oper { get; set; }
        /// <summary>
        /// Instantiates a new applyCustomFilterRequestBody and sets the default values.
        /// </summary>
        public ApplyCustomFilterRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"criteria1", (o,n) => { (o as ApplyCustomFilterRequestBody).Criteria1 = n.GetStringValue(); } },
                {"criteria2", (o,n) => { (o as ApplyCustomFilterRequestBody).Criteria2 = n.GetStringValue(); } },
                {"oper", (o,n) => { (o as ApplyCustomFilterRequestBody).Oper = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("criteria1", Criteria1);
            writer.WriteStringValue("criteria2", Criteria2);
            writer.WriteStringValue("oper", Oper);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
