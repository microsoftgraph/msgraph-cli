using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ReportRoot : Entity, IParsable {
        public List<PrintUsageByPrinter> DailyPrintUsageByPrinter { get; set; }
        public List<PrintUsageByUser> DailyPrintUsageByUser { get; set; }
        public List<PrintUsageByPrinter> MonthlyPrintUsageByPrinter { get; set; }
        public List<PrintUsageByUser> MonthlyPrintUsageByUser { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"dailyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).DailyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>().ToList(); } },
                {"dailyPrintUsageByUser", (o,n) => { (o as ReportRoot).DailyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>().ToList(); } },
                {"monthlyPrintUsageByPrinter", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByPrinter = n.GetCollectionOfObjectValues<PrintUsageByPrinter>().ToList(); } },
                {"monthlyPrintUsageByUser", (o,n) => { (o as ReportRoot).MonthlyPrintUsageByUser = n.GetCollectionOfObjectValues<PrintUsageByUser>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("dailyPrintUsageByPrinter", DailyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("dailyPrintUsageByUser", DailyPrintUsageByUser);
            writer.WriteCollectionOfObjectValues<PrintUsageByPrinter>("monthlyPrintUsageByPrinter", MonthlyPrintUsageByPrinter);
            writer.WriteCollectionOfObjectValues<PrintUsageByUser>("monthlyPrintUsageByUser", MonthlyPrintUsageByUser);
        }
    }
}
