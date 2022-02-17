using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Fixed {
    public class FixedRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Decimals { get; set; }
        public Json NoCommas { get; set; }
        public Json Number { get; set; }
        /// <summary>
        /// Instantiates a new fixedRequestBody and sets the default values.
        /// </summary>
        public FixedRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"decimals", (o,n) => { (o as FixedRequestBody).Decimals = n.GetObjectValue<Json>(); } },
                {"noCommas", (o,n) => { (o as FixedRequestBody).NoCommas = n.GetObjectValue<Json>(); } },
                {"number", (o,n) => { (o as FixedRequestBody).Number = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("decimals", Decimals);
            writer.WriteObjectValue<Json>("noCommas", NoCommas);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
