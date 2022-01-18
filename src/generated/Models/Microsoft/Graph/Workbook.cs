using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Workbook : Entity, IParsable {
        public WorkbookApplication Application { get; set; }
        public List<WorkbookComment> Comments { get; set; }
        public WorkbookFunctions Functions { get; set; }
        /// <summary>Represents a collection of workbooks scoped named items (named ranges and constants). Read-only.</summary>
        public List<WorkbookNamedItem> Names { get; set; }
        /// <summary>The status of Workbook operations. Getting an operation collection is not supported, but you can get the status of a long-running operation if the Location header is returned in the response. Read-only. Nullable.</summary>
        public List<WorkbookOperation> Operations { get; set; }
        /// <summary>Represents a collection of tables associated with the workbook. Read-only.</summary>
        public List<WorkbookTable> Tables { get; set; }
        /// <summary>Represents a collection of worksheets associated with the workbook. Read-only.</summary>
        public List<WorkbookWorksheet> Worksheets { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"application", (o,n) => { (o as Workbook).Application = n.GetObjectValue<WorkbookApplication>(); } },
                {"comments", (o,n) => { (o as Workbook).Comments = n.GetCollectionOfObjectValues<WorkbookComment>().ToList(); } },
                {"functions", (o,n) => { (o as Workbook).Functions = n.GetObjectValue<WorkbookFunctions>(); } },
                {"names", (o,n) => { (o as Workbook).Names = n.GetCollectionOfObjectValues<WorkbookNamedItem>().ToList(); } },
                {"operations", (o,n) => { (o as Workbook).Operations = n.GetCollectionOfObjectValues<WorkbookOperation>().ToList(); } },
                {"tables", (o,n) => { (o as Workbook).Tables = n.GetCollectionOfObjectValues<WorkbookTable>().ToList(); } },
                {"worksheets", (o,n) => { (o as Workbook).Worksheets = n.GetCollectionOfObjectValues<WorkbookWorksheet>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookApplication>("application", Application);
            writer.WriteCollectionOfObjectValues<WorkbookComment>("comments", Comments);
            writer.WriteObjectValue<WorkbookFunctions>("functions", Functions);
            writer.WriteCollectionOfObjectValues<WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<WorkbookOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<WorkbookTable>("tables", Tables);
            writer.WriteCollectionOfObjectValues<WorkbookWorksheet>("worksheets", Worksheets);
        }
    }
}
