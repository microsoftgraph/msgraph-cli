using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class GroupSetting : Entity, IParsable {
        /// <summary>Display name of this group of settings, which comes from the associated template.</summary>
        public string DisplayName { get; set; }
        /// <summary>Unique identifier for the tenant-level groupSettingTemplates object that&apos;s been customized for this group-level settings object. Read-only.</summary>
        public string TemplateId { get; set; }
        /// <summary>Collection of name-value pairs corresponding to the name and defaultValue properties in the referenced groupSettingTemplates object.</summary>
        public List<SettingValue> Values { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
                {"values", n => { Values = n.GetCollectionOfObjectValues<SettingValue>(SettingValue.CreateFromDiscriminatorValue).ToList(); } },
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
