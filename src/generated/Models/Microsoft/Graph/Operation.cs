using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Operation : Entity, IParsable {
        /// <summary>The start time of the operation.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The time of the last action of the operation.</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The current status of the operation: notStarted, running, completed, failed</summary>
        public OperationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Operation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Operation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as Operation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastActionDateTime", (o,n) => { (o as Operation).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as Operation).Status = n.GetEnumValue<OperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteEnumValue<OperationStatus>("status", Status);
        }
    }
}
