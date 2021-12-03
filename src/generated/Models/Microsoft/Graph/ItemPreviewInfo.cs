using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ItemPreviewInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string GetUrl { get; set; }
        public string PostParameters { get; set; }
        public string PostUrl { get; set; }
        /// <summary>
        /// Instantiates a new itemPreviewInfo and sets the default values.
        /// </summary>
        public ItemPreviewInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"getUrl", (o,n) => { (o as ItemPreviewInfo).GetUrl = n.GetStringValue(); } },
                {"postParameters", (o,n) => { (o as ItemPreviewInfo).PostParameters = n.GetStringValue(); } },
                {"postUrl", (o,n) => { (o as ItemPreviewInfo).PostUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("getUrl", GetUrl);
            writer.WriteStringValue("postParameters", PostParameters);
            writer.WriteStringValue("postUrl", PostUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
