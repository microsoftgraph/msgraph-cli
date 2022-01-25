using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ColumnValidation : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Default BCP 47 language tag for the description.</summary>
        public string DefaultLanguage { get; set; }
        /// <summary>Localized messages that explain what is needed for this column's value to be considered valid. User will be prompted with this message if validation fails.</summary>
        public List<DisplayNameLocalization> Descriptions { get; set; }
        /// <summary>The formula to validate column value. For examples, see Examples of common formulas in lists</summary>
        public string Formula { get; set; }
        /// <summary>
        /// Instantiates a new columnValidation and sets the default values.
        /// </summary>
        public ColumnValidation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"defaultLanguage", (o,n) => { (o as ColumnValidation).DefaultLanguage = n.GetStringValue(); } },
                {"descriptions", (o,n) => { (o as ColumnValidation).Descriptions = n.GetCollectionOfObjectValues<DisplayNameLocalization>().ToList(); } },
                {"formula", (o,n) => { (o as ColumnValidation).Formula = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultLanguage", DefaultLanguage);
            writer.WriteCollectionOfObjectValues<DisplayNameLocalization>("descriptions", Descriptions);
            writer.WriteStringValue("formula", Formula);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
