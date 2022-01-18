using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintTask : Entity, IParsable {
        public PrintTaskDefinition Definition { get; set; }
        /// <summary>The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.</summary>
        public string ParentUrl { get; set; }
        public PrintTaskStatus Status { get; set; }
        public PrintTaskTrigger Trigger { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"definition", (o,n) => { (o as PrintTask).Definition = n.GetObjectValue<PrintTaskDefinition>(); } },
                {"parentUrl", (o,n) => { (o as PrintTask).ParentUrl = n.GetStringValue(); } },
                {"status", (o,n) => { (o as PrintTask).Status = n.GetObjectValue<PrintTaskStatus>(); } },
                {"trigger", (o,n) => { (o as PrintTask).Trigger = n.GetObjectValue<PrintTaskTrigger>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrintTaskDefinition>("definition", Definition);
            writer.WriteStringValue("parentUrl", ParentUrl);
            writer.WriteObjectValue<PrintTaskStatus>("status", Status);
            writer.WriteObjectValue<PrintTaskTrigger>("trigger", Trigger);
        }
    }
}
