using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Vlookup {
    public class VlookupRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json ColIndexNum { get; set; }
        public Json LookupValue { get; set; }
        public Json RangeLookup { get; set; }
        public Json TableArray { get; set; }
        /// <summary>
        /// Instantiates a new vlookupRequestBody and sets the default values.
        /// </summary>
        public VlookupRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"colIndexNum", (o,n) => { (o as VlookupRequestBody).ColIndexNum = n.GetObjectValue<Json>(); } },
                {"lookupValue", (o,n) => { (o as VlookupRequestBody).LookupValue = n.GetObjectValue<Json>(); } },
                {"rangeLookup", (o,n) => { (o as VlookupRequestBody).RangeLookup = n.GetObjectValue<Json>(); } },
                {"tableArray", (o,n) => { (o as VlookupRequestBody).TableArray = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("colIndexNum", ColIndexNum);
            writer.WriteObjectValue<Json>("lookupValue", LookupValue);
            writer.WriteObjectValue<Json>("rangeLookup", RangeLookup);
            writer.WriteObjectValue<Json>("tableArray", TableArray);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
