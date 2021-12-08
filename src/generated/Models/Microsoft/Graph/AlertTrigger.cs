using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AlertTrigger : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the property serving as a detection trigger.</summary>
        public string Name { get; set; }
        /// <summary>Type of the property in the key:value pair for interpretation. For example, String, Boolean etc.</summary>
        public string Type { get; set; }
        /// <summary>Value of the property serving as a detection trigger.</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new alertTrigger and sets the default values.
        /// </summary>
        public AlertTrigger() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"name", (o,n) => { (o as AlertTrigger).Name = n.GetStringValue(); } },
                {"type", (o,n) => { (o as AlertTrigger).Type = n.GetStringValue(); } },
                {"value", (o,n) => { (o as AlertTrigger).Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
