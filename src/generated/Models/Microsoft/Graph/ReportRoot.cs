using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>The resource that represents an instance of Enrollment Failure Reports.</summary>
    public class ReportRoot : Entity, IParsable {
        public List<ApiSdk.Models.Microsoft.Graph.PrintUsageByPrinter> DailyPrintUsageByPrinter { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.PrintUsageByUser> DailyPrintUsageByUser { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.PrintUsageByPrinter> MonthlyPrintUsageByPrinter { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.PrintUsageByUser> MonthlyPrintUsageByUser { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ReportRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReportRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"dailyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).DailyPrintUsageByPrinter = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintUsageByPrinter>(ApiSdk.Models.Microsoft.Graph.PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"dailyPrintUsageByUser", (o,n) => { (o as ReportRoot).DailyPrintUsageByUser = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintUsageByUser>(ApiSdk.Models.Microsoft.Graph.PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByPrinter = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintUsageByPrinter>(ApiSdk.Models.Microsoft.Graph.PrintUsageByPrinter.CreateFromDiscriminatorValue).ToList(); } },
                {"monthlyPrintUsageByUser", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByUser = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintUsageByUser>(ApiSdk.Models.Microsoft.Graph.PrintUsageByUser.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintUsageByPrinter>("dailyPrintUsageByPrinter", DailyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintUsageByUser>("dailyPrintUsageByUser", DailyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintUsageByPrinter>("monthlyPrintUsageByPrinter", MonthlyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PrintUsageByUser>("monthlyPrintUsageByUser", MonthlyPrintUsageByUser);
        }
    }
}
