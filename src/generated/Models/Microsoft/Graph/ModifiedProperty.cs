using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ModifiedProperty : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of property that was modified.</summary>
        public string DisplayName { get; set; }
        /// <summary>New property value.</summary>
        public string NewValue { get; set; }
        /// <summary>Old property value.</summary>
        public string OldValue { get; set; }
        /// <summary>
        /// Instantiates a new modifiedProperty and sets the default values.
        /// </summary>
        public ModifiedProperty() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as ModifiedProperty).DisplayName = n.GetStringValue(); } },
                {"newValue", (o,n) => { (o as ModifiedProperty).NewValue = n.GetStringValue(); } },
                {"oldValue", (o,n) => { (o as ModifiedProperty).OldValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("newValue", NewValue);
            writer.WriteStringValue("oldValue", OldValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
