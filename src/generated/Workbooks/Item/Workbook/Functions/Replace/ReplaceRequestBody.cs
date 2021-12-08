using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Replace {
    public class ReplaceRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json NewText { get; set; }
        public Json NumChars { get; set; }
        public Json OldText { get; set; }
        public Json StartNum { get; set; }
        /// <summary>
        /// Instantiates a new replaceRequestBody and sets the default values.
        /// </summary>
        public ReplaceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"newText", (o,n) => { (o as ReplaceRequestBody).NewText = n.GetObjectValue<Json>(); } },
                {"numChars", (o,n) => { (o as ReplaceRequestBody).NumChars = n.GetObjectValue<Json>(); } },
                {"oldText", (o,n) => { (o as ReplaceRequestBody).OldText = n.GetObjectValue<Json>(); } },
                {"startNum", (o,n) => { (o as ReplaceRequestBody).StartNum = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("newText", NewText);
            writer.WriteObjectValue<Json>("numChars", NumChars);
            writer.WriteObjectValue<Json>("oldText", OldText);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
