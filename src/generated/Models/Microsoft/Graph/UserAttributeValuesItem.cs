using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserAttributeValuesItem : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Used to set the value as the default.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The display name of the property displayed to the end user in the user flow.</summary>
        public string Name { get; set; }
        /// <summary>The value that is set when this item is selected.</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new userAttributeValuesItem and sets the default values.
        /// </summary>
        public UserAttributeValuesItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isDefault", (o,n) => { (o as UserAttributeValuesItem).IsDefault = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as UserAttributeValuesItem).Name = n.GetStringValue(); } },
                {"value", (o,n) => { (o as UserAttributeValuesItem).Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
