using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.ReplaceB {
    public class ReplaceBRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json NewText { get; set; }
        public Json NumBytes { get; set; }
        public Json OldText { get; set; }
        public Json StartNum { get; set; }
        /// <summary>
        /// Instantiates a new replaceBRequestBody and sets the default values.
        /// </summary>
        public ReplaceBRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"newText", (o,n) => { (o as ReplaceBRequestBody).NewText = n.GetObjectValue<Json>(); } },
                {"numBytes", (o,n) => { (o as ReplaceBRequestBody).NumBytes = n.GetObjectValue<Json>(); } },
                {"oldText", (o,n) => { (o as ReplaceBRequestBody).OldText = n.GetObjectValue<Json>(); } },
                {"startNum", (o,n) => { (o as ReplaceBRequestBody).StartNum = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("newText", NewText);
            writer.WriteObjectValue<Json>("numBytes", NumBytes);
            writer.WriteObjectValue<Json>("oldText", OldText);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
