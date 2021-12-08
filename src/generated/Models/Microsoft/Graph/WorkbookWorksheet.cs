using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookWorksheet : Entity, IParsable {
        /// <summary>Returns collection of charts that are part of the worksheet. Read-only.</summary>
        public List<WorkbookChart> Charts { get; set; }
        /// <summary>The display name of the worksheet.</summary>
        public string Name { get; set; }
        /// <summary>Returns collection of names that are associated with the worksheet. Read-only.</summary>
        public List<WorkbookNamedItem> Names { get; set; }
        /// <summary>Collection of PivotTables that are part of the worksheet.</summary>
        public List<WorkbookPivotTable> PivotTables { get; set; }
        /// <summary>The zero-based position of the worksheet within the workbook.</summary>
        public int? Position { get; set; }
        /// <summary>Returns sheet protection object for a worksheet. Read-only.</summary>
        public WorkbookWorksheetProtection Protection { get; set; }
        /// <summary>Collection of tables that are part of the worksheet. Read-only.</summary>
        public List<WorkbookTable> Tables { get; set; }
        /// <summary>The Visibility of the worksheet. The possible values are: Visible, Hidden, VeryHidden.</summary>
        public string Visibility { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"charts", (o,n) => { (o as WorkbookWorksheet).Charts = n.GetCollectionOfObjectValues<WorkbookChart>().ToList(); } },
                {"name", (o,n) => { (o as WorkbookWorksheet).Name = n.GetStringValue(); } },
                {"names", (o,n) => { (o as WorkbookWorksheet).Names = n.GetCollectionOfObjectValues<WorkbookNamedItem>().ToList(); } },
                {"pivotTables", (o,n) => { (o as WorkbookWorksheet).PivotTables = n.GetCollectionOfObjectValues<WorkbookPivotTable>().ToList(); } },
                {"position", (o,n) => { (o as WorkbookWorksheet).Position = n.GetIntValue(); } },
                {"protection", (o,n) => { (o as WorkbookWorksheet).Protection = n.GetObjectValue<WorkbookWorksheetProtection>(); } },
                {"tables", (o,n) => { (o as WorkbookWorksheet).Tables = n.GetCollectionOfObjectValues<WorkbookTable>().ToList(); } },
                {"visibility", (o,n) => { (o as WorkbookWorksheet).Visibility = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WorkbookChart>("charts", Charts);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<WorkbookPivotTable>("pivotTables", PivotTables);
            writer.WriteIntValue("position", Position);
            writer.WriteObjectValue<WorkbookWorksheetProtection>("protection", Protection);
            writer.WriteCollectionOfObjectValues<WorkbookTable>("tables", Tables);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
