using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DirectoryAudit : Entity, IParsable {
        /// <summary>Indicates the date and time the activity was performed. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>Indicates the activity name or the operation name (E.g. 'Create User', 'Add member to group'). For a list of activities logged, refer to Azure Ad activity list.</summary>
        public string ActivityDisplayName { get; set; }
        /// <summary>Indicates additional details on the activity.</summary>
        public List<KeyValue> AdditionalDetails { get; set; }
        /// <summary>Indicates which resource category that's targeted by the activity. (For example: User Management, Group Management etc..)</summary>
        public string Category { get; set; }
        /// <summary>Indicates a unique ID that helps correlate activities that span across various services. Can be used to trace logs across services.</summary>
        public string CorrelationId { get; set; }
        public AuditActivityInitiator InitiatedBy { get; set; }
        /// <summary>Indicates information on which service initiated the activity (For example: Self-service Password Management, Core Directory, B2C, Invited Users, Microsoft Identity Manager, Privileged Identity Management.</summary>
        public string LoggedByService { get; set; }
        public string OperationType { get; set; }
        /// <summary>Indicates the result of the activity. Possible values are: success, failure, timeout, unknownFutureValue.</summary>
        public OperationResult? Result { get; set; }
        /// <summary>Indicates the reason for failure if the result is failure or timeout.</summary>
        public string ResultReason { get; set; }
        /// <summary>Information about the resource that changed due to the activity.</summary>
        public List<TargetResource> TargetResources { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DirectoryAudit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryAudit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityDateTime", (o,n) => { (o as DirectoryAudit).ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityDisplayName", (o,n) => { (o as DirectoryAudit).ActivityDisplayName = n.GetStringValue(); } },
                {"additionalDetails", (o,n) => { (o as DirectoryAudit).AdditionalDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"category", (o,n) => { (o as DirectoryAudit).Category = n.GetStringValue(); } },
                {"correlationId", (o,n) => { (o as DirectoryAudit).CorrelationId = n.GetStringValue(); } },
                {"initiatedBy", (o,n) => { (o as DirectoryAudit).InitiatedBy = n.GetObjectValue<AuditActivityInitiator>(AuditActivityInitiator.CreateFromDiscriminatorValue); } },
                {"loggedByService", (o,n) => { (o as DirectoryAudit).LoggedByService = n.GetStringValue(); } },
                {"operationType", (o,n) => { (o as DirectoryAudit).OperationType = n.GetStringValue(); } },
                {"result", (o,n) => { (o as DirectoryAudit).Result = n.GetEnumValue<OperationResult>(); } },
                {"resultReason", (o,n) => { (o as DirectoryAudit).ResultReason = n.GetStringValue(); } },
                {"targetResources", (o,n) => { (o as DirectoryAudit).TargetResources = n.GetCollectionOfObjectValues<TargetResource>(TargetResource.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("activityDisplayName", ActivityDisplayName);
            writer.WriteCollectionOfObjectValues<KeyValue>("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteObjectValue<AuditActivityInitiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("loggedByService", LoggedByService);
            writer.WriteStringValue("operationType", OperationType);
            writer.WriteEnumValue<OperationResult>("result", Result);
            writer.WriteStringValue("resultReason", ResultReason);
            writer.WriteCollectionOfObjectValues<TargetResource>("targetResources", TargetResources);
        }
    }
}
