using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Dcount {
    public class DcountRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Criteria { get; set; }
        public Json Database { get; set; }
        public Json Field { get; set; }
        /// <summary>
        /// Instantiates a new dcountRequestBody and sets the default values.
        /// </summary>
        public DcountRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"criteria", (o,n) => { (o as DcountRequestBody).Criteria = n.GetObjectValue<Json>(); } },
                {"database", (o,n) => { (o as DcountRequestBody).Database = n.GetObjectValue<Json>(); } },
                {"field", (o,n) => { (o as DcountRequestBody).Field = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("criteria", Criteria);
            writer.WriteObjectValue<Json>("database", Database);
            writer.WriteObjectValue<Json>("field", Field);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
