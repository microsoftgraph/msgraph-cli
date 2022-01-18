using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookTable : Entity, IParsable {
        /// <summary>Represents a collection of all the columns in the table. Read-only.</summary>
        public List<WorkbookTableColumn> Columns { get; set; }
        /// <summary>Indicates whether the first column contains special formatting.</summary>
        public bool? HighlightFirstColumn { get; set; }
        /// <summary>Indicates whether the last column contains special formatting.</summary>
        public bool? HighlightLastColumn { get; set; }
        /// <summary>Legacy Id used in older Excle clients. The value of the identifier remains the same even when the table is renamed. This property should be interpreted as an opaque string value and should not be parsed to any other type. Read-only.</summary>
        public string LegacyId { get; set; }
        /// <summary>Name of the table.</summary>
        public string Name { get; set; }
        /// <summary>Represents a collection of all the rows in the table. Read-only.</summary>
        public List<WorkbookTableRow> Rows { get; set; }
        /// <summary>Indicates whether the columns show banded formatting in which odd columns are highlighted differently from even ones to make reading the table easier.</summary>
        public bool? ShowBandedColumns { get; set; }
        /// <summary>Indicates whether the rows show banded formatting in which odd rows are highlighted differently from even ones to make reading the table easier.</summary>
        public bool? ShowBandedRows { get; set; }
        /// <summary>Indicates whether the filter buttons are visible at the top of each column header. Setting this is only allowed if the table contains a header row.</summary>
        public bool? ShowFilterButton { get; set; }
        /// <summary>Indicates whether the header row is visible or not. This value can be set to show or remove the header row.</summary>
        public bool? ShowHeaders { get; set; }
        /// <summary>Indicates whether the total row is visible or not. This value can be set to show or remove the total row.</summary>
        public bool? ShowTotals { get; set; }
        /// <summary>Represents the sorting for the table. Read-only.</summary>
        public WorkbookTableSort Sort { get; set; }
        /// <summary>Constant value that represents the Table style. Possible values are: TableStyleLight1 thru TableStyleLight21, TableStyleMedium1 thru TableStyleMedium28, TableStyleStyleDark1 thru TableStyleStyleDark11. A custom user-defined style present in the workbook can also be specified.</summary>
        public string Style { get; set; }
        /// <summary>The worksheet containing the current table. Read-only.</summary>
        public WorkbookWorksheet Worksheet { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"columns", (o,n) => { (o as WorkbookTable).Columns = n.GetCollectionOfObjectValues<WorkbookTableColumn>().ToList(); } },
                {"highlightFirstColumn", (o,n) => { (o as WorkbookTable).HighlightFirstColumn = n.GetBoolValue(); } },
                {"highlightLastColumn", (o,n) => { (o as WorkbookTable).HighlightLastColumn = n.GetBoolValue(); } },
                {"legacyId", (o,n) => { (o as WorkbookTable).LegacyId = n.GetStringValue(); } },
                {"name", (o,n) => { (o as WorkbookTable).Name = n.GetStringValue(); } },
                {"rows", (o,n) => { (o as WorkbookTable).Rows = n.GetCollectionOfObjectValues<WorkbookTableRow>().ToList(); } },
                {"showBandedColumns", (o,n) => { (o as WorkbookTable).ShowBandedColumns = n.GetBoolValue(); } },
                {"showBandedRows", (o,n) => { (o as WorkbookTable).ShowBandedRows = n.GetBoolValue(); } },
                {"showFilterButton", (o,n) => { (o as WorkbookTable).ShowFilterButton = n.GetBoolValue(); } },
                {"showHeaders", (o,n) => { (o as WorkbookTable).ShowHeaders = n.GetBoolValue(); } },
                {"showTotals", (o,n) => { (o as WorkbookTable).ShowTotals = n.GetBoolValue(); } },
                {"sort", (o,n) => { (o as WorkbookTable).Sort = n.GetObjectValue<WorkbookTableSort>(); } },
                {"style", (o,n) => { (o as WorkbookTable).Style = n.GetStringValue(); } },
                {"worksheet", (o,n) => { (o as WorkbookTable).Worksheet = n.GetObjectValue<WorkbookWorksheet>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WorkbookTableColumn>("columns", Columns);
            writer.WriteBoolValue("highlightFirstColumn", HighlightFirstColumn);
            writer.WriteBoolValue("highlightLastColumn", HighlightLastColumn);
            writer.WriteStringValue("legacyId", LegacyId);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<WorkbookTableRow>("rows", Rows);
            writer.WriteBoolValue("showBandedColumns", ShowBandedColumns);
            writer.WriteBoolValue("showBandedRows", ShowBandedRows);
            writer.WriteBoolValue("showFilterButton", ShowFilterButton);
            writer.WriteBoolValue("showHeaders", ShowHeaders);
            writer.WriteBoolValue("showTotals", ShowTotals);
            writer.WriteObjectValue<WorkbookTableSort>("sort", Sort);
            writer.WriteStringValue("style", Style);
            writer.WriteObjectValue<WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
