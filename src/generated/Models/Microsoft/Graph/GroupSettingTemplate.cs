using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class GroupSettingTemplate : DirectoryObject, IParsable {
        /// <summary>Description of the template.</summary>
        public string Description { get; set; }
        /// <summary>Display name of the template.</summary>
        public string DisplayName { get; set; }
        /// <summary>Collection of settingTemplateValues that list the set of available settings, defaults and types that make up this template.</summary>
        public List<SettingTemplateValue> Values { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as GroupSettingTemplate).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as GroupSettingTemplate).DisplayName = n.GetStringValue(); } },
                {"values", (o,n) => { (o as GroupSettingTemplate).Values = n.GetCollectionOfObjectValues<SettingTemplateValue>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<SettingTemplateValue>("values", Values);
        }
    }
}
