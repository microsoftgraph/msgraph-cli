using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ResultInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The result code.</summary>
        public int? Code { get; set; }
        /// <summary>The message.</summary>
        public string Message { get; set; }
        /// <summary>The result sub-code.</summary>
        public int? Subcode { get; set; }
        /// <summary>
        /// Instantiates a new resultInfo and sets the default values.
        /// </summary>
        public ResultInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as ResultInfo).Code = n.GetIntValue(); } },
                {"message", (o,n) => { (o as ResultInfo).Message = n.GetStringValue(); } },
                {"subcode", (o,n) => { (o as ResultInfo).Subcode = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("code", Code);
            writer.WriteStringValue("message", Message);
            writer.WriteIntValue("subcode", Subcode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
