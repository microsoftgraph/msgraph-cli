using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookWorksheetProtectionOptions : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the worksheet protection option of allowing using auto filter feature.</summary>
        public bool? AllowAutoFilter { get; set; }
        /// <summary>Represents the worksheet protection option of allowing deleting columns.</summary>
        public bool? AllowDeleteColumns { get; set; }
        /// <summary>Represents the worksheet protection option of allowing deleting rows.</summary>
        public bool? AllowDeleteRows { get; set; }
        /// <summary>Represents the worksheet protection option of allowing formatting cells.</summary>
        public bool? AllowFormatCells { get; set; }
        /// <summary>Represents the worksheet protection option of allowing formatting columns.</summary>
        public bool? AllowFormatColumns { get; set; }
        /// <summary>Represents the worksheet protection option of allowing formatting rows.</summary>
        public bool? AllowFormatRows { get; set; }
        /// <summary>Represents the worksheet protection option of allowing inserting columns.</summary>
        public bool? AllowInsertColumns { get; set; }
        /// <summary>Represents the worksheet protection option of allowing inserting hyperlinks.</summary>
        public bool? AllowInsertHyperlinks { get; set; }
        /// <summary>Represents the worksheet protection option of allowing inserting rows.</summary>
        public bool? AllowInsertRows { get; set; }
        /// <summary>Represents the worksheet protection option of allowing using pivot table feature.</summary>
        public bool? AllowPivotTables { get; set; }
        /// <summary>Represents the worksheet protection option of allowing using sort feature.</summary>
        public bool? AllowSort { get; set; }
        /// <summary>
        /// Instantiates a new workbookWorksheetProtectionOptions and sets the default values.
        /// </summary>
        public WorkbookWorksheetProtectionOptions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowAutoFilter", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowAutoFilter = n.GetBoolValue(); } },
                {"allowDeleteColumns", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowDeleteColumns = n.GetBoolValue(); } },
                {"allowDeleteRows", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowDeleteRows = n.GetBoolValue(); } },
                {"allowFormatCells", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowFormatCells = n.GetBoolValue(); } },
                {"allowFormatColumns", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowFormatColumns = n.GetBoolValue(); } },
                {"allowFormatRows", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowFormatRows = n.GetBoolValue(); } },
                {"allowInsertColumns", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowInsertColumns = n.GetBoolValue(); } },
                {"allowInsertHyperlinks", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowInsertHyperlinks = n.GetBoolValue(); } },
                {"allowInsertRows", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowInsertRows = n.GetBoolValue(); } },
                {"allowPivotTables", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowPivotTables = n.GetBoolValue(); } },
                {"allowSort", (o,n) => { (o as WorkbookWorksheetProtectionOptions).AllowSort = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowAutoFilter", AllowAutoFilter);
            writer.WriteBoolValue("allowDeleteColumns", AllowDeleteColumns);
            writer.WriteBoolValue("allowDeleteRows", AllowDeleteRows);
            writer.WriteBoolValue("allowFormatCells", AllowFormatCells);
            writer.WriteBoolValue("allowFormatColumns", AllowFormatColumns);
            writer.WriteBoolValue("allowFormatRows", AllowFormatRows);
            writer.WriteBoolValue("allowInsertColumns", AllowInsertColumns);
            writer.WriteBoolValue("allowInsertHyperlinks", AllowInsertHyperlinks);
            writer.WriteBoolValue("allowInsertRows", AllowInsertRows);
            writer.WriteBoolValue("allowPivotTables", AllowPivotTables);
            writer.WriteBoolValue("allowSort", AllowSort);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
