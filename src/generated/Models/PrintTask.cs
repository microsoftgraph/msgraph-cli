using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public class PrintTask : Entity, IParsable {
        /// <summary>The definition property</summary>
        public PrintTaskDefinition Definition { get; set; }
        /// <summary>The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.</summary>
        public string ParentUrl { get; set; }
        /// <summary>The status property</summary>
        public PrintTaskStatus Status { get; set; }
        /// <summary>The trigger property</summary>
        public PrintTaskTrigger Trigger { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definition", n => { Definition = n.GetObjectValue<PrintTaskDefinition>(PrintTaskDefinition.CreateFromDiscriminatorValue); } },
                {"parentUrl", n => { ParentUrl = n.GetStringValue(); } },
                {"status", n => { Status = n.GetObjectValue<PrintTaskStatus>(PrintTaskStatus.CreateFromDiscriminatorValue); } },
                {"trigger", n => { Trigger = n.GetObjectValue<PrintTaskTrigger>(PrintTaskTrigger.CreateFromDiscriminatorValue); } },
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
