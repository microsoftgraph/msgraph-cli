using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ControlScore : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Control action category (Identity, Data, Device, Apps, Infrastructure).</summary>
        public string ControlCategory { get; set; }
        /// <summary>Control unique name.</summary>
        public string ControlName { get; set; }
        /// <summary>Description of the control.</summary>
        public string Description { get; set; }
        /// <summary>Tenant achieved score for the control (it varies day by day depending on tenant operations on the control).</summary>
        public double? Score { get; set; }
        /// <summary>
        /// Instantiates a new controlScore and sets the default values.
        /// </summary>
        public ControlScore() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"controlCategory", (o,n) => { (o as ControlScore).ControlCategory = n.GetStringValue(); } },
                {"controlName", (o,n) => { (o as ControlScore).ControlName = n.GetStringValue(); } },
                {"description", (o,n) => { (o as ControlScore).Description = n.GetStringValue(); } },
                {"score", (o,n) => { (o as ControlScore).Score = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("controlCategory", ControlCategory);
            writer.WriteStringValue("controlName", ControlName);
            writer.WriteStringValue("description", Description);
            writer.WriteDoubleValue("score", Score);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
