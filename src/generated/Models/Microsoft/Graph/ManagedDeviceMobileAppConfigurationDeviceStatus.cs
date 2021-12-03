using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedDeviceMobileAppConfigurationDeviceStatus : Entity, IParsable {
        /// <summary>The DateTime when device compliance grace period expires</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
        /// <summary>Device name of the DevicePolicyStatus.</summary>
        public string DeviceDisplayName { get; set; }
        /// <summary>The device model that is being reported</summary>
        public string DeviceModel { get; set; }
        /// <summary>Last modified date time of the policy report.</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>Compliance status of the policy report. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? Status { get; set; }
        /// <summary>The User Name that is being reported</summary>
        public string UserName { get; set; }
        /// <summary>UserPrincipalName.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"complianceGracePeriodExpirationDateTime", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceStatus).ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceDisplayName", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceStatus).DeviceDisplayName = n.GetStringValue(); } },
                {"deviceModel", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceStatus).DeviceModel = n.GetStringValue(); } },
                {"lastReportedDateTime", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceStatus).LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceStatus).Status = n.GetEnumValue<ComplianceStatus>(); } },
                {"userName", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceStatus).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as ManagedDeviceMobileAppConfigurationDeviceStatus).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("complianceGracePeriodExpirationDateTime", ComplianceGracePeriodExpirationDateTime);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteEnumValue<ComplianceStatus>("status", Status);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
