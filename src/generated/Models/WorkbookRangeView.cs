using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WorkbookRangeView : Entity, IParsable {
        /// <summary>Represents the cell addresses</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? CellAddresses { get; set; }
#nullable restore
#else
        public Json CellAddresses { get; set; }
#endif
        /// <summary>Returns the number of visible columns. Read-only.</summary>
        public int? ColumnCount { get; set; }
        /// <summary>Represents the formula in A1-style notation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Formulas { get; set; }
#nullable restore
#else
        public Json Formulas { get; set; }
#endif
        /// <summary>Represents the formula in A1-style notation, in the user&apos;s language and number-formatting locale. For example, the English &apos;=SUM(A1, 1.5)&apos; formula would become &apos;=SUMME(A1; 1,5)&apos; in German.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? FormulasLocal { get; set; }
#nullable restore
#else
        public Json FormulasLocal { get; set; }
#endif
        /// <summary>Represents the formula in R1C1-style notation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? FormulasR1C1 { get; set; }
#nullable restore
#else
        public Json FormulasR1C1 { get; set; }
#endif
        /// <summary>Index of the range.</summary>
        public int? Index { get; set; }
        /// <summary>Represents Excel&apos;s number format code for the given cell. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NumberFormat { get; set; }
#nullable restore
#else
        public Json NumberFormat { get; set; }
#endif
        /// <summary>Returns the number of visible rows. Read-only.</summary>
        public int? RowCount { get; set; }
        /// <summary>Represents a collection of range views associated with the range. Read-only. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookRangeView>? Rows { get; set; }
#nullable restore
#else
        public List<WorkbookRangeView> Rows { get; set; }
#endif
        /// <summary>Text values of the specified range. The Text value will not depend on the cell width. The # sign substitution that happens in Excel UI will not affect the text value returned by the API. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Text { get; set; }
#nullable restore
#else
        public Json Text { get; set; }
#endif
        /// <summary>Represents the raw values of the specified range view. The data returned could be of type string, number, or a boolean. Cell that contain an error will return the error string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Values { get; set; }
#nullable restore
#else
        public Json Values { get; set; }
#endif
        /// <summary>Represents the type of data of each cell. Read-only. The possible values are: Unknown, Empty, String, Integer, Double, Boolean, Error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ValueTypes { get; set; }
#nullable restore
#else
        public Json ValueTypes { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookRangeView CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookRangeView();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cellAddresses", n => { CellAddresses = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"columnCount", n => { ColumnCount = n.GetIntValue(); } },
                {"formulas", n => { Formulas = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"formulasLocal", n => { FormulasLocal = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"formulasR1C1", n => { FormulasR1C1 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"index", n => { Index = n.GetIntValue(); } },
                {"numberFormat", n => { NumberFormat = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rowCount", n => { RowCount = n.GetIntValue(); } },
                {"rows", n => { Rows = n.GetCollectionOfObjectValues<WorkbookRangeView>(WorkbookRangeView.CreateFromDiscriminatorValue)?.ToList(); } },
                {"text", n => { Text = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"values", n => { Values = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"valueTypes", n => { ValueTypes = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Json>("cellAddresses", CellAddresses);
            writer.WriteIntValue("columnCount", ColumnCount);
            writer.WriteObjectValue<Json>("formulas", Formulas);
            writer.WriteObjectValue<Json>("formulasLocal", FormulasLocal);
            writer.WriteObjectValue<Json>("formulasR1C1", FormulasR1C1);
            writer.WriteIntValue("index", Index);
            writer.WriteObjectValue<Json>("numberFormat", NumberFormat);
            writer.WriteIntValue("rowCount", RowCount);
            writer.WriteCollectionOfObjectValues<WorkbookRangeView>("rows", Rows);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteObjectValue<Json>("values", Values);
            writer.WriteObjectValue<Json>("valueTypes", ValueTypes);
        }
    }
}
