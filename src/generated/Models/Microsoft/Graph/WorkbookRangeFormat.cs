using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookRangeFormat : Entity, IParsable {
        /// <summary>Collection of border objects that apply to the overall range selected Read-only.</summary>
        public List<WorkbookRangeBorder> Borders { get; set; }
        /// <summary>Gets or sets the width of all colums within the range. If the column widths are not uniform, null will be returned.</summary>
        public double? ColumnWidth { get; set; }
        /// <summary>Returns the fill object defined on the overall range. Read-only.</summary>
        public WorkbookRangeFill Fill { get; set; }
        /// <summary>Returns the font object defined on the overall range selected Read-only.</summary>
        public WorkbookRangeFont Font { get; set; }
        /// <summary>Represents the horizontal alignment for the specified object. Possible values are: General, Left, Center, Right, Fill, Justify, CenterAcrossSelection, Distributed.</summary>
        public string HorizontalAlignment { get; set; }
        /// <summary>Returns the format protection object for a range. Read-only.</summary>
        public WorkbookFormatProtection Protection { get; set; }
        /// <summary>Gets or sets the height of all rows in the range. If the row heights are not uniform null will be returned.</summary>
        public double? RowHeight { get; set; }
        /// <summary>Represents the vertical alignment for the specified object. Possible values are: Top, Center, Bottom, Justify, Distributed.</summary>
        public string VerticalAlignment { get; set; }
        /// <summary>Indicates if Excel wraps the text in the object. A null value indicates that the entire range doesn't have uniform wrap setting</summary>
        public bool? WrapText { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookRangeFormat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookRangeFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"borders", (o,n) => { (o as WorkbookRangeFormat).Borders = n.GetCollectionOfObjectValues<WorkbookRangeBorder>(WorkbookRangeBorder.CreateFromDiscriminatorValue).ToList(); } },
                {"columnWidth", (o,n) => { (o as WorkbookRangeFormat).ColumnWidth = n.GetDoubleValue(); } },
                {"fill", (o,n) => { (o as WorkbookRangeFormat).Fill = n.GetObjectValue<WorkbookRangeFill>(WorkbookRangeFill.CreateFromDiscriminatorValue); } },
                {"font", (o,n) => { (o as WorkbookRangeFormat).Font = n.GetObjectValue<WorkbookRangeFont>(WorkbookRangeFont.CreateFromDiscriminatorValue); } },
                {"horizontalAlignment", (o,n) => { (o as WorkbookRangeFormat).HorizontalAlignment = n.GetStringValue(); } },
                {"protection", (o,n) => { (o as WorkbookRangeFormat).Protection = n.GetObjectValue<WorkbookFormatProtection>(WorkbookFormatProtection.CreateFromDiscriminatorValue); } },
                {"rowHeight", (o,n) => { (o as WorkbookRangeFormat).RowHeight = n.GetDoubleValue(); } },
                {"verticalAlignment", (o,n) => { (o as WorkbookRangeFormat).VerticalAlignment = n.GetStringValue(); } },
                {"wrapText", (o,n) => { (o as WorkbookRangeFormat).WrapText = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WorkbookRangeBorder>("borders", Borders);
            writer.WriteDoubleValue("columnWidth", ColumnWidth);
            writer.WriteObjectValue<WorkbookRangeFill>("fill", Fill);
            writer.WriteObjectValue<WorkbookRangeFont>("font", Font);
            writer.WriteStringValue("horizontalAlignment", HorizontalAlignment);
            writer.WriteObjectValue<WorkbookFormatProtection>("protection", Protection);
            writer.WriteDoubleValue("rowHeight", RowHeight);
            writer.WriteStringValue("verticalAlignment", VerticalAlignment);
            writer.WriteBoolValue("wrapText", WrapText);
        }
    }
}
