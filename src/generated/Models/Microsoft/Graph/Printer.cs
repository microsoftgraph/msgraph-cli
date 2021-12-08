using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Printer : PrinterBase, IParsable {
        /// <summary>The connectors that are associated with the printer.</summary>
        public List<PrintConnector> Connectors { get; set; }
        /// <summary>True if the printer has a physical device for printing. Read-only.</summary>
        public bool? HasPhysicalDevice { get; set; }
        /// <summary>True if the printer is shared; false otherwise. Read-only.</summary>
        public bool? IsShared { get; set; }
        /// <summary>The most recent dateTimeOffset when a printer interacted with Universal Print. Read-only.</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>The DateTimeOffset when the printer was registered. Read-only.</summary>
        public DateTimeOffset? RegisteredDateTime { get; set; }
        /// <summary>The list of printerShares that are associated with the printer. Currently, only one printerShare can be associated with the printer. Read-only. Nullable.</summary>
        public List<PrinterShare> Shares { get; set; }
        /// <summary>A list of task triggers that are associated with the printer.</summary>
        public List<PrintTaskTrigger> TaskTriggers { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"connectors", (o,n) => { (o as Printer).Connectors = n.GetCollectionOfObjectValues<PrintConnector>().ToList(); } },
                {"hasPhysicalDevice", (o,n) => { (o as Printer).HasPhysicalDevice = n.GetBoolValue(); } },
                {"isShared", (o,n) => { (o as Printer).IsShared = n.GetBoolValue(); } },
                {"lastSeenDateTime", (o,n) => { (o as Printer).LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"registeredDateTime", (o,n) => { (o as Printer).RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"shares", (o,n) => { (o as Printer).Shares = n.GetCollectionOfObjectValues<PrinterShare>().ToList(); } },
                {"taskTriggers", (o,n) => { (o as Printer).TaskTriggers = n.GetCollectionOfObjectValues<PrintTaskTrigger>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PrintConnector>("connectors", Connectors);
            writer.WriteBoolValue("hasPhysicalDevice", HasPhysicalDevice);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteDateTimeOffsetValue("registeredDateTime", RegisteredDateTime);
            writer.WriteCollectionOfObjectValues<PrinterShare>("shares", Shares);
            writer.WriteCollectionOfObjectValues<PrintTaskTrigger>("taskTriggers", TaskTriggers);
        }
    }
}
