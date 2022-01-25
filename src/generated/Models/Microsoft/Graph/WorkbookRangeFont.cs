using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookRangeFont : Entity, IParsable {
        /// <summary>Represents the bold status of font.</summary>
        public bool? Bold { get; set; }
        /// <summary>HTML color code representation of the text color. E.g. #FF0000 represents Red.</summary>
        public string Color { get; set; }
        /// <summary>Represents the italic status of the font.</summary>
        public bool? Italic { get; set; }
        /// <summary>Font name (e.g. 'Calibri')</summary>
        public string Name { get; set; }
        /// <summary>Font size.</summary>
        public double? Size { get; set; }
        /// <summary>Type of underline applied to the font. Possible values are: None, Single, Double, SingleAccountant, DoubleAccountant.</summary>
        public string Underline { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"bold", (o,n) => { (o as WorkbookRangeFont).Bold = n.GetBoolValue(); } },
                {"color", (o,n) => { (o as WorkbookRangeFont).Color = n.GetStringValue(); } },
                {"italic", (o,n) => { (o as WorkbookRangeFont).Italic = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as WorkbookRangeFont).Name = n.GetStringValue(); } },
                {"size", (o,n) => { (o as WorkbookRangeFont).Size = n.GetDoubleValue(); } },
                {"underline", (o,n) => { (o as WorkbookRangeFont).Underline = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("bold", Bold);
            writer.WriteStringValue("color", Color);
            writer.WriteBoolValue("italic", Italic);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("size", Size);
            writer.WriteStringValue("underline", Underline);
        }
    }
}
