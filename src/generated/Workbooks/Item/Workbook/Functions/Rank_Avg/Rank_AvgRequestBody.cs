using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Rank_Avg {
    public class Rank_AvgRequestBody : IParsable {
        public Json @Ref { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Number { get; set; }
        public Json Order { get; set; }
        /// <summary>
        /// Instantiates a new rank_AvgRequestBody and sets the default values.
        /// </summary>
        public Rank_AvgRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ref", (o,n) => { (o as Rank_AvgRequestBody).@Ref = n.GetObjectValue<Json>(); } },
                {"number", (o,n) => { (o as Rank_AvgRequestBody).Number = n.GetObjectValue<Json>(); } },
                {"order", (o,n) => { (o as Rank_AvgRequestBody).Order = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("ref", @Ref);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("order", Order);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
