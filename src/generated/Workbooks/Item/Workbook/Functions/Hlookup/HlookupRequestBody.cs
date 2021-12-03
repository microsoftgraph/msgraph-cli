using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Hlookup {
    public class HlookupRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json LookupValue { get; set; }
        public Json RangeLookup { get; set; }
        public Json RowIndexNum { get; set; }
        public Json TableArray { get; set; }
        /// <summary>
        /// Instantiates a new hlookupRequestBody and sets the default values.
        /// </summary>
        public HlookupRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"lookupValue", (o,n) => { (o as HlookupRequestBody).LookupValue = n.GetObjectValue<Json>(); } },
                {"rangeLookup", (o,n) => { (o as HlookupRequestBody).RangeLookup = n.GetObjectValue<Json>(); } },
                {"rowIndexNum", (o,n) => { (o as HlookupRequestBody).RowIndexNum = n.GetObjectValue<Json>(); } },
                {"tableArray", (o,n) => { (o as HlookupRequestBody).TableArray = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("lookupValue", LookupValue);
            writer.WriteObjectValue<Json>("rangeLookup", RangeLookup);
            writer.WriteObjectValue<Json>("rowIndexNum", RowIndexNum);
            writer.WriteObjectValue<Json>("tableArray", TableArray);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
