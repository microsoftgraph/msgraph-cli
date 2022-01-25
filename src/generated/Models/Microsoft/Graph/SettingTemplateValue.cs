using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SettingTemplateValue : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Default value for the setting. Read-only.</summary>
        public string DefaultValue { get; set; }
        /// <summary>Description of the setting. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>Name of the setting. Read-only.</summary>
        public string Name { get; set; }
        /// <summary>Type of the setting. Read-only.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new settingTemplateValue and sets the default values.
        /// </summary>
        public SettingTemplateValue() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"defaultValue", (o,n) => { (o as SettingTemplateValue).DefaultValue = n.GetStringValue(); } },
                {"description", (o,n) => { (o as SettingTemplateValue).Description = n.GetStringValue(); } },
                {"name", (o,n) => { (o as SettingTemplateValue).Name = n.GetStringValue(); } },
                {"type", (o,n) => { (o as SettingTemplateValue).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
