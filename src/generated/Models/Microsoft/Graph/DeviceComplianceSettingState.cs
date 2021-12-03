using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceComplianceSettingState : Entity, IParsable {
        /// <summary>The DateTime when device compliance grace period expires</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
        /// <summary>The Device Id that is being reported</summary>
        public string DeviceId { get; set; }
        /// <summary>The device model that is being reported</summary>
        public string DeviceModel { get; set; }
        /// <summary>The Device Name that is being reported</summary>
        public string DeviceName { get; set; }
        /// <summary>The setting class name and property name.</summary>
        public string Setting { get; set; }
        /// <summary>The Setting Name that is being reported</summary>
        public string SettingName { get; set; }
        /// <summary>The compliance state of the setting. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? State { get; set; }
        /// <summary>The User email address that is being reported</summary>
        public string UserEmail { get; set; }
        /// <summary>The user Id that is being reported</summary>
        public string UserId { get; set; }
        /// <summary>The User Name that is being reported</summary>
        public string UserName { get; set; }
        /// <summary>The User PrincipalName that is being reported</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"complianceGracePeriodExpirationDateTime", (o,n) => { (o as DeviceComplianceSettingState).ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceId", (o,n) => { (o as DeviceComplianceSettingState).DeviceId = n.GetStringValue(); } },
                {"deviceModel", (o,n) => { (o as DeviceComplianceSettingState).DeviceModel = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as DeviceComplianceSettingState).DeviceName = n.GetStringValue(); } },
                {"setting", (o,n) => { (o as DeviceComplianceSettingState).Setting = n.GetStringValue(); } },
                {"settingName", (o,n) => { (o as DeviceComplianceSettingState).SettingName = n.GetStringValue(); } },
                {"state", (o,n) => { (o as DeviceComplianceSettingState).State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userEmail", (o,n) => { (o as DeviceComplianceSettingState).UserEmail = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as DeviceComplianceSettingState).UserId = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as DeviceComplianceSettingState).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as DeviceComplianceSettingState).UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
