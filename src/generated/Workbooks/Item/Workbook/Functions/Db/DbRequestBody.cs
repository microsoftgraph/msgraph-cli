using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Db {
    public class DbRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cost { get; set; }
        public Json Life { get; set; }
        public Json Month { get; set; }
        public Json Period { get; set; }
        public Json Salvage { get; set; }
        /// <summary>
        /// Instantiates a new dbRequestBody and sets the default values.
        /// </summary>
        public DbRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cost", (o,n) => { (o as DbRequestBody).Cost = n.GetObjectValue<Json>(); } },
                {"life", (o,n) => { (o as DbRequestBody).Life = n.GetObjectValue<Json>(); } },
                {"month", (o,n) => { (o as DbRequestBody).Month = n.GetObjectValue<Json>(); } },
                {"period", (o,n) => { (o as DbRequestBody).Period = n.GetObjectValue<Json>(); } },
                {"salvage", (o,n) => { (o as DbRequestBody).Salvage = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("life", Life);
            writer.WriteObjectValue<Json>("month", Month);
            writer.WriteObjectValue<Json>("period", Period);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
