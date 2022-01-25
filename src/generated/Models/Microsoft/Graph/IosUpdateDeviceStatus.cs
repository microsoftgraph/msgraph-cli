using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IosUpdateDeviceStatus : Entity, IParsable {
        /// <summary>The DateTime when device compliance grace period expires</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
        /// <summary>Device name of the DevicePolicyStatus.</summary>
        public string DeviceDisplayName { get; set; }
        /// <summary>The device id that is being reported.</summary>
        public string DeviceId { get; set; }
        /// <summary>The device model that is being reported</summary>
        public string DeviceModel { get; set; }
        /// <summary>The installation status of the policy report. Possible values are: success, available, idle, unknown, mdmClientCrashed, timeout, downloading, downloadFailed, downloadRequiresComputer, downloadInsufficientSpace, downloadInsufficientPower, downloadInsufficientNetwork, installing, installInsufficientSpace, installInsufficientPower, installPhoneCallInProgress, installFailed, notSupportedOperation, sharedDeviceUserLoggedInError, updateError, deviceOsHigherThanDesiredOsVersion, updateScanFailed.</summary>
        public IosUpdatesInstallStatus? InstallStatus { get; set; }
        /// <summary>Last modified date time of the policy report.</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>The device version that is being reported.</summary>
        public string OsVersion { get; set; }
        /// <summary>Compliance status of the policy report. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? Status { get; set; }
        /// <summary>The User id that is being reported.</summary>
        public string UserId { get; set; }
        /// <summary>The User Name that is being reported</summary>
        public string UserName { get; set; }
        /// <summary>UserPrincipalName.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"complianceGracePeriodExpirationDateTime", (o,n) => { (o as IosUpdateDeviceStatus).ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceDisplayName", (o,n) => { (o as IosUpdateDeviceStatus).DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", (o,n) => { (o as IosUpdateDeviceStatus).DeviceId = n.GetStringValue(); } },
                {"deviceModel", (o,n) => { (o as IosUpdateDeviceStatus).DeviceModel = n.GetStringValue(); } },
                {"installStatus", (o,n) => { (o as IosUpdateDeviceStatus).InstallStatus = n.GetEnumValue<IosUpdatesInstallStatus>(); } },
                {"lastReportedDateTime", (o,n) => { (o as IosUpdateDeviceStatus).LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"osVersion", (o,n) => { (o as IosUpdateDeviceStatus).OsVersion = n.GetStringValue(); } },
                {"status", (o,n) => { (o as IosUpdateDeviceStatus).Status = n.GetEnumValue<ComplianceStatus>(); } },
                {"userId", (o,n) => { (o as IosUpdateDeviceStatus).UserId = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as IosUpdateDeviceStatus).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as IosUpdateDeviceStatus).UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteEnumValue<IosUpdatesInstallStatus>("installStatus", InstallStatus);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteEnumValue<ComplianceStatus>("status", Status);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
