using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookWorksheet : Entity, IParsable {
        /// <summary>Returns collection of charts that are part of the worksheet. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookChart> Charts { get; set; }
        /// <summary>The display name of the worksheet.</summary>
        public string Name { get; set; }
        /// <summary>Returns collection of names that are associated with the worksheet. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookNamedItem> Names { get; set; }
        /// <summary>Collection of PivotTables that are part of the worksheet.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookPivotTable> PivotTables { get; set; }
        /// <summary>The zero-based position of the worksheet within the workbook.</summary>
        public int? Position { get; set; }
        /// <summary>Returns sheet protection object for a worksheet. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.WorkbookWorksheetProtection Protection { get; set; }
        /// <summary>Collection of tables that are part of the worksheet. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookTable> Tables { get; set; }
        /// <summary>The Visibility of the worksheet. The possible values are: Visible, Hidden, VeryHidden.</summary>
        public string Visibility { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookWorksheet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"charts", (o,n) => { (o as WorkbookWorksheet).Charts = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookChart>(ApiSdk.Models.Microsoft.Graph.WorkbookChart.CreateFromDiscriminatorValue).ToList(); } },
                {"name", (o,n) => { (o as WorkbookWorksheet).Name = n.GetStringValue(); } },
                {"names", (o,n) => { (o as WorkbookWorksheet).Names = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookNamedItem>(ApiSdk.Models.Microsoft.Graph.WorkbookNamedItem.CreateFromDiscriminatorValue).ToList(); } },
                {"pivotTables", (o,n) => { (o as WorkbookWorksheet).PivotTables = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookPivotTable>(ApiSdk.Models.Microsoft.Graph.WorkbookPivotTable.CreateFromDiscriminatorValue).ToList(); } },
                {"position", (o,n) => { (o as WorkbookWorksheet).Position = n.GetIntValue(); } },
                {"protection", (o,n) => { (o as WorkbookWorksheet).Protection = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookWorksheetProtection>(ApiSdk.Models.Microsoft.Graph.WorkbookWorksheetProtection.CreateFromDiscriminatorValue); } },
                {"tables", (o,n) => { (o as WorkbookWorksheet).Tables = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookTable>(ApiSdk.Models.Microsoft.Graph.WorkbookTable.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookChart>("charts", Charts);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookPivotTable>("pivotTables", PivotTables);
            writer.WriteIntValue("position", Position);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookWorksheetProtection>("protection", Protection);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookTable>("tables", Tables);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
