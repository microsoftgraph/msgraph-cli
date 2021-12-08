using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AssignedLabel : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The display name of the label. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The unique identifier of the label.</summary>
        public string LabelId { get; set; }
        /// <summary>
        /// Instantiates a new assignedLabel and sets the default values.
        /// </summary>
        public AssignedLabel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as AssignedLabel).DisplayName = n.GetStringValue(); } },
                {"labelId", (o,n) => { (o as AssignedLabel).LabelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("labelId", LabelId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
