using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class GroupSetting : Entity, IParsable {
        /// <summary>Display name of this group of settings, which comes from the associated template.</summary>
        public string DisplayName { get; set; }
        /// <summary>Unique identifier for the template used to create this group of settings. Read-only.</summary>
        public string TemplateId { get; set; }
        /// <summary>Collection of name value pairs. Must contain and set all the settings defined in the template.</summary>
        public List<SettingValue> Values { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as GroupSetting).DisplayName = n.GetStringValue(); } },
                {"templateId", (o,n) => { (o as GroupSetting).TemplateId = n.GetStringValue(); } },
                {"values", (o,n) => { (o as GroupSetting).Values = n.GetCollectionOfObjectValues<SettingValue>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteCollectionOfObjectValues<SettingValue>("values", Values);
        }
    }
}
