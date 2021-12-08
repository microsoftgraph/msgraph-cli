using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.SumIf {
    public class SumIfRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Criteria { get; set; }
        public Json Range { get; set; }
        public Json SumRange { get; set; }
        /// <summary>
        /// Instantiates a new sumIfRequestBody and sets the default values.
        /// </summary>
        public SumIfRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"criteria", (o,n) => { (o as SumIfRequestBody).Criteria = n.GetObjectValue<Json>(); } },
                {"range", (o,n) => { (o as SumIfRequestBody).Range = n.GetObjectValue<Json>(); } },
                {"sumRange", (o,n) => { (o as SumIfRequestBody).SumRange = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("criteria", Criteria);
            writer.WriteObjectValue<Json>("range", Range);
            writer.WriteObjectValue<Json>("sumRange", SumRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
