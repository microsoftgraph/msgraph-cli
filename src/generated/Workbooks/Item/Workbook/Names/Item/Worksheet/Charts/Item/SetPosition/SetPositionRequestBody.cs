using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts.Item.SetPosition {
    public class SetPositionRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json EndCell { get; set; }
        public Json StartCell { get; set; }
        /// <summary>
        /// Instantiates a new setPositionRequestBody and sets the default values.
        /// </summary>
        public SetPositionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endCell", (o,n) => { (o as SetPositionRequestBody).EndCell = n.GetObjectValue<Json>(); } },
                {"startCell", (o,n) => { (o as SetPositionRequestBody).StartCell = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("endCell", EndCell);
            writer.WriteObjectValue<Json>("startCell", StartCell);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
