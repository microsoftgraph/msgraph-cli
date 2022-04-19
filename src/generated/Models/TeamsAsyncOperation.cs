using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
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
        /// <summary>The ID of the object that&apos;s created or modified as result of this async operation, typically a team.</summary>
        public string TargetResourceId { get; set; }
        /// <summary>The location of the object that&apos;s created or modified as result of this async operation. This URL should be treated as an opaque value and not parsed into its component paths.</summary>
        public string TargetResourceLocation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsAsyncOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAsyncOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attemptsCount", n => { AttemptsCount = n.GetIntValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", n => { Error = n.GetObjectValue<OperationError>(OperationError.CreateFromDiscriminatorValue); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationType", n => { OperationType = n.GetEnumValue<TeamsAsyncOperationType>(); } },
                {"status", n => { Status = n.GetEnumValue<TeamsAsyncOperationStatus>(); } },
                {"targetResourceId", n => { TargetResourceId = n.GetStringValue(); } },
                {"targetResourceLocation", n => { TargetResourceLocation = n.GetStringValue(); } },
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
