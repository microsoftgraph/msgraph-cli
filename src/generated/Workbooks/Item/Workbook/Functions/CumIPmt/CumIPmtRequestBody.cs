using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.CumIPmt {
    public class CumIPmtRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json EndPeriod { get; set; }
        public Json Nper { get; set; }
        public Json Pv { get; set; }
        public Json Rate { get; set; }
        public Json StartPeriod { get; set; }
        public Json Type { get; set; }
        /// <summary>
        /// Instantiates a new cumIPmtRequestBody and sets the default values.
        /// </summary>
        public CumIPmtRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endPeriod", (o,n) => { (o as CumIPmtRequestBody).EndPeriod = n.GetObjectValue<Json>(); } },
                {"nper", (o,n) => { (o as CumIPmtRequestBody).Nper = n.GetObjectValue<Json>(); } },
                {"pv", (o,n) => { (o as CumIPmtRequestBody).Pv = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as CumIPmtRequestBody).Rate = n.GetObjectValue<Json>(); } },
                {"startPeriod", (o,n) => { (o as CumIPmtRequestBody).StartPeriod = n.GetObjectValue<Json>(); } },
                {"type", (o,n) => { (o as CumIPmtRequestBody).Type = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("endPeriod", EndPeriod);
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("startPeriod", StartPeriod);
            writer.WriteObjectValue<Json>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
