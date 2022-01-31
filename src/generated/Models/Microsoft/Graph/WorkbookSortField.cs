using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookSortField : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents whether the sorting is done in an ascending fashion.</summary>
        public bool? Ascending { get; set; }
        /// <summary>Represents the color that is the target of the condition if the sorting is on font or cell color.</summary>
        public string Color { get; set; }
        /// <summary>Represents additional sorting options for this field. Possible values are: Normal, TextAsNumber.</summary>
        public string DataOption { get; set; }
        /// <summary>Represents the icon that is the target of the condition if the sorting is on the cell's icon.</summary>
        public WorkbookIcon Icon { get; set; }
        /// <summary>Represents the column (or row, depending on the sort orientation) that the condition is on. Represented as an offset from the first column (or row).</summary>
        public int? Key { get; set; }
        /// <summary>Represents the type of sorting of this condition. Possible values are: Value, CellColor, FontColor, Icon.</summary>
        public string SortOn { get; set; }
        /// <summary>
        /// Instantiates a new workbookSortField and sets the default values.
        /// </summary>
        public WorkbookSortField() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ascending", (o,n) => { (o as WorkbookSortField).Ascending = n.GetBoolValue(); } },
                {"color", (o,n) => { (o as WorkbookSortField).Color = n.GetStringValue(); } },
                {"dataOption", (o,n) => { (o as WorkbookSortField).DataOption = n.GetStringValue(); } },
                {"icon", (o,n) => { (o as WorkbookSortField).Icon = n.GetObjectValue<WorkbookIcon>(); } },
                {"key", (o,n) => { (o as WorkbookSortField).Key = n.GetIntValue(); } },
                {"sortOn", (o,n) => { (o as WorkbookSortField).SortOn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("ascending", Ascending);
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("dataOption", DataOption);
            writer.WriteObjectValue<WorkbookIcon>("icon", Icon);
            writer.WriteIntValue("key", Key);
            writer.WriteStringValue("sortOn", SortOn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
