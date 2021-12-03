using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Hyperlink {
    public class HyperlinkRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json FriendlyName { get; set; }
        public Json LinkLocation { get; set; }
        /// <summary>
        /// Instantiates a new hyperlinkRequestBody and sets the default values.
        /// </summary>
        public HyperlinkRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"friendlyName", (o,n) => { (o as HyperlinkRequestBody).FriendlyName = n.GetObjectValue<Json>(); } },
                {"linkLocation", (o,n) => { (o as HyperlinkRequestBody).LinkLocation = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("friendlyName", FriendlyName);
            writer.WriteObjectValue<Json>("linkLocation", LinkLocation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
