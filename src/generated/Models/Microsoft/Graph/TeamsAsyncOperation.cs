using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TeamsAsyncOperation : Entity, IParsable {
        /// <summary>Number of times the operation was attempted before being marked successful or failed.</summary>
        public int? AttemptsCount { get; set; }
        /// <summary>Time when the operation was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Any error that causes the async operation to fail.</summary>
        public OperationError Error { get; set; }
        /// <summary>Time when the async operation was last updated.</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>Denotes which type of operation is being described.</summary>
        public TeamsAsyncOperationType? OperationType { get; set; }
        /// <summary>Operation status.</summary>
        public TeamsAsyncOperationStatus? Status { get; set; }
        /// <summary>The ID of the object that's created or modified as result of this async operation, typically a team.</summary>
        public string TargetResourceId { get; set; }
        /// <summary>The location of the object that's created or modified as result of this async operation. This URL should be treated as an opaque value and not parsed into its component paths.</summary>
        public string TargetResourceLocation { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"attemptsCount", (o,n) => { (o as TeamsAsyncOperation).AttemptsCount = n.GetIntValue(); } },
                {"createdDateTime", (o,n) => { (o as TeamsAsyncOperation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", (o,n) => { (o as TeamsAsyncOperation).Error = n.GetObjectValue<OperationError>(); } },
                {"lastActionDateTime", (o,n) => { (o as TeamsAsyncOperation).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationType", (o,n) => { (o as TeamsAsyncOperation).OperationType = n.GetEnumValue<TeamsAsyncOperationType>(); } },
                {"status", (o,n) => { (o as TeamsAsyncOperation).Status = n.GetEnumValue<TeamsAsyncOperationStatus>(); } },
                {"targetResourceId", (o,n) => { (o as TeamsAsyncOperation).TargetResourceId = n.GetStringValue(); } },
                {"targetResourceLocation", (o,n) => { (o as TeamsAsyncOperation).TargetResourceLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("attemptsCount", AttemptsCount);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<OperationError>("error", Error);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteEnumValue<TeamsAsyncOperationType>("operationType", OperationType);
            writer.WriteEnumValue<TeamsAsyncOperationStatus>("status", Status);
            writer.WriteStringValue("targetResourceId", TargetResourceId);
            writer.WriteStringValue("targetResourceLocation", TargetResourceLocation);
        }
    }
}
