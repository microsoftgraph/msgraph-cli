using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintTaskStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A human-readable description of the current processing state of the printTask.</summary>
        public string Description { get; set; }
        /// <summary>The current processing state of the printTask. Valid values are described in the following table.</summary>
        public PrintTaskProcessingState? State { get; set; }
        /// <summary>
        /// Instantiates a new printTaskStatus and sets the default values.
        /// </summary>
        public PrintTaskStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as PrintTaskStatus).Description = n.GetStringValue(); } },
                {"state", (o,n) => { (o as PrintTaskStatus).State = n.GetEnumValue<PrintTaskProcessingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<PrintTaskProcessingState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
