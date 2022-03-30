using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Request : Entity, IParsable {
        /// <summary>The identifier of the approval of the request.</summary>
        public string ApprovalId { get; set; }
        /// <summary>The request completion date time.</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>The user who created this request.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySet CreatedBy { get; set; }
        /// <summary>The request creation date time.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Free text field to define any custom data for the request. Not used.</summary>
        public string CustomData { get; set; }
        /// <summary>The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.</summary>
        public string Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Request CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"approvalId", (o,n) => { (o as Request).ApprovalId = n.GetStringValue(); } },
                {"completedDateTime", (o,n) => { (o as Request).CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", (o,n) => { (o as Request).CreatedBy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as Request).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customData", (o,n) => { (o as Request).CustomData = n.GetStringValue(); } },
                {"status", (o,n) => { (o as Request).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("approvalId", ApprovalId);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("customData", CustomData);
            writer.WriteStringValue("status", Status);
        }
    }
}
