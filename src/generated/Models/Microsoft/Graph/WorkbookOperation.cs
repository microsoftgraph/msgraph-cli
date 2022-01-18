using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookOperation : Entity, IParsable {
        /// <summary>The error returned by the operation.</summary>
        public WorkbookOperationError Error { get; set; }
        /// <summary>The resource URI for the result.</summary>
        public string ResourceLocation { get; set; }
        /// <summary>The current status of the operation. Possible values are: notStarted, running, succeeded, failed.</summary>
        public WorkbookOperationStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"error", (o,n) => { (o as WorkbookOperation).Error = n.GetObjectValue<WorkbookOperationError>(); } },
                {"resourceLocation", (o,n) => { (o as WorkbookOperation).ResourceLocation = n.GetStringValue(); } },
                {"status", (o,n) => { (o as WorkbookOperation).Status = n.GetEnumValue<WorkbookOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookOperationError>("error", Error);
            writer.WriteStringValue("resourceLocation", ResourceLocation);
            writer.WriteEnumValue<WorkbookOperationStatus>("status", Status);
        }
    }
}
