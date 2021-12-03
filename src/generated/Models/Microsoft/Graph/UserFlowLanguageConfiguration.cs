using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserFlowLanguageConfiguration : Entity, IParsable {
        /// <summary>Collection of pages with the default content to display in a user flow for a specified language. This collection does not allow any kind of modification.</summary>
        public List<UserFlowLanguagePage> DefaultPages { get; set; }
        /// <summary>The language name to display. This property is read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates whether the language is enabled within the user flow.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Collection of pages with the overrides messages to display in a user flow for a specified language. This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).</summary>
        public List<UserFlowLanguagePage> OverridesPages { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"defaultPages", (o,n) => { (o as UserFlowLanguageConfiguration).DefaultPages = n.GetCollectionOfObjectValues<UserFlowLanguagePage>().ToList(); } },
                {"displayName", (o,n) => { (o as UserFlowLanguageConfiguration).DisplayName = n.GetStringValue(); } },
                {"isEnabled", (o,n) => { (o as UserFlowLanguageConfiguration).IsEnabled = n.GetBoolValue(); } },
                {"overridesPages", (o,n) => { (o as UserFlowLanguageConfiguration).OverridesPages = n.GetCollectionOfObjectValues<UserFlowLanguagePage>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserFlowLanguagePage>("defaultPages", DefaultPages);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfObjectValues<UserFlowLanguagePage>("overridesPages", OverridesPages);
        }
    }
}
