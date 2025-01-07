// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WorkbookRange : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the range reference in A1-style. Address value contains the Sheet reference (for example, Sheet1!A1:B4). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address { get; set; }
#nullable restore
#else
        public string Address { get; set; }
#endif
        /// <summary>Represents range reference for the specified range in the language of the user. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressLocal { get; set; }
#nullable restore
#else
        public string AddressLocal { get; set; }
#endif
        /// <summary>Number of cells in the range. Read-only.</summary>
        public int? CellCount { get; set; }
        /// <summary>Represents the total number of columns in the range. Read-only.</summary>
        public int? ColumnCount { get; set; }
        /// <summary>Indicates whether all columns of the current range are hidden.</summary>
        public bool? ColumnHidden { get; set; }
        /// <summary>Represents the column number of the first cell in the range. Zero-indexed. Read-only.</summary>
        public int? ColumnIndex { get; set; }
        /// <summary>Returns a format object, encapsulating the range&apos;s font, fill, borders, alignment, and other properties. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WorkbookRangeFormat? Format { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WorkbookRangeFormat Format { get; set; }
#endif
        /// <summary>Represents the formula in A1-style notation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Formulas { get; set; }
#nullable restore
#else
        public UntypedNode Formulas { get; set; }
#endif
        /// <summary>Represents the formula in A1-style notation, in the user&apos;s language and number-formatting locale.  For example, the English &apos;=SUM(A1, 1.5)&apos; formula would become &apos;=SUMME(A1; 1,5)&apos; in German.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? FormulasLocal { get; set; }
#nullable restore
#else
        public UntypedNode FormulasLocal { get; set; }
#endif
        /// <summary>Represents the formula in R1C1-style notation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? FormulasR1C1 { get; set; }
#nullable restore
#else
        public UntypedNode FormulasR1C1 { get; set; }
#endif
        /// <summary>Represents if all cells of the current range are hidden. Read-only.</summary>
        public bool? Hidden { get; set; }
        /// <summary>Represents Excel&apos;s number format code for the given cell.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? NumberFormat { get; set; }
#nullable restore
#else
        public UntypedNode NumberFormat { get; set; }
#endif
        /// <summary>Returns the total number of rows in the range. Read-only.</summary>
        public int? RowCount { get; set; }
        /// <summary>Indicates whether all rows of the current range are hidden.</summary>
        public bool? RowHidden { get; set; }
        /// <summary>Returns the row number of the first cell in the range. Zero-indexed. Read-only.</summary>
        public int? RowIndex { get; set; }
        /// <summary>The worksheet containing the current range. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WorkbookRangeSort? Sort { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WorkbookRangeSort Sort { get; set; }
#endif
        /// <summary>Text values of the specified range. The Text value doesn&apos;t depend on the cell width. The # sign substitution that happens in Excel UI doesn&apos;t affect the text value returned by the API. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Text { get; set; }
#nullable restore
#else
        public UntypedNode Text { get; set; }
#endif
        /// <summary>Represents the raw values of the specified range. The data returned can be of type string, number, or a Boolean. Cell that contains an error returns the error string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Values { get; set; }
#nullable restore
#else
        public UntypedNode Values { get; set; }
#endif
        /// <summary>Represents the type of data of each cell. The possible values are: Unknown, Empty, String, Integer, Double, Boolean, Error. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ValueTypes { get; set; }
#nullable restore
#else
        public UntypedNode ValueTypes { get; set; }
#endif
        /// <summary>The worksheet containing the current range. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WorkbookWorksheet? Worksheet { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WorkbookWorksheet Worksheet { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WorkbookRange"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WorkbookRange CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WorkbookRange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "address", n => { Address = n.GetStringValue(); } },
                { "addressLocal", n => { AddressLocal = n.GetStringValue(); } },
                { "cellCount", n => { CellCount = n.GetIntValue(); } },
                { "columnCount", n => { ColumnCount = n.GetIntValue(); } },
                { "columnHidden", n => { ColumnHidden = n.GetBoolValue(); } },
                { "columnIndex", n => { ColumnIndex = n.GetIntValue(); } },
                { "format", n => { Format = n.GetObjectValue<global::ApiSdk.Models.WorkbookRangeFormat>(global::ApiSdk.Models.WorkbookRangeFormat.CreateFromDiscriminatorValue); } },
                { "formulas", n => { Formulas = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "formulasLocal", n => { FormulasLocal = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "formulasR1C1", n => { FormulasR1C1 = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "hidden", n => { Hidden = n.GetBoolValue(); } },
                { "numberFormat", n => { NumberFormat = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "rowCount", n => { RowCount = n.GetIntValue(); } },
                { "rowHidden", n => { RowHidden = n.GetBoolValue(); } },
                { "rowIndex", n => { RowIndex = n.GetIntValue(); } },
                { "sort", n => { Sort = n.GetObjectValue<global::ApiSdk.Models.WorkbookRangeSort>(global::ApiSdk.Models.WorkbookRangeSort.CreateFromDiscriminatorValue); } },
                { "text", n => { Text = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "valueTypes", n => { ValueTypes = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "values", n => { Values = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "worksheet", n => { Worksheet = n.GetObjectValue<global::ApiSdk.Models.WorkbookWorksheet>(global::ApiSdk.Models.WorkbookWorksheet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("addressLocal", AddressLocal);
            writer.WriteIntValue("cellCount", CellCount);
            writer.WriteIntValue("columnCount", ColumnCount);
            writer.WriteBoolValue("columnHidden", ColumnHidden);
            writer.WriteIntValue("columnIndex", ColumnIndex);
            writer.WriteObjectValue<global::ApiSdk.Models.WorkbookRangeFormat>("format", Format);
            writer.WriteObjectValue<UntypedNode>("formulas", Formulas);
            writer.WriteObjectValue<UntypedNode>("formulasLocal", FormulasLocal);
            writer.WriteObjectValue<UntypedNode>("formulasR1C1", FormulasR1C1);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<UntypedNode>("numberFormat", NumberFormat);
            writer.WriteIntValue("rowCount", RowCount);
            writer.WriteBoolValue("rowHidden", RowHidden);
            writer.WriteIntValue("rowIndex", RowIndex);
            writer.WriteObjectValue<global::ApiSdk.Models.WorkbookRangeSort>("sort", Sort);
            writer.WriteObjectValue<UntypedNode>("text", Text);
            writer.WriteObjectValue<UntypedNode>("values", Values);
            writer.WriteObjectValue<UntypedNode>("valueTypes", ValueTypes);
            writer.WriteObjectValue<global::ApiSdk.Models.WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
#pragma warning restore CS0618
