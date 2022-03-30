using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class GroupSettingTemplate : DirectoryObject, IParsable {
        /// <summary>Description of the template.</summary>
        public string Description { get; set; }
        /// <summary>Display name of the template. The template named Group.Unified can be used to configure tenant-wide Microsoft 365 group settings, while the template named Group.Unified.Guest can be used to configure group-specific settings.</summary>
        public string DisplayName { get; set; }
        /// <summary>Collection of settingTemplateValues that list the set of available settings, defaults and types that make up this template.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SettingTemplateValue> Values { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.GroupSettingTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupSettingTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as GroupSettingTemplate).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as GroupSettingTemplate).DisplayName = n.GetStringValue(); } },
                {"values", (o,n) => { (o as GroupSettingTemplate).Values = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SettingTemplateValue>(ApiSdk.Models.Microsoft.Graph.SettingTemplateValue.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SettingTemplateValue>("values", Values);
        }
    }
}
