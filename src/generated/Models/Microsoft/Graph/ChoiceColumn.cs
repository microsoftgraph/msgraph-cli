using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ChoiceColumn : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If true, allows custom values that aren't in the configured choices.</summary>
        public bool? AllowTextEntry { get; set; }
        /// <summary>The list of values available for this column.</summary>
        public List<string> Choices { get; set; }
        /// <summary>How the choices are to be presented in the UX. Must be one of checkBoxes, dropDownMenu, or radioButtons</summary>
        public string DisplayAs { get; set; }
        /// <summary>
        /// Instantiates a new choiceColumn and sets the default values.
        /// </summary>
        public ChoiceColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowTextEntry", (o,n) => { (o as ChoiceColumn).AllowTextEntry = n.GetBoolValue(); } },
                {"choices", (o,n) => { (o as ChoiceColumn).Choices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"displayAs", (o,n) => { (o as ChoiceColumn).DisplayAs = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowTextEntry", AllowTextEntry);
            writer.WriteCollectionOfPrimitiveValues<string>("choices", Choices);
            writer.WriteStringValue("displayAs", DisplayAs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
