using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DataPolicyOperation : Entity, IParsable {
        /// <summary>Represents when the request for this data policy operation was completed, in UTC time, using the ISO 8601 format. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Null until the operation completes.</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>Specifies the progress of an operation.</summary>
        public double? Progress { get; set; }
        /// <summary>Possible values are: notStarted, running, complete, failed, unknownFutureValue.</summary>
        public DataPolicyOperationStatus? Status { get; set; }
        /// <summary>The URL location to where data is being exported for export requests.</summary>
        public string StorageLocation { get; set; }
        /// <summary>Represents when the request for this data operation was submitted, in UTC time, using the ISO 8601 format. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? SubmittedDateTime { get; set; }
        /// <summary>The id for the user on whom the operation is performed.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DataPolicyOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataPolicyOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"progress", n => { Progress = n.GetDoubleValue(); } },
                {"status", n => { Status = n.GetEnumValue<DataPolicyOperationStatus>(); } },
                {"storageLocation", n => { StorageLocation = n.GetStringValue(); } },
                {"submittedDateTime", n => { SubmittedDateTime = n.GetDateTimeOffsetValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteDoubleValue("progress", Progress);
            writer.WriteEnumValue<DataPolicyOperationStatus>("status", Status);
            writer.WriteStringValue("storageLocation", StorageLocation);
            writer.WriteDateTimeOffsetValue("submittedDateTime", SubmittedDateTime);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
