using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DisplayNameLocalization : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.</summary>
        public string DisplayName { get; set; }
        /// <summary>Provides the language culture-code and friendly name of the language that the displayName field has been provided in.</summary>
        public string LanguageTag { get; set; }
        /// <summary>
        /// Instantiates a new displayNameLocalization and sets the default values.
        /// </summary>
        public DisplayNameLocalization() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DisplayNameLocalization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DisplayNameLocalization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as DisplayNameLocalization).DisplayName = n.GetStringValue(); } },
                {"languageTag", (o,n) => { (o as DisplayNameLocalization).LanguageTag = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
