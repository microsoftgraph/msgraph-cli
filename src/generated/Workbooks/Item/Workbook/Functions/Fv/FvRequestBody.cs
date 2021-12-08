using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Fv {
    public class FvRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Nper { get; set; }
        public Json Pmt { get; set; }
        public Json Pv { get; set; }
        public Json Rate { get; set; }
        public Json Type { get; set; }
        /// <summary>
        /// Instantiates a new fvRequestBody and sets the default values.
        /// </summary>
        public FvRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"nper", (o,n) => { (o as FvRequestBody).Nper = n.GetObjectValue<Json>(); } },
                {"pmt", (o,n) => { (o as FvRequestBody).Pmt = n.GetObjectValue<Json>(); } },
                {"pv", (o,n) => { (o as FvRequestBody).Pv = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as FvRequestBody).Rate = n.GetObjectValue<Json>(); } },
                {"type", (o,n) => { (o as FvRequestBody).Type = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("pmt", Pmt);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
