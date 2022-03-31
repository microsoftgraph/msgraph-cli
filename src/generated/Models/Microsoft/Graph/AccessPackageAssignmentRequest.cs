using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessPackageAssignmentRequest : Entity, IParsable {
        /// <summary>The access package associated with the accessPackageAssignmentRequest. An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources. Read-only. Nullable.  Supports $expand.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackage AccessPackage { get; set; }
        /// <summary>For a requestType of UserAdd or AdminAdd, this is an access package assignment requested to be created.  For a requestType of UserRemove, AdminRemove or SystemRemove, this has the id property of an existing assignment to be removed.   Supports $expand.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackageAssignment Assignment { get; set; }
        /// <summary>The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The subject who requested or, if a direct assignment, was assigned. Read-only. Nullable. Supports $expand.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackageSubject Requestor { get; set; }
        /// <summary>The type of the request. The possible values are: notSpecified, userAdd, userUpdate, userRemove, adminAdd, adminUpdate, adminRemove, systemAdd, systemUpdate, systemRemove, onBehalfAdd, unknownFutureValue. A request from the user themselves would have requestType of UserAdd or UserRemove. This property cannot be changed once set.</summary>
        public AccessPackageRequestType? RequestType { get; set; }
        /// <summary>The range of dates that access is to be assigned to the requestor. This property cannot be changed once set.</summary>
        public ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule Schedule { get; set; }
        /// <summary>The state of the request. The possible values are: submitted, pendingApproval, delivering, delivered, deliveryFailed, denied, scheduled, canceled, partiallyDelivered, unknownFutureValue. Read-only.</summary>
        public AccessPackageRequestState? State { get; set; }
        /// <summary>More information on the request processing status. Read-only.</summary>
        public string Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackage", (o,n) => { (o as AccessPackageAssignmentRequest).AccessPackage = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackage>(ApiSdk.Models.Microsoft.Graph.AccessPackage.CreateFromDiscriminatorValue); } },
                {"assignment", (o,n) => { (o as AccessPackageAssignmentRequest).Assignment = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignment>(ApiSdk.Models.Microsoft.Graph.AccessPackageAssignment.CreateFromDiscriminatorValue); } },
                {"completedDateTime", (o,n) => { (o as AccessPackageAssignmentRequest).CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", (o,n) => { (o as AccessPackageAssignmentRequest).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestor", (o,n) => { (o as AccessPackageAssignmentRequest).Requestor = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageSubject>(ApiSdk.Models.Microsoft.Graph.AccessPackageSubject.CreateFromDiscriminatorValue); } },
                {"requestType", (o,n) => { (o as AccessPackageAssignmentRequest).RequestType = n.GetEnumValue<AccessPackageRequestType>(); } },
                {"schedule", (o,n) => { (o as AccessPackageAssignmentRequest).Schedule = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule>(ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
                {"state", (o,n) => { (o as AccessPackageAssignmentRequest).State = n.GetEnumValue<AccessPackageRequestState>(); } },
                {"status", (o,n) => { (o as AccessPackageAssignmentRequest).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignment>("assignment", Assignment);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageSubject>("requestor", Requestor);
            writer.WriteEnumValue<AccessPackageRequestType>("requestType", RequestType);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteEnumValue<AccessPackageRequestState>("state", State);
            writer.WriteStringValue("status", Status);
        }
    }
}
