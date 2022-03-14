using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.TermStore {
    public class LocalizedLabel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the label is the default label.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The language tag for the label.</summary>
        public string LanguageTag { get; set; }
        /// <summary>The name of the label.</summary>
        public string Name { get; set; }
        /// <summary>
        /// Instantiates a new localizedLabel and sets the default values.
        /// </summary>
        public LocalizedLabel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static LocalizedLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LocalizedLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isDefault", (o,n) => { (o as LocalizedLabel).IsDefault = n.GetBoolValue(); } },
                {"languageTag", (o,n) => { (o as LocalizedLabel).LanguageTag = n.GetStringValue(); } },
                {"name", (o,n) => { (o as LocalizedLabel).Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
