using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessPackageAssignment : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackage AccessPackage { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpiredDateTime { get; set; }
        /// <summary>When the access assignment is to be in place. Read-only.</summary>
        public EntitlementManagementSchedule Schedule { get; set; }
        public AccessPackageAssignmentState? State { get; set; }
        public string Status { get; set; }
        /// <summary>The subject of the access package assignment. Read-only. Nullable.</summary>
        public AccessPackageSubject Target { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackage", (o,n) => { (o as AccessPackageAssignment).AccessPackage = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackage>(); } },
                {"expiredDateTime", (o,n) => { (o as AccessPackageAssignment).ExpiredDateTime = n.GetDateTimeOffsetValue(); } },
                {"schedule", (o,n) => { (o as AccessPackageAssignment).Schedule = n.GetObjectValue<EntitlementManagementSchedule>(); } },
                {"state", (o,n) => { (o as AccessPackageAssignment).State = n.GetEnumValue<AccessPackageAssignmentState>(); } },
                {"status", (o,n) => { (o as AccessPackageAssignment).Status = n.GetStringValue(); } },
                {"target", (o,n) => { (o as AccessPackageAssignment).Target = n.GetObjectValue<AccessPackageSubject>(); } },
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
            writer.WriteDateTimeOffsetValue("expiredDateTime", ExpiredDateTime);
            writer.WriteObjectValue<EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteEnumValue<AccessPackageAssignmentState>("state", State);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<AccessPackageSubject>("target", Target);
        }
    }
}
