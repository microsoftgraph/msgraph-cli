using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessPackageAssignment : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property and $expand query parameters.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackage AccessPackage { get; set; }
        public ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy AssignmentPolicy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpiredDateTime { get; set; }
        /// <summary>When the access assignment is to be in place. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule Schedule { get; set; }
        /// <summary>The state of the access package assignment. The possible values are: delivering, partiallyDelivered, delivered, expired, deliveryFailed, unknownFutureValue. Read-only. Supports $filter (eq).</summary>
        public AccessPackageAssignmentState? State { get; set; }
        /// <summary>More information about the assignment lifecycle.  Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered.  Read-only.</summary>
        public string Status { get; set; }
        /// <summary>The subject of the access package assignment. Read-only. Nullable. Supports $expand. Supports $filter (eq) on objectId.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackageSubject Target { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AccessPackageAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackage", (o,n) => { (o as AccessPackageAssignment).AccessPackage = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackage>(ApiSdk.Models.Microsoft.Graph.AccessPackage.CreateFromDiscriminatorValue); } },
                {"assignmentPolicy", (o,n) => { (o as AccessPackageAssignment).AssignmentPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>(ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue); } },
                {"expiredDateTime", (o,n) => { (o as AccessPackageAssignment).ExpiredDateTime = n.GetDateTimeOffsetValue(); } },
                {"schedule", (o,n) => { (o as AccessPackageAssignment).Schedule = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule>(ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
                {"state", (o,n) => { (o as AccessPackageAssignment).State = n.GetEnumValue<AccessPackageAssignmentState>(); } },
                {"status", (o,n) => { (o as AccessPackageAssignment).Status = n.GetStringValue(); } },
                {"target", (o,n) => { (o as AccessPackageAssignment).Target = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageSubject>(ApiSdk.Models.Microsoft.Graph.AccessPackageSubject.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>("assignmentPolicy", AssignmentPolicy);
            writer.WriteDateTimeOffsetValue("expiredDateTime", ExpiredDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteEnumValue<AccessPackageAssignmentState>("state", State);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageSubject>("target", Target);
        }
    }
}
