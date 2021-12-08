using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.RandBetween {
    public class RandBetweenRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Bottom { get; set; }
        public Json Top { get; set; }
        /// <summary>
        /// Instantiates a new randBetweenRequestBody and sets the default values.
        /// </summary>
        public RandBetweenRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bottom", (o,n) => { (o as RandBetweenRequestBody).Bottom = n.GetObjectValue<Json>(); } },
                {"top", (o,n) => { (o as RandBetweenRequestBody).Top = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("bottom", Bottom);
            writer.WriteObjectValue<Json>("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
