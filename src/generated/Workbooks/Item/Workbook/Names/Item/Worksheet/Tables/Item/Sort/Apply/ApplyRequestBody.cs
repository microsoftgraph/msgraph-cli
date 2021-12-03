using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Sort.Apply {
    public class ApplyRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<WorkbookSortField> Fields { get; set; }
        public bool? MatchCase { get; set; }
        public string Method { get; set; }
        /// <summary>
        /// Instantiates a new applyRequestBody and sets the default values.
        /// </summary>
        public ApplyRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fields", (o,n) => { (o as ApplyRequestBody).Fields = n.GetCollectionOfObjectValues<WorkbookSortField>().ToList(); } },
                {"matchCase", (o,n) => { (o as ApplyRequestBody).MatchCase = n.GetBoolValue(); } },
                {"method", (o,n) => { (o as ApplyRequestBody).Method = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<WorkbookSortField>("fields", Fields);
            writer.WriteBoolValue("matchCase", MatchCase);
            writer.WriteStringValue("method", Method);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
