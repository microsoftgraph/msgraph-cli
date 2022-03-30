using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Workbook : Entity, IParsable {
        public ApiSdk.Models.Microsoft.Graph.WorkbookApplication Application { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookComment> Comments { get; set; }
        public ApiSdk.Models.Microsoft.Graph.WorkbookFunctions Functions { get; set; }
        /// <summary>Represents a collection of workbooks scoped named items (named ranges and constants). Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookNamedItem> Names { get; set; }
        /// <summary>The status of workbook operations. Getting an operation collection is not supported, but you can get the status of a long-running operation if the Location header is returned in the response. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookOperation> Operations { get; set; }
        /// <summary>Represents a collection of tables associated with the workbook. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookTable> Tables { get; set; }
        /// <summary>Represents a collection of worksheets associated with the workbook. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet> Worksheets { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Workbook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Workbook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"application", (o,n) => { (o as Workbook).Application = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookApplication>(ApiSdk.Models.Microsoft.Graph.WorkbookApplication.CreateFromDiscriminatorValue); } },
                {"comments", (o,n) => { (o as Workbook).Comments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookComment>(ApiSdk.Models.Microsoft.Graph.WorkbookComment.CreateFromDiscriminatorValue).ToList(); } },
                {"functions", (o,n) => { (o as Workbook).Functions = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookFunctions>(ApiSdk.Models.Microsoft.Graph.WorkbookFunctions.CreateFromDiscriminatorValue); } },
                {"names", (o,n) => { (o as Workbook).Names = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookNamedItem>(ApiSdk.Models.Microsoft.Graph.WorkbookNamedItem.CreateFromDiscriminatorValue).ToList(); } },
                {"operations", (o,n) => { (o as Workbook).Operations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookOperation>(ApiSdk.Models.Microsoft.Graph.WorkbookOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"tables", (o,n) => { (o as Workbook).Tables = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookTable>(ApiSdk.Models.Microsoft.Graph.WorkbookTable.CreateFromDiscriminatorValue).ToList(); } },
                {"worksheets", (o,n) => { (o as Workbook).Worksheets = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet>(ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookApplication>("application", Application);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookComment>("comments", Comments);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookFunctions>("functions", Functions);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookTable>("tables", Tables);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkbookWorksheet>("worksheets", Worksheets);
        }
    }
}
