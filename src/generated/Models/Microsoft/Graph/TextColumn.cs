using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TextColumn : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether to allow multiple lines of text.</summary>
        public bool? AllowMultipleLines { get; set; }
        /// <summary>Whether updates to this column should replace existing text, or append to it.</summary>
        public bool? AppendChangesToExistingText { get; set; }
        /// <summary>The size of the text box.</summary>
        public int? LinesForEditing { get; set; }
        /// <summary>The maximum number of characters for the value.</summary>
        public int? MaxLength { get; set; }
        /// <summary>The type of text being stored. Must be one of plain or richText</summary>
        public string TextType { get; set; }
        /// <summary>
        /// Instantiates a new textColumn and sets the default values.
        /// </summary>
        public TextColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowMultipleLines", (o,n) => { (o as TextColumn).AllowMultipleLines = n.GetBoolValue(); } },
                {"appendChangesToExistingText", (o,n) => { (o as TextColumn).AppendChangesToExistingText = n.GetBoolValue(); } },
                {"linesForEditing", (o,n) => { (o as TextColumn).LinesForEditing = n.GetIntValue(); } },
                {"maxLength", (o,n) => { (o as TextColumn).MaxLength = n.GetIntValue(); } },
                {"textType", (o,n) => { (o as TextColumn).TextType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleLines", AllowMultipleLines);
            writer.WriteBoolValue("appendChangesToExistingText", AppendChangesToExistingText);
            writer.WriteIntValue("linesForEditing", LinesForEditing);
            writer.WriteIntValue("maxLength", MaxLength);
            writer.WriteStringValue("textType", TextType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
