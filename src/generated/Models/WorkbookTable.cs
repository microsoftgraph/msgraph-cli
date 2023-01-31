using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WorkbookTable : Entity, IParsable {
        /// <summary>Represents a collection of all the columns in the table. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookTableColumn>? Columns { get; set; }
#nullable restore
#else
        public List<WorkbookTableColumn> Columns { get; set; }
#endif
        /// <summary>Indicates whether the first column contains special formatting.</summary>
        public bool? HighlightFirstColumn { get; set; }
        /// <summary>Indicates whether the last column contains special formatting.</summary>
        public bool? HighlightLastColumn { get; set; }
        /// <summary>Legacy Id used in older Excle clients. The value of the identifier remains the same even when the table is renamed. This property should be interpreted as an opaque string value and should not be parsed to any other type. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegacyId { get; set; }
#nullable restore
#else
        public string LegacyId { get; set; }
#endif
        /// <summary>Name of the table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Represents a collection of all the rows in the table. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookTableRow>? Rows { get; set; }
#nullable restore
#else
        public List<WorkbookTableRow> Rows { get; set; }
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookTableSort? Sort { get; set; }
#nullable restore
#else
        public WorkbookTableSort Sort { get; set; }
#endif
        /// <summary>Constant value that represents the Table style. The possible values are: TableStyleLight1 thru TableStyleLight21, TableStyleMedium1 thru TableStyleMedium28, TableStyleStyleDark1 thru TableStyleStyleDark11. A custom user-defined style present in the workbook can also be specified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Style { get; set; }
#nullable restore
#else
        public string Style { get; set; }
#endif
        /// <summary>The worksheet containing the current table. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookWorksheet? Worksheet { get; set; }
#nullable restore
#else
        public WorkbookWorksheet Worksheet { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new WorkbookTable CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new WorkbookTable CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookTable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<WorkbookTableColumn>(WorkbookTableColumn.CreateFromDiscriminatorValue)?.ToList(); } },
                {"highlightFirstColumn", n => { HighlightFirstColumn = n.GetBoolValue(); } },
                {"highlightLastColumn", n => { HighlightLastColumn = n.GetBoolValue(); } },
                {"legacyId", n => { LegacyId = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"rows", n => { Rows = n.GetCollectionOfObjectValues<WorkbookTableRow>(WorkbookTableRow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"showBandedColumns", n => { ShowBandedColumns = n.GetBoolValue(); } },
                {"showBandedRows", n => { ShowBandedRows = n.GetBoolValue(); } },
                {"showFilterButton", n => { ShowFilterButton = n.GetBoolValue(); } },
                {"showHeaders", n => { ShowHeaders = n.GetBoolValue(); } },
                {"showTotals", n => { ShowTotals = n.GetBoolValue(); } },
                {"sort", n => { Sort = n.GetObjectValue<WorkbookTableSort>(WorkbookTableSort.CreateFromDiscriminatorValue); } },
                {"style", n => { Style = n.GetStringValue(); } },
                {"worksheet", n => { Worksheet = n.GetObjectValue<WorkbookWorksheet>(WorkbookWorksheet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
