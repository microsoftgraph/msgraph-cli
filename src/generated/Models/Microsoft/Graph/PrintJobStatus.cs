using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintJobStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A human-readable description of the print job's current processing state. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>Additional details for print job state. Valid values are described in the following table. Read-only.</summary>
        public List<PrintJobStateDetail?> Details { get; set; }
        /// <summary>True if the job was acknowledged by a printer; false otherwise. Read-only.</summary>
        public bool? IsAcquiredByPrinter { get; set; }
        /// <summary>The print job's current processing state. Valid values are described in the following table. Read-only.</summary>
        public PrintJobProcessingState? State { get; set; }
        /// <summary>
        /// Instantiates a new printJobStatus and sets the default values.
        /// </summary>
        public PrintJobStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as PrintJobStatus).Description = n.GetStringValue(); } },
                {"details", (o,n) => { (o as PrintJobStatus).Details = n.GetCollectionOfEnumValues<PrintJobStateDetail>().ToList(); } },
                {"isAcquiredByPrinter", (o,n) => { (o as PrintJobStatus).IsAcquiredByPrinter = n.GetBoolValue(); } },
                {"state", (o,n) => { (o as PrintJobStatus).State = n.GetEnumValue<PrintJobProcessingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfEnumValues<PrintJobStateDetail>("details", Details);
            writer.WriteBoolValue("isAcquiredByPrinter", IsAcquiredByPrinter);
            writer.WriteEnumValue<PrintJobProcessingState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
