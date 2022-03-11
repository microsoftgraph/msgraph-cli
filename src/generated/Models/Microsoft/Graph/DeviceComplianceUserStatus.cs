using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceComplianceUserStatus : Entity, IParsable {
        /// <summary>Devices count for that user.</summary>
        public int? DevicesCount { get; set; }
        /// <summary>Last modified date time of the policy report.</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>Compliance status of the policy report. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? Status { get; set; }
        /// <summary>User name of the DevicePolicyStatus.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>UserPrincipalName.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceComplianceUserStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceUserStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"devicesCount", (o,n) => { (o as DeviceComplianceUserStatus).DevicesCount = n.GetIntValue(); } },
                {"lastReportedDateTime", (o,n) => { (o as DeviceComplianceUserStatus).LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as DeviceComplianceUserStatus).Status = n.GetEnumValue<ComplianceStatus>(); } },
                {"userDisplayName", (o,n) => { (o as DeviceComplianceUserStatus).UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as DeviceComplianceUserStatus).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("devicesCount", DevicesCount);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteEnumValue<ComplianceStatus>("status", Status);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
