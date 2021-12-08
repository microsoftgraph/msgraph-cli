using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AlertDetection : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string DetectionType { get; set; }
        public string Method { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Instantiates a new alertDetection and sets the default values.
        /// </summary>
        public AlertDetection() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"detectionType", (o,n) => { (o as AlertDetection).DetectionType = n.GetStringValue(); } },
                {"method", (o,n) => { (o as AlertDetection).Method = n.GetStringValue(); } },
                {"name", (o,n) => { (o as AlertDetection).Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detectionType", DetectionType);
            writer.WriteStringValue("method", Method);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
