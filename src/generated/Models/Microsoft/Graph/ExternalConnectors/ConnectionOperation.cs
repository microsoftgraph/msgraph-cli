using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class ConnectionOperation : Entity, IParsable {
        /// <summary>If status is failed, provides more information about the error that caused the failure.</summary>
        public PublicError Error { get; set; }
        /// <summary>Indicates the status of the asynchronous operation. Possible values are: unspecified, inprogress, completed, failed.</summary>
        public ConnectionOperationStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"error", (o,n) => { (o as ConnectionOperation).Error = n.GetObjectValue<PublicError>(); } },
                {"status", (o,n) => { (o as ConnectionOperation).Status = n.GetEnumValue<ConnectionOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PublicError>("error", Error);
            writer.WriteEnumValue<ConnectionOperationStatus>("status", Status);
        }
    }
}
