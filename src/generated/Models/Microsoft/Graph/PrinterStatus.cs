using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrinterStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A human-readable description of the printer's current processing state. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The list of details describing why the printer is in the current state. Valid values are described in the following table. Read-only.</summary>
        public List<PrinterProcessingStateDetail?> Details { get; set; }
        /// <summary>The current processing state. Valid values are described in the following table. Read-only.</summary>
        public PrinterProcessingState? State { get; set; }
        /// <summary>
        /// Instantiates a new printerStatus and sets the default values.
        /// </summary>
        public PrinterStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as PrinterStatus).Description = n.GetStringValue(); } },
                {"details", (o,n) => { (o as PrinterStatus).Details = n.GetCollectionOfEnumValues<PrinterProcessingStateDetail>().ToList(); } },
                {"state", (o,n) => { (o as PrinterStatus).State = n.GetEnumValue<PrinterProcessingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfEnumValues<PrinterProcessingStateDetail>("details", Details);
            writer.WriteEnumValue<PrinterProcessingState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
