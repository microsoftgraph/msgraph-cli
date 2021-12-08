using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintOperationStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A human-readable description of the printOperation's current processing state. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The printOperation's current processing state. Valid values are described in the following table. Read-only.</summary>
        public PrintOperationProcessingState? State { get; set; }
        /// <summary>
        /// Instantiates a new printOperationStatus and sets the default values.
        /// </summary>
        public PrintOperationStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as PrintOperationStatus).Description = n.GetStringValue(); } },
                {"state", (o,n) => { (o as PrintOperationStatus).State = n.GetEnumValue<PrintOperationProcessingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<PrintOperationProcessingState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
